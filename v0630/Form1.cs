using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int [] vx = new int[3];
        int [] vy = new int[3];

        static Random rand = new Random(); 

        public Form1()
        {
            InitializeComponent();

            vx[0] = rand.Next(-20, 20);
            vy[0] = rand.Next(-20, 20);
            vx[1] = rand.Next(-20, 20);
            vy[1] = rand.Next(-20, 20);
            vx[2] = rand.Next(-20, 20);
            vy[2] = rand.Next(-20, 20);

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label2.Left = rand.Next(ClientSize.Width - label1.Width);
            label2.Top = rand.Next(ClientSize.Height - label1.Height);
            label3.Left = rand.Next(ClientSize.Width - label1.Width);
            label3.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]) * 110 / 100;
            }
            if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]) * 110 / 100;
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]) * 110 / 100;
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]) * 110 / 100;
            }

            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]) * 110 / 100;
            }
            if (label2.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]) * 110 / 100;
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]) * 110 / 100;
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]) * 110 / 100;
            }

            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]) * 110 / 100;
            }
            if (label3.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]) * 110 / 100;
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]) * 110 / 100;
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]) * 110 / 100;
            }

            label1.Left += vx[0];
            label1.Top += vy[0];
            label2.Left += vx[1];
            label2.Top += vy[1];
            label3.Left += vx[2];
            label3.Top += vy[2];

            Point mp = PointToClient(MousePosition);

            if ((mp.X >= label1.Left)
                && (mp.X < label1.Right)
                && (mp.Y >= label1.Top)
                && (mp.Y < label1.Bottom)
                )
            {
                timer1.Enabled = false;
            }

            if ((mp.X >= label2.Left)
                && (mp.X < label2.Right)
                && (mp.Y >= label2.Top)
                && (mp.Y < label2.Bottom)
                )
            {
                timer1.Enabled = false;
            }

            if ((mp.X >= label3.Left)
                && (mp.X < label3.Right)
                && (mp.Y >= label3.Top)
                && (mp.Y < label3.Bottom)
                )
            {
                timer1.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
