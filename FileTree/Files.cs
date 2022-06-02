using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace SFTP_Files_Validator.FileTree
{
    class Files: Node
    {
        public bool dowloaded;
        public float size;
        public Directories parent;

        public Files(string name, string fullName, Directories parent, long Length, SftpFile sftpFile)
            : base(name, fullName, sftpFile)
        {
            dowloaded = false;
            size = Length / 1000000;
            this.parent = parent;
        }

        public bool ValidateFileExists(string localBasePath)
        {
            string filePath = $@"{localBasePath}\{fullName}".Replace("/", @"\");
            dowloaded = File.Exists(filePath);
            return dowloaded;
        }

        public int Download(string localBasePath, SftpClient client)
        {
            string[] paths = fullName.Split('/');
            string currentPath = localBasePath;
            
            for(int i = 1; i < paths.Length; i++)
            {
                if(i == paths.Length - 1)
                {
                    try
                    {
                        using (Stream file = File.Create($@"{currentPath}\{name}"))
                            client.DownloadFile(fullName, file);
                        if (ValidateFileExists(localBasePath))
                            return 0;
                        return 1;
                    }
                    catch
                    {
                        return 1;
                    }
                    
                }
                else
                {
                    currentPath = $@"{currentPath}\{paths[i]}";
                    if (!Directory.Exists(currentPath))
                        Directory.CreateDirectory(currentPath);
                }
            }
            return 2;
        }
 
        
    }
}
