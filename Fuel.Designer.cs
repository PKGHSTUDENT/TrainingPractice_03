namespace TrainingPractice_03
{
    partial class Fuel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fuelNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.providerIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addFuelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showFuelByFilterButton = new System.Windows.Forms.Button();
            this.filterPriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.moreRadioButton = new System.Windows.Forms.RadioButton();
            this.lessRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 612);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuel Name:";
            // 
            // fuelNameTextBox
            // 
            this.fuelNameTextBox.Location = new System.Drawing.Point(906, 135);
            this.fuelNameTextBox.Name = "fuelNameTextBox";
            this.fuelNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelNameTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(906, 163);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // providerIdTextBox
            // 
            this.providerIdTextBox.Location = new System.Drawing.Point(906, 190);
            this.providerIdTextBox.Name = "providerIdTextBox";
            this.providerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.providerIdTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Provader id:";
            // 
            // addFuelButton
            // 
            this.addFuelButton.Location = new System.Drawing.Point(866, 233);
            this.addFuelButton.Name = "addFuelButton";
            this.addFuelButton.Size = new System.Drawing.Size(75, 23);
            this.addFuelButton.TabIndex = 7;
            this.addFuelButton.Text = "Add";
            this.addFuelButton.UseVisualStyleBackColor = true;
            this.addFuelButton.Click += new System.EventHandler(this.addFuelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add new type of fuel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(903, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Filter";
            // 
            // showFuelByFilterButton
            // 
            this.showFuelByFilterButton.Location = new System.Drawing.Point(834, 444);
            this.showFuelByFilterButton.Name = "showFuelByFilterButton";
            this.showFuelByFilterButton.Size = new System.Drawing.Size(146, 23);
            this.showFuelByFilterButton.TabIndex = 15;
            this.showFuelByFilterButton.Text = "Show fuel by filter";
            this.showFuelByFilterButton.UseVisualStyleBackColor = true;
            this.showFuelByFilterButton.Click += new System.EventHandler(this.showFuelByFilter_Click);
            // 
            // filterPriceTextBox
            // 
            this.filterPriceTextBox.Location = new System.Drawing.Point(880, 359);
            this.filterPriceTextBox.Name = "filterPriceTextBox";
            this.filterPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.filterPriceTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(831, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price:";
            // 
            // moreRadioButton
            // 
            this.moreRadioButton.AutoSize = true;
            this.moreRadioButton.Checked = true;
            this.moreRadioButton.Location = new System.Drawing.Point(854, 401);
            this.moreRadioButton.Name = "moreRadioButton";
            this.moreRadioButton.Size = new System.Drawing.Size(49, 17);
            this.moreRadioButton.TabIndex = 17;
            this.moreRadioButton.TabStop = true;
            this.moreRadioButton.Text = "More";
            this.moreRadioButton.UseVisualStyleBackColor = true;
            // 
            // lessRadioButton
            // 
            this.lessRadioButton.AutoSize = true;
            this.lessRadioButton.Location = new System.Drawing.Point(909, 401);
            this.lessRadioButton.Name = "lessRadioButton";
            this.lessRadioButton.Size = new System.Drawing.Size(47, 17);
            this.lessRadioButton.TabIndex = 18;
            this.lessRadioButton.TabStop = true;
            this.lessRadioButton.Text = "Less";
            this.lessRadioButton.UseVisualStyleBackColor = true;
            // 
            // Fuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 636);
            this.Controls.Add(this.lessRadioButton);
            this.Controls.Add(this.moreRadioButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showFuelByFilterButton);
            this.Controls.Add(this.filterPriceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addFuelButton);
            this.Controls.Add(this.providerIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuelNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Fuel";
            this.Text = "Fuel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fuelNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox providerIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addFuelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showFuelByFilterButton;
        private System.Windows.Forms.TextBox filterPriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton moreRadioButton;
        private System.Windows.Forms.RadioButton lessRadioButton;
    }
}