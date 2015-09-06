using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            int per_pound = 15;
            int dragon = Convert.ToInt32(textBox2.Text);
            int bought = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("You spent " + (per_pound * bought).ToString());

            if (bought == dragon)
            {
                MessageBox.Show("You bought enough orphan meat!");
            }
            else if (bought == dragon / 2)
            {
                MessageBox.Show("You are half way there!");
            }
            else
            {
                MessageBox.Show("You need " + (dragon / bought).ToString() + " times more meat.");
            }
        }
    }
}



