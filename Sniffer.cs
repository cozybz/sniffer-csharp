using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpPcap.WinPcap;
using SharpPcap;
using PacketDotNet;
using System.IO;

namespace Sniffer
{
    public partial class Sniffer : Form
    {
        private WinPcapDeviceList devs;
        private WinPcapDevice dev;
        private PacketArrivalEventHandler packetArrivalHandler;
        private int totalPacketNum;
        private int totalPacketLength;
        private List<String> datas;
        public Sniffer()
        {
            InitializeComponent();
            datas = new List<String>();
            devs =  WinPcapDeviceList.Instance;
            packetArrivalHandler = new PacketArrivalEventHandler(deviceOnPacketArrival);
            if (devs.Count > 0) {
                foreach (WinPcapDevice d in devs)
                {
                    d.Open();
                    chooseComboBox.Items.Add("MAC:" + d.MacAddress + " " + d.Description);
                    d.Close();
                } 
            }
            startButton.Enabled = false;
            stopButton.Enabled = false;
            startToolStrip.Enabled = false;
            stopToolStrip.Enabled = false;
        }

        private void chooseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseComboBox.SelectedIndex > -1)
            {
                startButton.Enabled = true;
                startToolStrip.Enabled = true;
                dev = devs[chooseComboBox.SelectedIndex];
            }
        }

        private void deviceOnPacketArrival(object sender, CaptureEventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke(new PacketArrivalEventHandler(packetArrival), sender, e);
            else
                packetArrival(sender, e);
        }

        private void packetArrival(object sender, CaptureEventArgs e)
        {
            
            Packet p = Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            IpPacket ip = IpPacket.GetEncapsulated(p);
            TcpPacket tp = TcpPacket.GetEncapsulated(p);
            UdpPacket up = UdpPacket.GetEncapsulated(p);
            if(ip!=null)
                if (tp != null)
                {
                    listView.Items.Add(new ListViewItem(new String[] { e.Packet.Timeval.Date.Year + "/" + e.Packet.Timeval.Date.Month + "/" + e.Packet.Timeval.Date.Day + " " + (e.Packet.Timeval.Date.Hour + 8) + ":" + e.Packet.Timeval.Date.Minute + ":" + e.Packet.Timeval.Date.Second + ":" + e.Packet.Timeval.Date.Millisecond, "TCP", ip.SourceAddress.ToString() + ":" + tp.SourcePort.ToString(), ip.DestinationAddress.ToString() + ":" + tp.DestinationPort.ToString(), e.Packet.Data.Length.ToString() }));
                    datas.Add(BitConverter.ToString(e.Packet.Data));
                }
                else if (up != null)
                {
                    listView.Items.Add(new ListViewItem(new String[] { e.Packet.Timeval.Date.Year + "/" + e.Packet.Timeval.Date.Month + "/" + e.Packet.Timeval.Date.Day + " " + (e.Packet.Timeval.Date.Hour + 8) + ":" + e.Packet.Timeval.Date.Minute + ":" + e.Packet.Timeval.Date.Second + ":" + e.Packet.Timeval.Date.Millisecond, "UDP", ip.SourceAddress.ToString() + ":" + up.SourcePort.ToString(), ip.DestinationAddress.ToString() + ":" + up.DestinationPort.ToString(), e.Packet.Data.Length.ToString() }));
                    datas.Add(BitConverter.ToString(e.Packet.Data));
                }
            totalPacketLength += e.Packet.Data.Length;
            totalPacketNum++;
            statusLabel.Text = "共收到" + totalPacketNum + "个数据包，总长度" + totalPacketLength;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void startToolStrip_Click(object sender, EventArgs e)
        {
            start();
        }

        private void stopToolStrip_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void clearToolStrip_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView.HitTest(e.X, e.Y);
            Detail detail = new Detail();
            detail.textBox.Text = datas[info.Item.Index];
            detail.ShowDialog();
        }

        private void start() 
        {
            chooseComboBox.Enabled = false;
            startButton.Enabled = false;
            startToolStrip.Enabled = false;
            stopButton.Enabled = true;
            stopToolStrip.Enabled = true;
            dev.OnPacketArrival += packetArrivalHandler;
            dev.Open(DeviceMode.Promiscuous, 1000);
            dev.StartCapture();
            statusLabel.Text = "共收到0个数据包，总长度0";
        }
        private void stop() 
        {
            chooseComboBox.Enabled = true;
            stopButton.Enabled = false;
            stopToolStrip.Enabled = false;
            startButton.Enabled = true;
            startToolStrip.Enabled = true;
            dev.OnPacketArrival -= packetArrivalHandler;
            try
            {
                if (dev.Started)
                    dev.StopCapture();
                if (dev.Opened)
                    dev.Close();
            }
            catch (PcapException) { 
            
            }
        }
        private void clear() 
        {
            listView.Items.Clear();
            datas.Clear();
            totalPacketLength = 0;
            totalPacketNum = 0;
            statusLabel.Text = "共收到" + totalPacketNum + "个数据包，总长度" + totalPacketLength;
        }

        private void aboutToolStrip_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void saveToolStrip_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.GetEncoding("GBK"));
                for (int i = 0; i < listView.Items.Count;i++ )
                    sWriter.WriteLine(listView.Items[i].SubItems[0].Text+" "+listView.Items[i].SubItems[1].Text+" "+listView.Items[i].SubItems[2].Text+" "+listView.Items[i].SubItems[3].Text+" "+listView.Items[i].SubItems[4].Text);

                sWriter.Flush();
                sWriter.Close();
                fs.Close();
            }
        }

        private void Sniffer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (dev != null) {
                    if (dev.Started)
                        dev.StopCapture();
                    if (dev.Opened)
                        dev.Close();
                }
            }
            catch (PcapException){}
        }
    }
}
