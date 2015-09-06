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

        //List view and Context menu strip : aka right click

        //to see how to set up list view watch below vid
        //http://www.youtube.com/watch_popup?v=powg_2OlmiE&vq=medium
        private void button1_Click(object sender, EventArgs e)
        {
            //below is not the item we made on the form, but a way to store the data it needs
            ListViewItem lvi = new ListViewItem(textBox1.Text); //1st colum
            lvi.SubItems.Add(textBox2.Text);                    //2nd colum
            lvi.SubItems.Add(textBox3.Text);                    //3rd colum

            listView1.Items.Add(lvi);           //adding what we determined above to the actual listview
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


        //in the form we set up a context menu just like a button and double clicked
        // to assign it to the list view we went to the ContextMenuStrip property and selected this one
        //http://www.youtube.com/watch_popup?v=rQ3w23TlKvg&vq=medium

        private void getNameOfItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text); //selected items[0] is when selecting one item (the first)
                //subitems[0] means the colum selected (name / age / date)
                //text is a property of it


                //below video http://www.youtube.com/watch_popup?v=YNjGrM7kwMM&vq=medium
                foreach (ListViewItem lvi in listView1.SelectedItems)   //loops through all items selected in list wiew
                {
                    MessageBox.Show(lvi.SubItems[0].Text);  //to get the age change index to 1 and for email do 2
                }

            }
        }


        //http://www.youtube.com/watch_popup?v=FQ_gnTm7zaA&vq=medium
        private void removeSelectedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                foreach (ListViewItem lvi in listView1.SelectedItems)
                {
                    lvi.Remove();   //removes selected items
                }
            }
        }

        //http://www.youtube.com/watch_popup?v=FQ_gnTm7zaA&vq=medium
        private void removeAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();    //removes all items
        }

        //http://www.youtube.com/watch_popup?v=FQ_gnTm7zaA&vq=medium
        private void removeCheckedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.Items)
                if (lvi.Checked) lvi.Remove();  //if the item is checked, remove it
        }
    }
}
