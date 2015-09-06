namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getNameOfItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCheckedItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 64);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(267, 190);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Age";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 144;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getNameOfItemToolStripMenuItem,
            this.removeSelectedItemsToolStripMenuItem,
            this.removeAllItemsToolStripMenuItem,
            this.removeCheckedItemsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 114);
            // 
            // getNameOfItemToolStripMenuItem
            // 
            this.getNameOfItemToolStripMenuItem.Name = "getNameOfItemToolStripMenuItem";
            this.getNameOfItemToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.getNameOfItemToolStripMenuItem.Text = "Get Name of Item(s)";
            this.getNameOfItemToolStripMenuItem.Click += new System.EventHandler(this.getNameOfItemToolStripMenuItem_Click);
            // 
            // removeSelectedItemsToolStripMenuItem
            // 
            this.removeSelectedItemsToolStripMenuItem.Name = "removeSelectedItemsToolStripMenuItem";
            this.removeSelectedItemsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.removeSelectedItemsToolStripMenuItem.Text = "Remove Selected Item(s)";
            this.removeSelectedItemsToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedItemsToolStripMenuItem_Click);
            // 
            // removeAllItemsToolStripMenuItem
            // 
            this.removeAllItemsToolStripMenuItem.Name = "removeAllItemsToolStripMenuItem";
            this.removeAllItemsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.removeAllItemsToolStripMenuItem.Text = "Remove All Items";
            this.removeAllItemsToolStripMenuItem.Click += new System.EventHandler(this.removeAllItemsToolStripMenuItem_Click);
            // 
            // removeCheckedItemsToolStripMenuItem
            // 
            this.removeCheckedItemsToolStripMenuItem.Name = "removeCheckedItemsToolStripMenuItem";
            this.removeCheckedItemsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.removeCheckedItemsToolStripMenuItem.Text = "Remove Checked Items";
            this.removeCheckedItemsToolStripMenuItem.Click += new System.EventHandler(this.removeCheckedItemsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getNameOfItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCheckedItemsToolStripMenuItem;
    }
}

