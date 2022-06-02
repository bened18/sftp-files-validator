using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFTP_Files_Validator.Components
{
    public partial class ErrorTextBox : TextBox
    {
        public bool Validate { get; set; }
        public bool OnlyNumbers { get; set; }
        public ErrorTextBox()
        {
            InitializeComponent();
        }

    }
}
