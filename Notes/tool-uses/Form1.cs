﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tool_uses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "SIYAKSARES";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "MSH";
            label7.Text = "SIYAKSARES";
            label8.Text = "Software Engineer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = label4.Text;
            label9.Text = textBox1.Text;
            // Nereye yazdırılacaksa o solda, nereden yazdırılacaksa sola yazılır.
             
        }
    }
}
