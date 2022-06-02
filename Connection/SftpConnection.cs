using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;

namespace SFTP_Files_Validator.Connection
{
    public class SftpConnection
    {
        public string host;
        public int port;
        public string user;
        public string password;

        public SftpConnection(){}

        public SftpConnection(string host, int port, string user, string password )
        {
            this.host = host;
            this.port = port;
            this.user = user;
            this.password = password;
        }
    }
}
