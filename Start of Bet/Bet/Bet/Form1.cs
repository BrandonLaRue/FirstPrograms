using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            string path = "";
            string text = "";
            string[] textArray;


            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                sfd.Dispose();               
            }
            StreamWriter sw = new StreamWriter(File.Create(path));           
            sw.WriteLine(textBox1.Text + ":" + textBox4.Text + ":" + textBox2.Text + ":" + textBox3.Text + ":");
            sw.Dispose();




            StreamReader sr = new StreamReader(File.OpenRead(path));
            text = sr.ReadLine();
            textArray = text.Split(':');
        }
    }
}
