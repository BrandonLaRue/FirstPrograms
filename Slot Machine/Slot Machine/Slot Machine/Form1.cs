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

        public int num1;
        public int num2;
        public int num3;
        public int money = 30;
        Random rand = new Random();
        

        private void button1_Click(object sender, EventArgs e)
        {

            if (money >= 3)
            {
                money = money - 3;

                num1 = rand.Next(10);
                num2 = rand.Next(10);
                num3 = rand.Next(10);

                label1.Text = num1.ToString();
                label2.Text = num2.ToString();
                label3.Text = num3.ToString();
                label5.Text = money.ToString();

                if (num1 == num2 || num2 == num3 || num1 == num3)
                {
                    money = money + 6;
                    label5.Text = money.ToString();
                    MessageBox.Show("You win a small prize");                 
                }
                else if (num1 == num2 && num2 == num3)
                {
                    money = money + 12;
                    label5.Text = money.ToString();
                    MessageBox.Show("You got the jackpot!");                   
                }
            }
            else
            {
                MessageBox.Show("You do not have enough money.");
            }    
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = money.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0603021849")
            {
                money = money + 30;
                textBox1.Text = "";
                label5.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Error");
                textBox1.Text = "";
            }
        }
    }
}
