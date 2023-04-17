namespace TrainingPractice_03
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.handbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handbookToolStripMenuItem,
            this.fuelToolStripMenuItem,
            this.учётToolStripMenuItem,
            this.контактыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // handbookToolStripMenuItem
            // 
            this.handbookToolStripMenuItem.Name = "handbookToolStripMenuItem";
            this.handbookToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.handbookToolStripMenuItem.Text = "Handbook";
            this.handbookToolStripMenuItem.Click += new System.EventHandler(this.handbookToolStripMenuItem_Click);
            // 
            // fuelToolStripMenuItem
            // 
            this.fuelToolStripMenuItem.Name = "fuelToolStripMenuItem";
            this.fuelToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fuelToolStripMenuItem.Text = "Fuel";
            this.fuelToolStripMenuItem.Click += new System.EventHandler(this.fuelToolStripMenuItem_Click);
            // 
            // учётToolStripMenuItem
            // 
            this.учётToolStripMenuItem.Name = "учётToolStripMenuItem";
            this.учётToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.учётToolStripMenuItem.Text = "Accounting";
            this.учётToolStripMenuItem.Click += new System.EventHandler(this.accountingToolStripMenuItem_Click);
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.контактыToolStripMenuItem.Text = "Contacts";
            this.контактыToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainingPractice_03.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(25, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This program in itself implements a database management system for stored fuel, a" +
    "nd the amount of fuel sold.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GasStation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem handbookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

