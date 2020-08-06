using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        float vx = -1;
        float vy = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mp = MousePosition;
            mp = PointToClient(mp);
            label2.Text = "" + mp.X + "," + mp.Y;
            label2.Left = mp.X - label2.Width / 2;
            label2.Top = mp.Y - label2.Height / 2;

            label1.Left += (int)vx;
            label1.Top += (int)vy;
            if (label1.Left < 0)
            {
                vx *= 1.1f;
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy *= 1.1f;
                vy = Math.Abs(vy);
            }
            if (label1.Left+label1.Width > ClientSize.Width)
            {
                vx *= 1.1f;
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy *= 1.1f;
                vy = -Math.Abs(vy);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
            //MessageBox.Show("高さ" + ClientSize.Height);
        }
    }
}
