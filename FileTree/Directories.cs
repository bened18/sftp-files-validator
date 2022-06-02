using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace SFTP_Files_Validator.FileTree
{
    class Directories: Node
    {
        public Dictionary<string, object> nodes;
        public Directories parent;
        public bool scanned;

        public Directories(string name, string fullName, Directories parent, SftpFile sftpFile)
            : base(name, fullName, sftpFile)
        {
            nodes = new Dictionary<string, object>();
            this.parent = parent;
            scanned = false;
        }

        public void Scan(SftpClient client, string localBasePath)
        {
            IEnumerable<SftpFile> nodes = client.ListDirectory(fullName);
            foreach (SftpFile node in nodes)
            {
                if (node.Name != ".")
                {
                    if (node.IsDirectory)
                    {
                        Directories dir = new Directories(node.Name, node.FullName, this, node);
                        this.nodes.Add(node.Name, dir);
                    }
                    else
                    {
                        Files file = new Files(node.Name, node.FullName, this, node.Length, node);
                        file.ValidateFileExists(localBasePath);
                        this.nodes.Add(node.Name, file);

                    }
                }
                
            }
            scanned = true;
        }
    }
}
