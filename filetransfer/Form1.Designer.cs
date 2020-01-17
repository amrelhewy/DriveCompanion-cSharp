namespace filetransfer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.forward = new System.Windows.Forms.Button();
            this.backward = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateCreatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(801, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 212);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(577, 177);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(435, 212);
            this.listBox2.TabIndex = 3;
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // forward
            // 
            this.forward.Enabled = false;
            this.forward.Location = new System.Drawing.Point(474, 247);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(73, 46);
            this.forward.TabIndex = 4;
            this.forward.Text = ">>";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.MouseClick += new System.Windows.Forms.MouseEventHandler(this.forward_MouseClick);
            // 
            // backward
            // 
            this.backward.Enabled = false;
            this.backward.Location = new System.Drawing.Point(474, 299);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(75, 46);
            this.backward.TabIndex = 5;
            this.backward.Text = "<<";
            this.backward.UseVisualStyleBackColor = true;
            this.backward.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backward_MouseClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(372, 412);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 6;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.delete_MouseClick);
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(577, 412);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(75, 23);
            this.copy.TabIndex = 7;
            this.copy.Text = "Copy";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.copy_MouseClick);
            // 
            // root
            // 
            this.root.Location = new System.Drawing.Point(12, 412);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(75, 23);
            this.root.TabIndex = 8;
            this.root.Text = "...";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(109, 412);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = ".";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // move
            // 
            this.move.Location = new System.Drawing.Point(474, 412);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(75, 23);
            this.move.TabIndex = 10;
            this.move.Text = "Move";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.HighlightText;
            this.search.Location = new System.Drawing.Point(58, 80);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(300, 22);
            this.search.TabIndex = 12;
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateCreatedToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 52);
            // 
            // dateCreatedToolStripMenuItem
            // 
            this.dateCreatedToolStripMenuItem.Name = "dateCreatedToolStripMenuItem";
            this.dateCreatedToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.dateCreatedToolStripMenuItem.Text = "Date Created";
            this.dateCreatedToolStripMenuItem.Click += new System.EventHandler(this.dateCreatedToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "DRIVE COMPANION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.move);
            this.Controls.Add(this.back);
            this.Controls.Add(this.root);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.backward);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button backward;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateCreatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

