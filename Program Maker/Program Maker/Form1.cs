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
  
        string writing;
        int wn = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a Text FIle";
            ofd.Filter = "Text File | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                writing = sr.ReadToEnd();
                sr.Dispose();

                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
                
                richTextBox1.Text += "Workout " + wn++ + ":";
                richTextBox1.Font = new Font(richTextBox1.Font, richTextBox1.Font.Style | FontStyle.Regular);
                //change back to regular?
                richTextBox1.Text += System.Environment.NewLine + writing + System.Environment.NewLine;
                richTextBox1.Text += System.Environment.NewLine;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );

                richTextBox1.Focus();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            wn = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Microsoft Word File |*.doc";
            sfd.Title = "Choose a Location To Save";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;

                StreamWriter bw = new StreamWriter(File.Create(path));
                bw.Write(richTextBox1.Text);
                bw.Dispose();
            }
        }
          
    }
}
