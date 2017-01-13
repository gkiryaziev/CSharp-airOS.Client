using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletClient
{
    class MyUbntClient
    {
        private MySSHClient _client = null;

        //---------------------------
        // Set SSH Client
        //---------------------------
        public void SetSSHClient(MySSHClient client)
        {
            _client = client;
        }

        //---------------------------
        // Get Signal Strength
        //---------------------------
        public int GetSignal() {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep signal");
                if (result != "")
                {
                    return Convert.ToInt32(result.TrimEnd('\r', '\n').Split('=')[1]);
                }
                return -100;
            }
            return -100;
        }
        //---------------------------
        // Get Noise Floor
        //---------------------------

        //---------------------------
        // Get Transmit CCQ
        //---------------------------

        //---------------------------
        // Get Base Station SSID
        //---------------------------
        public string GetBaseSSID()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep essid");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
        //---------------------------
        // Get AP MAC
        //---------------------------
        public string GetApMAC()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep apMac");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
        //---------------------------
        // Get WLAN IP Address
        //---------------------------
        public string GetWlanIpAddress()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep wlanIpAddress");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
        //---------------------------
        // Get Frequency
        //---------------------------
        public string GetFrequency()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep freq");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
        //---------------------------
        // Get Channel
        //---------------------------

        //---------------------------
        // Get ACK Timeout
        //---------------------------
        public string GetAckTimeout()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep ackTimeout");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
        //---------------------------
        // Get TX Rate
        //---------------------------
        public string GetTxRate()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep wlanTxRate");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
        //---------------------------
        // Get RX Rate
        //---------------------------
        public string GetRxRate()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep wlanRxRate");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
        //---------------------------
        // Get Uptime
        //---------------------------
        public string GetUptime()
        {
            if (_client != null)
            {
                string result = _client.Command("mca-status | grep uptime");
                if (result != "")
                {
                    return result.TrimEnd('\r', '\n').Split('=')[1];
                }
                return "";
            }
            return "";
        }
    }
}
