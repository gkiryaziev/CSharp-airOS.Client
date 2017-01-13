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
            string result = _client.Command("mca-status | grep signal");
            if (result != "")
            {
                return Convert.ToInt32(result.TrimEnd('\r', '\n').Split('=')[1]);
            }
            return -100;
        }

        //---------------------------
        // Get AP MAC
        //---------------------------

        //---------------------------
        // Get Base Station SSID
        //---------------------------

        //---------------------------
        // Get Frequency
        //---------------------------

        //---------------------------
        // Get Noise Floor
        //---------------------------

        //---------------------------
        // Get Transmit CCQ
        //---------------------------

        //---------------------------
        // Get Uptime
        //---------------------------

        //---------------------------
        // Get ACK Timeout
        //---------------------------

        //---------------------------
        // Get WLAN IP Address
        //---------------------------

        //---------------------------
        // Get TX Rate
        //---------------------------

        //---------------------------
        // Get RX Rate
        //---------------------------

        //---------------------------
        // Get Channel
        //---------------------------
    }
}
