using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LvanaScope
{
    public partial class GraphePanel : UserControl
    {
        public static int ADC_BUFFER_SIZE = 1024;
        public static int ADC_MAX_VALUE = 256;

        public int ADC_Frequence = 10000000;

        public float xAsixScale = 1.0f;
        public float yAsixScale = 1.0f;
        public float xAxisPos = 0.0f;
        public float yAxisPos = 0.0f;

        public int GapX = 20;
        public int GapY = 20;
        public byte[] SignalBuffer = null;
        public int GridWidth { get { return this.Width - 2 * GapX; } }
        public int GridHeight { get { return this.Height - 2 * GapY; } }
        public Font GridFont = new Font("Arial", 20);

        public PointF ptDown = new PointF();
        public PointF ptPrev = new PointF();
        public GraphePanel()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.UserPaint |
                            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                            true);
            InitializeComponent();
            this.MouseWheel += GraphePanel_MouseWheel;
        }


        private void GraphePanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, 0, 0, this.Width, this.Height);
            DrawAxis(e.Graphics);
            DrawWaveForm(e.Graphics);
            DrawInformation(e.Graphics);
        }
        private  void DrawInformation(Graphics g)
        {
            string s = Utility.FrequenceString(ADC_Frequence);
            g.DrawString(s, GridFont, Brushes.White, new Point(30, 30));
        }

        private void DrawAxis(Graphics g)
        {
            Pen penRed = new Pen(Color.Red, 1);
            Pen penGreen = new Pen(Color.FromArgb(100, 0, 255, 0), 0.5f);
            
            Point ptCenter = new Point(GridWidth / 2 + GapX, GridHeight / 2 + GapY);
            float unitX = ADC_BUFFER_SIZE / 10.0f;
            float unitY = ADC_MAX_VALUE / 10.0f;
            float xScale = GridWidth / (float)ADC_BUFFER_SIZE;
            float yScale = GridHeight / (float)ADC_MAX_VALUE;
            float px, py;
            for (float i = 0; i <= ADC_BUFFER_SIZE; i += unitX)
            {
                px = i * xScale;
                g.DrawLine(penGreen, GapX + px, GapY, GapX + px, GapY + GridHeight);
            }
            for(float i = 0; i <= ADC_MAX_VALUE; i += unitY)
            {
                py = i * yScale;
                g.DrawLine(penGreen, GapX, GapY + py, GapX + GridWidth, GapY + py);
            }
            g.DrawRectangle(penGreen, GapX, GapY, GridWidth, GridHeight);
            g.DrawLine(penRed, GapX, GapY + GridHeight / 2, GapX + GridWidth, GapY + GridHeight/ 2);
            g.DrawLine(penRed, GapX + GridWidth / 2, GapY, GapX + GridWidth / 2, GapY + GridHeight);
        }

        void DrawWaveForm(Graphics g)
        {
            Pen penGreen = new Pen(Color.Green, 0.5f);
            PointF ptPrev = new PointF();
            PointF pt = new PointF();

            if (SignalBuffer == null) return;

            int wid, high;
            wid = this.Width - GapX * 2;
            high = this.Height - GapY * 2;

            float xscale = wid / (float)ADC_BUFFER_SIZE;
            float yscale = high / (float)ADC_MAX_VALUE;
            for (int i = 0; i < ADC_BUFFER_SIZE; i ++)
            {
                if (i >= SignalBuffer.Length) break;
                pt.X = xscale * i * xAsixScale + GapX + xAxisPos;
                
                pt.Y = high - SignalBuffer[i+3] * yscale + GapY;
                if (i > 0 && pt.X >= GapX && pt.X <= GapX + GridWidth)
                {
                    g.DrawLine(penGreen, ptPrev, pt);
                }
                ptPrev = pt;
            }
        }
        public void RefreshPanel()
        {
            this.Invalidate();
        }

        public void CopyBuffer(byte[] bytes)
        {
            SignalBuffer = bytes.ToArray();
            this.Invalidate();
        }

        private void GraphePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ptDown.X = e.X;
            ptDown.Y = e.Y;
        }

        private void GraphePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                float diffx = e.X - ptDown.X;
                float rate = (GridWidth / (float)ADC_MAX_VALUE) / xAsixScale;
                diffx /= rate;
                xAxisPos += diffx;
                //if (xAxisPos > 0) xAxisPos = 0;
                ptDown.X = e.X;
                Invalidate();
            }
        }

        private void GraphePanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void GraphePanel_MouseWheel(object sender, MouseEventArgs e)
        {
            float step = 0.02f;
            if(Control.ModifierKeys == Keys.Shift)
            {
                step = 0.1f;
            }
            if(e.Delta < 0)
            {
                step *= -1;
            }
            if (xAsixScale + step < 1f) xAsixScale = 1f;
            else xAsixScale += step;
            Invalidate();
        }
    }
}
