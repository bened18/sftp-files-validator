using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFTP_Files_Validator
{
    public class LocalConfiguration
    {
        public string localPath { get; set; }

        public LocalConfiguration() { }

        public LocalConfiguration(string localPath)
        {
            this.localPath = localPath;
        }
    }
}
