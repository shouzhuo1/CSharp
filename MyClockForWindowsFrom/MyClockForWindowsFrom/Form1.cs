﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyClockForWindowsFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
