﻿using System;
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
        int vx = -5, vy = -10;

        public Form1()
        {
            InitializeComponent();
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
                vx = Math.Abs(vx) * 110 / 100;
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 110 / 100;
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * 110 / 100;
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 110 / 100;
            }

            label1.Left += vx;
            label1.Top += vy;

            Point spos = MousePosition;


            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            label1.Left += vx;
            label1.Top += vy; ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
