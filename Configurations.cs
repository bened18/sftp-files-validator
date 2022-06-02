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
    public partial class Configurations : Form
    {
        public LocalConfiguration lconf;
        public Configurations()
        {
            InitializeComponent();
        }

        public Configurations(LocalConfiguration lconf)
        {
            InitializeComponent();
            this.lconf = lconf;
            txtLocalPath.Text = this.lconf.localPath;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (fbdLocalPath.ShowDialog() == DialogResult.OK)
            {
                txtLocalPath.Text = fbdLocalPath.SelectedPath;
                lconf = new LocalConfiguration(fbdLocalPath.SelectedPath);
            }
                
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Utils.ValidarFormulario(this, errorProvider1))
            {
                if (Directory.Exists(txtLocalPath.Text))
                {
                    string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/SFTPvalidator/Configuration";
                    Utils.Save(lconf, path, "MyConfiguration");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show("La ruta especificada no existe");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
