﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a= Convert.ToInt16(textBox1.Text);
            int b= Convert.ToInt16(textBox2.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox3.Text = Convert.ToString(a+b);
                    break;
                case 1:
                    textBox3.Text = Convert.ToString(a-b);
                    break;
                case 2:
                    textBox3.Text = Convert.ToString(a*b);
                    break;
                case 3:
                    textBox3.Text = Convert.ToString(a/b);
                    break;
            }
        }
    }
}
