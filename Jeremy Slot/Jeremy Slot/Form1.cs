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


        public int en = 10;
        Random d = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
         int a=1;
         int b=1;
         int c=1;
         if(en >= 10)
         {
             a = d.Next(10);
             b = d.Next(10);
             c = d.Next(10);

             label1.Text = a.ToString();
             label2.Text = b.ToString();
             label3.Text = c.ToString();
         
         }
         

         

            if(a==b && b==c)
            {
                MessageBox.Show("Hello! Congratulations!");
            }

        
           

        }
    }
}
