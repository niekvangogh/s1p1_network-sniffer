using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace network_sniffer
{
    public partial class Form_Sniffer : Form
    {
        public Form_Sniffer()
        {
            InitializeComponent();
        }

        private void InitSniffer()
        {
            var packetDevice = this.GetNetworkDevice();
            var communicator = packetDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000);

            new Thread(() => this.Listen(communicator)).Start();
            button_start.Enabled = false;
        }

        public void Listen(PacketCommunicator communicator)
        {
            do
            {
                var result = communicator.ReceivePacket(out var packet);
                if (result == PacketCommunicatorReceiveResult.Ok)
                {
                    Datagram datagram = null;

                    IpV4Datagram ip4 = packet.Ethernet.IpV4;
                    if (ip4.Protocol == IpV4Protocol.Udp)
                    {
                        var udp = ip4.Udp;
                        datagram = udp.Payload;
                    }

                    if (ip4.Protocol == IpV4Protocol.Tcp)
                    {
                        var tcp = ip4.Tcp;
                        datagram = tcp.Payload;
                    }

                    string payload = this.ReadPayload(datagram);
                    this.AddToLog(payload);
                }
            } while (true);
        }

        private void AddToLog(string payload)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(AddToLog), new object[] {payload});
                return;
            }

            this.textbox_messages.AppendText(payload + "\n");
        }

        private LivePacketDevice GetNetworkDevice()
        {
            IList<LivePacketDevice> devices = LivePacketDevice.AllLocalMachine;

            if (devices.Count == 0)
            {
                MessageBox.Show("No interfaces found");
            }

            return devices[devices.Count - 2]; //gets the active connector thing
        }

        private string ReadPayload(Datagram datagram)
        {
            if (null != datagram)
            {
                int payloadLength = datagram.Length;
                using (var ms = datagram.ToMemoryStream())
                {
                    byte[] rx_payload = new byte[payloadLength];
                    ms.Read(rx_payload, 0, payloadLength);
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    return encoder.GetString(rx_payload);
                }
            }

            return null;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            InitSniffer();
        }
    }
}