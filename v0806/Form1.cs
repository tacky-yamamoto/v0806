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
        int vx = -2;
        int vy = -2;
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
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left<0)
            {
                if (vx < 0)
                {
                    vx *= -1;
                }
            }
            if (label1.Top < 0)
            {
                if (vy < 0)
                {
                    vy *= -1;
                }
            }
            if (label1.Right > ClientSize.Width)
            {
                if (vx > 0)
                {
                    vx *= -1;
                }
            }
            if (label1.Bottom > ClientSize.Height)
            {
                if (vy > 0)
                {
                    vy *= -1;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
            //MessageBox.Show("高さ" + ClientSize.Height);
        }
    }
}
