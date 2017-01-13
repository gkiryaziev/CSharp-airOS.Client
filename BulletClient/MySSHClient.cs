using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace BulletClient
{
    class MySSHClient
    {
        private SshClient client = null;

        public bool Open(string host, int port, string login, string password)
        {
            if (client == null)
                client = new SshClient(host, port, login, password);

            if (!client.IsConnected)
                client.Connect();

            if (client.IsConnected)
                return true;
            else
                return false;
        }

        public void Close()
        {
            if (client != null && client.IsConnected)
                client.Disconnect();
        }

        public string Command(string command)
        {
            if (client != null && client.IsConnected)
                return client.RunCommand(command).Result;
            else
                return "";
        }
    }
}
