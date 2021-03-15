using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvanaScope
{
    public class RFID
    {
        public const int RFID_MARK_SIZE = 4;
        public const int RFID_BLOCK_SIZE = 16;
        public const int RFID_BLOCK_NUM = 64;
        public const int RFID_COMMAND_SIZe = 1;
        public const int RFID_HEADER_SIZE = 5;
        public const int RFID_BUF_SIZE = 1024;

        public const int RFID_COMMAND_DECTECTED = 0x80;
        public const int RFID_COMMAND_READ = 0x81;
        public const int RFID_COMMAND_WRITEN = 0x82;
        public bool ParsePacket(byte[] buf)
        {
            if (!(buf[0] == 'R' && buf[1] == 'F' && buf[2] == 'I' && buf[3] == 'D')) return false;
            switch(buf[4]) {
                case RFID_COMMAND_DECTECTED:
                    byte[] uuid = new byte[4];
                    uuid[0] = buf[0 + 5];
                    uuid[1] = buf[1 + 5];
                    uuid[2] = buf[2 + 5];
                    uuid[3] = buf[3 + 5];
                    string sz = $"RFID Detected: UID = {BitConverter.ToString(uuid)}";
                    MainForm.main.Log(LogMsgType.Incoming, sz);
                    break;
                case RFID_COMMAND_READ:
                    byte[] Rfid_Buf = new byte[RFID_BUF_SIZE];
                    Buffer.BlockCopy(buf, RFID_HEADER_SIZE, Rfid_Buf, 0, RFID_BUF_SIZE);
                    MainForm.main.Log(LogMsgType.Incoming, ToByteString(Rfid_Buf));
                    break;
                case RFID_COMMAND_WRITEN:
                    break;
            }            
            return true;
        }

        public string ToByteString(byte[] buf)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < RFID_BLOCK_NUM; i ++)
            {
                string sz = "";
                if (i % 4 == 0)
                    sz = $"{(i / 4).ToString("D2")}   {i.ToString("D2")}";
                else
                {
                    sz = $"       {i.ToString("D2")}";
                }
                byte[] bs = new byte[RFID_BLOCK_SIZE];
                Buffer.BlockCopy(buf, i * RFID_BLOCK_SIZE, bs, 0, RFID_BLOCK_SIZE);
                string hx = BitConverter.ToString(bs);
                hx = hx.Replace('-', ' ');
                sz += "      " + hx + "    ";// + Encoding.ASCII.GetString(bs);
                sb.AppendLine(sz);
            }
            return sb.ToString();
        }
    }

    
}
