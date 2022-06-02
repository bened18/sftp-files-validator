using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFTP_Files_Validator.Connection;
using System.IO;

namespace SFTP_Files_Validator
{
    public partial class Connections : Form
    {
        public SftpConnection sftpConn;
        Dictionary<string, SftpConnection> connDict;
        public Connections()
        {
            InitializeComponent();
            sftpConn = null;
            connDict = new Dictionary<string, SftpConnection>();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(!Utils.ValidarFormulario(panel1, errorProvider1))
            {
                sftpConn = new SftpConnection(txtHost.Text, Convert.ToInt32(txtPort.Text), txtUser.Text, txtPass.Text);
                if (chbSave.Checked)
                    Utils.Save(
                        sftpConn,
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/SFTPvalidator/SavedConnection",
                        $"{txtHost.Text}@{txtUser.Text}".Trim().Replace(' ', '_')
                    );
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Connections_Load(object sender, EventArgs e)
        {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/SFTPvalidator/SavedConnection";
            if (Directory.Exists(path))
            {
                foreach (string file in Directory.EnumerateFiles(path, "*@*.xml"))
                {
                    SftpConnection sft = (SftpConnection)Utils.Read<SftpConnection>(file);
                    connDict.Add($"{sft.host}@{sft.user}", sft);
                    lvConnections.Items.Add($"{sft.host}@{sft.user}", 0);
                }
            }
            
        }

        private void lvConnections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string currentSelectedItem = lvConnections.SelectedItems[0].Text;
            sftpConn = connDict[currentSelectedItem];
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
