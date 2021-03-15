using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using Timer = System.Threading.Timer;
using LvanaScope.Forms;

namespace LvanaScope
{
    public enum DataMode { Text, Hex }
    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };
    public partial class MainForm : Form
    {
        public int[] BaudRate = new int[] { 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 };
        private Color[] LogMsgTypeColor = { Color.Yellow, Color.Green, Color.White, Color.Orange, Color.Red };

        public static MainForm main;
        private SerialPort serialPort = new SerialPort();

        public RFID RfidMoudle = new RFID();
        private int AdcFrequence = 0;
        bool IsPlayStop = false;
        bool IsConnected = false;        
        public MainForm()
        {
            main = this;
            InitializeComponent();
            UpdateComToolMenu();
            timer1.Enabled = true;
            timer1.Start();
            int index = 0;
            foreach (var rate in BaudRate)
            {
                var menu = new ToolStripMenuItem();
                menu.Text = rate.ToString(); ;
                menu.Name = "BaudSubMenu_" + index;
                menu.Click += new EventHandler(BaudRateMenuItemClickHandler);
                BaudRateToolStripMenuItem.DropDownItems.Add(menu);
                index++;
            }
        }
        
        private void SerialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void UpdateComToolMenu()
        {
            ComToolStripMenuItem.DropDownItems.Clear();
            
            string[] ports = SerialPort.GetPortNames();
            int index = 0;
            foreach (var port in ports)
            {
                var menu = new ToolStripMenuItem();
                menu.Text = port;
                menu.Name = "ComSubMenu_" + index;
                menu.Click += new EventHandler(ComMenuItemClickHandler);
                ComToolStripMenuItem.DropDownItems.Add(menu);
                index++;
            }
        }
        private void ComMenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            ComToolStripMenuItem.Text = menu.Text;
        }
        private void BaudRateMenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            BaudRateToolStripMenuItem.Text = menu.Text;
        }

     
        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                int BaudRate = 9600;
                if (!int.TryParse(BaudRateToolStripMenuItem.Text, out BaudRate))
                {
                    MessageBox.Show("Please select the Baud Rate");
                    return;
                }
                string portnum = ComToolStripMenuItem.Text.Substring(3);
                if (!int.TryParse(BaudRateToolStripMenuItem.Text, out BaudRate))
                {
                    MessageBox.Show("Please select the Com Port.");
                    return;
                }
                bool error = false;
                try
                {
                    serialPort.BaudRate = BaudRate;
                    serialPort.Parity = Parity.None;
                    serialPort.PortName = ComToolStripMenuItem.Text;
                    serialPort.DataBits = 8;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Handshake = Handshake.None;
                    serialPort.Open();
                    IsConnected = true;
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error == false)
                {
                    ConnectToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.connect_on_48x48;                    
                    serialPort.DataReceived += serialPort_DataReceived;
                    SendPacket("M777 Connect");
                }
                else
                {
                    MessageBox.Show("Can't Connect this port.");                    
                    ConnectToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.connect_off_48x48;
                }
                

            }else
            {
                CloseSerialPort();
                if(!serialPort.IsOpen)
                {
                    ConnectToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.connect_off_48x48;
                }else
                    ConnectToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.connect_on_48x48;
            }
        }

        private void ComToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            UpdateComToolMenu();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;
            string text = textSend.Text;
            if (RdoSendModeHex.Checked)
            {
                byte[] bytes = Utility.StringToByteArray(text);
                serialPort.Write(bytes, 0, bytes.Length);
            }else
            {   
                serialPort.Write(text);
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort.IsOpen) return;
            int bytes = serialPort.BytesToRead;
            byte[] buffer = new byte[bytes];
            serialPort.Read(buffer, 0, bytes);
            if(bytes > 40)
            {
                if(buffer[0] == 'A' && buffer[1] == 'D' &&  buffer[2] == 'C')
                {
                    graphePanel1.CopyBuffer(buffer);
                    if(!IsPlayStop)
                    {
                        changePlayStopStatus(true);
                    }
                }else if(buffer[0] == 'R' && buffer[1] == 'F' && buffer[2] == 'I' && buffer[3] == 'D')
                {
                    RfidMoudle.ParsePacket(buffer);
                }
                //Log(LogMsgType.Incoming, $"Received {bytes} Bytes\n");
            }
            else
            {
                string text = Encoding.ASCII.GetString(buffer);
                if (bytes == 0) return;
                if(text.StartsWith("M777_STATUS_VCP_IDLE"))
                {
                    string[] item = text.Split(' ');
                    if(item.Length == 2)
                    {
                        graphePanel1.ADC_Frequence = int.Parse(item[1]);
                    }
                    changePlayStopStatus(false);
                    Log(LogMsgType.Incoming, text);
                }
                else if(text.StartsWith("M777_STATUS_VCP_BUSY")) 
                {
                    string[] item = text.Split(' ');
                    if (item.Length == 2)
                    {
                        graphePanel1.ADC_Frequence = int.Parse(item[1]);
                    }
                    changePlayStopStatus(true);
                    Log(LogMsgType.Incoming, text);
                }                
            }
        }

        public void Log(LogMsgType msgtype, string msg)
        {
            richTextReceive.Invoke(new EventHandler(delegate
            {
                richTextReceive.SelectedText = string.Empty;
                richTextReceive.SelectionFont = new Font(richTextReceive.SelectionFont, FontStyle.Bold);
                richTextReceive.SelectionColor = LogMsgTypeColor[(int)msgtype];
                richTextReceive.AppendText(msg + "\n");
                richTextReceive.ScrollToCaret();
            }));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextReceive.Text = "";
        }

        private void SampleRateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PlayStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!IsPlayStop)
                SendPacket("M777 RequestSignal");
            else
                SendPacket("M777 NoRequestSignal");
        }
        public void changePlayStopStatus(bool bPlay)
        {
            if(!bPlay)
            {
                PlayStopToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.play_48x48;
                PlayStopToolStripMenuItem.Text = "Play";
            }
            else
            {
                PlayStopToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.stop_48x48;
                PlayStopToolStripMenuItem.Text = "Stop";
            }
            IsPlayStop = bPlay;
        }

        private void toolStripMenuItemSampleRate_Click(object sender, EventArgs e)
        {   
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            string item = menu.Text;

            SampleRateToolStripMenuItem.Text = menu.Text;
            switch (item)
            {
                case "1Hz":
                    SendPacket("M777 F1");
                    graphePanel1.ADC_Frequence = 1;
                    break;
                case "10Hz":
                    SendPacket("M777 F10");
                    graphePanel1.ADC_Frequence = 10;
                    break;
                case "100Hz":
                    SendPacket("M777 F100");
                    graphePanel1.ADC_Frequence = 100;
                    break;
                case "1KHz":
                    SendPacket("M777 F1K");
                    graphePanel1.ADC_Frequence = 1000;
                    break;
                case "10KHz":
                    SendPacket("M777 F10K");
                    graphePanel1.ADC_Frequence = 10000;
                    break;
                case "100KHz":
                    SendPacket("M777 F100K");
                    graphePanel1.ADC_Frequence = 100000;
                    break;
                case "1MHz":
                    SendPacket("M777 F1M");
                    graphePanel1.ADC_Frequence = 1000000;
                    break;
                case "10MHz":
                    SendPacket("M777 F10M");
                    graphePanel1.ADC_Frequence = 10000000;
                    break;
            }
        }

        public void CloseSerialPort()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.DataReceived -= serialPort_DataReceived;
                SendPacket("M777 NoRequestSignal");
                Thread.Sleep(100);
                while (!(serialPort.BytesToRead == 0 && serialPort.BytesToWrite == 0))
                {
                    serialPort.DiscardInBuffer();
                    serialPort.DiscardOutBuffer();
                }                
                try
                {
                    serialPort.Close();
                    IsConnected = false;
                }
                catch(Exception e)
                {
                    MessageBox.Show("ERROR: Can't close Serial Port");
                }
            }
        }
        public void SendPacket(string sz)
        {
            if (!serialPort.IsOpen) return;
            serialPort.Write(sz);
            Log(LogMsgType.Outgoing, sz);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!serialPort.IsOpen && IsConnected)
            {
                IsConnected = false;
                serialPort.Close();
                PlayStopToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.play_48x48;
                PlayStopToolStripMenuItem.Text = "Play";
                ConnectToolStripMenuItem.Image = global::LvanaScope.Properties.Resources.connect_off_48x48;
                MessageBox.Show("Disconnected");                
            }
        }

        private void toolStripMenuItemRFID_Click(object sender, EventArgs e)
        {
            FrmRFIDUtils dlg = new FrmRFIDUtils();
            dlg.ShowDialog();
        }
    }
}
