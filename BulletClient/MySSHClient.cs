using Renci.SshNet;

namespace BulletClient
{
    class MySSHClient
    {
        private SshClient client = null;
        private SshCommand cmd = null;

        public bool Open(string host, int port, string login, string password)
        {
            if (client == null || !client.IsConnected)
            {
                client = new SshClient(host, port, login, password);
                client.Connect();
                if (client.IsConnected)
                {
                    cmd = client.CreateCommand("pwd");
                }
            }

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
                return cmd.Execute(command);
            else
                return "";
        }
    }
}
