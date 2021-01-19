using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvanaScope
{
    class Utility
    {
        public static byte[] StringToByteArray(string hex)
        {
            hex = hex.Replace(" ", "");

            byte[] buffer = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(hex.Substring(i, 2), 16);
            return buffer;
        }
        public static string ByteArrayToString(byte[] bytes)
        {
            
            string text;
            text = BitConverter.ToString(bytes);
            foreach (var b in bytes)
            {
                
            }
            return text;
        }

        public static string FrequenceString(int freq)
        {
            string s;
            if (freq < 1000) s = $"{freq}Hz";
            else if (freq < 1000000) s = $"{freq / 1000}KHz";
            else s = $"{freq / 1000000}MHz";
            return s;
        }
    }
}
