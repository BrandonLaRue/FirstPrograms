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
            webBrowser1.Navigate(textBox1.Text);    //makes the web browser go to the url
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)   //when url changes
        {
            textBox1.Text = webBrowser1.Url.ToString(); //change url in textbox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();   //back
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();        //foreward
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();      //refreshes
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();   //goes to IE homepage
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Visible == false && textBox2.Text == "7272")
            {
                webBrowser1.Visible = true;
                textBox2.Text = "";
            }
            else if (webBrowser1.Visible == true)
                webBrowser1.Visible = false;

            textBox1.Text = "";
        }
    }
}
