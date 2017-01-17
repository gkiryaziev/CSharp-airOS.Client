using System;

namespace ConfigManager
{
    [Serializable]
    class ConfigModel
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public byte[] Login { get; set; }
        public byte[] Password { get; set; }
        public int Interval { get; set; }
    }
}
