using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using SFTP_Files_Validator.FileTree;
using SFTP_Files_Validator.Connection;
using System.IO;

namespace SFTP_Files_Validator
{
    public partial class Form1 : Form
    {
        SftpClient connection;
        Directories root;
        Directories currentDir;
        LocalConfiguration lconf;
        string currentSelectedItem;


        public Form1()
        {
            InitializeComponent();
            connection = null;
            root = null;
            currentDir = null;
            currentSelectedItem = "";

            string confFile = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/SFTPvalidator/Configuration/MyConfiguration.xml";

            if (File.Exists(confFile))
            {
                lconf = (LocalConfiguration)Utils.Read<LocalConfiguration>(confFile);
                btnConn.Enabled = true;
            } 
            else
                lconf = null;
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            Connections conns = new Connections();
            conns.ShowDialog(this);

            if (conns.DialogResult == DialogResult.OK)
            {
                if (connection != null)
                {
                    if (connection.IsConnected)
                        connection.Disconnect();
                    lvExplorer.Clear();
                }
                connection = new SftpClient(new PasswordConnectionInfo(conns.sftpConn.host, conns.sftpConn.port, conns.sftpConn.user, conns.sftpConn.password));
                connection.Connect();

                txtSearch.Text = "/";

                InitialLoadPaths();

                // Active all components
                btnHome.Enabled = true;
                txtSearch.Enabled = true;
                btnGoBack.Enabled = true;
                btnGo.Enabled = true;
                btnReload.Enabled = true;
                btnGoHome.Enabled = true;



            }
        }

        public void LoadFilesAndDirectories()
        {
            try
            {
                lvExplorer.Clear();
                if (root != null)
                {
                    if(txtSearch.Text.Trim() == "/")
                    {
                        foreach (KeyValuePair<string, object> kvp in root.nodes)
                            if (kvp.Key != "..")
                                setIcon(kvp);
                        currentDir = root;
                    }
                    else
                    {
                        string[] dirNodes = txtSearch.Text.Trim().Split('/');
                        currentDir = root;
                        for(int i = 1; i < dirNodes.Length; i++)
                        {
                            if(!currentDir.scanned)
                                currentDir.Scan(connection, lconf.localPath);

                            if (!currentDir.nodes.ContainsKey(dirNodes[i]))
                            {
                                MessageBox.Show("Ruta no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lvExplorer.Clear();
                                break;
                            }
                            else
                            {
                                
                                if (typeof(Directories) == currentDir.nodes[dirNodes[i]].GetType())
                                    currentDir = (Directories) currentDir.nodes[dirNodes[i]];

                                if (i == dirNodes.Length - 1)
                                {
                                    if (!currentDir.scanned)
                                        currentDir.Scan(connection, lconf.localPath);
                                    foreach (KeyValuePair<string, object> kvp in currentDir.nodes)
                                        setIcon(kvp);
                                    
                                    root = GoToRoot(currentDir);

                                }
                            }

                            
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private Directories GoToRoot(Directories current)
        {
            if (current.parent.name == "/")
                return current.parent;
            return GoToRoot(current.parent);
        }


        private void lvExplorer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            currentSelectedItem = lvExplorer.SelectedItems[0].Text;
            if (typeof(Directories) == currentDir.nodes[currentSelectedItem].GetType())
            {
                if (currentSelectedItem == "..")
                {
                    txtSearch.Text = currentDir.parent.fullName;
                }
                else
                {
                    if (txtSearch.Text.EndsWith("/"))
                        txtSearch.Text += $"{currentSelectedItem}";
                    else
                        txtSearch.Text += $"/{currentSelectedItem}";
                }
                currentSelectedItem = "";
                LoadFilesAndDirectories();
            }
            else
            {
                Files fNode = (Files)currentDir.nodes[currentSelectedItem];

                string message = fNode.dowloaded 
                    ? "El archivo ya se encuentra en el disco, ¿Desea volver a descargar?"
                    : "¿Desea descargar el archivo?";

                if (MessageBox.Show(message, "Descarga", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fNode.Download(lconf.localPath, connection);
                    lvExplorer.SelectedItems[0].ImageIndex = setFileIcon(fNode);
                }
                    
            }
        }

        private void InitialLoadPaths()
        {
            root = new Directories("/", "/", null, null);
            root.Scan(connection, lconf.localPath);
            LoadFilesAndDirectories();
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadFilesAndDirectories();

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "/";
            LoadFilesAndDirectories();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            InitialLoadPaths();
        }

        private void setIcon(KeyValuePair<string, object> kvp)
        {
            if (kvp.Value.GetType() == typeof(Directories))
            {
                Directories dir = (Directories)kvp.Value;
                lvExplorer.Items.Add(kvp.Key, dir.name == ".." ? 1 : 2);
            }
            else
            {
                Files f = (Files)kvp.Value;
                int idx = 0;

                if (f.name.ToLower().EndsWith(".pdf"))
                    idx = f.dowloaded ? 7 : 3;
                else if (f.name.ToLower().EndsWith(".xls") || f.name.ToLower().EndsWith(".xlsx"))
                    idx = f.dowloaded ? 9 : 5;
                else if (f.name.ToLower().EndsWith(".txt"))
                    idx = f.dowloaded ? 8 : 4;
                else
                    idx = f.dowloaded ? 6 : 0;
                lvExplorer.Items.Add(kvp.Key, idx);
            }
        }

        private int setFileIcon(Files f)
        {
            if (f.name.ToLower().EndsWith(".pdf"))
                return f.dowloaded ? 7 : 3;
            else if (f.name.ToLower().EndsWith(".xls") || f.name.ToLower().EndsWith(".xlsx"))
                return f.dowloaded ? 9 : 5;
            else if (f.name.ToLower().EndsWith(".txt"))
                return f.dowloaded ? 8 : 4;
            return f.dowloaded ? 6 : 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string prevPath = "";
            string[] dirs = txtSearch.Text.Trim().Split('/');
            for (int i = 0; i < dirs.Length - 1; i++)
                prevPath += i == dirs.Length - 2 ? $"{dirs[i]}" : $"{dirs[i]}/";
            txtSearch.Text = prevPath;
            LoadFilesAndDirectories();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            Configurations conf;
            if (lconf != null)
                conf = new Configurations(lconf);
            else
                conf = new Configurations();
            conf.ShowDialog(this);

            if (conf.DialogResult == DialogResult.OK)
            {
                lconf = conf.lconf;
                btnConn.Enabled = true;
            }
                
        }
    }
}
