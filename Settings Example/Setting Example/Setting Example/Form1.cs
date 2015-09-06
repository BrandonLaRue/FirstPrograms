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
        public Form1()  //when we open this will run
        {
            InitializeComponent();
            textBox1.Text = WindowsFormsApplication1.Properties.Settings.Default.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //http://www.youtube.com/watch_popup?v=1-aPZWXYVbo&vq=medium    see how to make setting

            WindowsFormsApplication1.Properties.Settings.Default.Name = textBox1.Text;  //assignes setting we made
            WindowsFormsApplication1.Properties.Settings.Default.Save();    //saves all assigned properties
        }
    }
}
