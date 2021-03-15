using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LvanaScope.Forms
{
    public partial class FrmRFIDUtils : Form
    {
        public FrmRFIDUtils()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            MainForm.main.SendPacket($"RFID {textBox1.Text}");
        }
    }
}
