﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaCo
{
    public partial class Form1 : Form
    {
        int startpoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.startpoint += 2;
            bunifuCircleProgress1.Value = this.startpoint;
            if (bunifuCircleProgress1.Value == 100)
            {
                bunifuCircleProgress1.Value = 0;
                timer1.Stop();
                Login l = new Login();
                this.Hide();
                l.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
