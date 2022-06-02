using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace SFTP_Files_Validator.FileTree
{
    class Node
    {
        public string name;
        public string fullName;
        public SftpFile sftpFile;

        public Node(string name, string fullName, SftpFile sftpFile)
        {
            this.name = name;
            this.fullName = fullName;
            this.sftpFile = sftpFile;
        }

    }
}
