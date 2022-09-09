using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPortNotifier
{
    public partial class FormMain : Form
    {
        private Dictionary<string,DetectedSerialPort> _ports;

        public FormMain()
        {
            InitializeComponent();
            _ports = new Dictionary<string, DetectedSerialPort>();
            timerMonitor.Enabled = true;
        }

        private void timerMonitor_Tick(object sender, EventArgs e)
        {
            /*foreach (var p in _ports)
                p.Value.Connected = false;*/

            var updateList = false;
            var s = SerialPort.GetPortNames();

            foreach (var p in _ports) // Check for the disconnected ones
                if (!s.Contains(p.Key))
                    if (p.Value.Connected)
                    {
                        p.Value.Connected = false;
                        updateList = true;
                    }

            foreach (var p in s) // Check for new ports to add
            {
                if (!_ports.ContainsKey(p))
                {
                    _ports.Add(p, new DetectedSerialPort());
                    updateList = true;
                }
                else
                {
                    if (!_ports[p].Connected)
                    {
                        _ports[p].Timestamp = DateTime.Now;
                        _ports[p].Connected = true;
                        updateList = true;
                    }
                }
            }

            //if (updateList)
            var selected = listBoxCOMPorts.SelectedIndex;
            labelWaiting.Visible = false;
            listBoxCOMPorts.Visible = true;
            listBoxCOMPorts.Items.Clear();

            foreach (var p in _ports)
                listBoxCOMPorts.Items.Insert(0, DetectedSerialPort.ToString(p));
            listBoxCOMPorts.SelectedIndex = selected == -1? 0: selected;
        }
    }

    internal class DetectedSerialPort
    {
        public DateTime Timestamp { get; set; }
        public bool Connected { get; set; }

        public DetectedSerialPort()
        {
            this.Timestamp = DateTime.Now;
            this.Connected = true;
        }

        public new String ToString()
        {
            return "\tConnected: " + (this.Connected ? "YES" : "NO") + "\tLast activity: " + DetectedSerialPort.FriendlyTimestamp(Timestamp);
        }

        private static string FriendlyTimestamp(DateTime timestamp)
        {
            var t = DateTime.Now.Subtract(timestamp);

            if (t.TotalMinutes >= 60)
                return timestamp.ToString();
            else
                if (t.TotalMinutes < 1)
            {
                return t.TotalSeconds > 5 ? "less than a minute ago": "just now";
            }
            else
                return Math.Floor(t.TotalMinutes) + " minutes ago";
        }

        internal static object ToString(KeyValuePair<string, DetectedSerialPort> p)
        {
            return p.Key + p.Value.ToString();
        }
    }
}
