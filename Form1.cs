﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }
        private void button1_Click(object sender, EventArgs e){
            button1.Text = "Wtf, stop pushin` me!";
        }
        private void button2_Click(object sender, EventArgs e){
            button2.Text = "Wtf, stop pushin` me!";
        }
        private void button3_Click(object sender, EventArgs e){
            button3.Text = "Wtf, stop pushin` me!";
        }
    }
}
