<<<<<<< HEAD:Software/NaruciISjedi/NaruciISjedi/IzradaIzvjescaForma.Designer.cs
﻿namespace NaruciISjedi
{
    partial class IzradaIzvjescaForma
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
            this.vratiAsortimanButton = new System.Windows.Forms.Button();
            this.prikaziIzvjesceButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.periodGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.periodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vratiAsortimanButton
            // 
            this.vratiAsortimanButton.Location = new System.Drawing.Point(12, 262);
            this.vratiAsortimanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vratiAsortimanButton.Name = "vratiAsortimanButton";
            this.vratiAsortimanButton.Size = new System.Drawing.Size(171, 50);
            this.vratiAsortimanButton.TabIndex = 7;
            this.vratiAsortimanButton.Text = "Vrati se na pregled asortimana";
            this.vratiAsortimanButton.UseVisualStyleBackColor = true;
            this.vratiAsortimanButton.Click += new System.EventHandler(this.vratiAsortimanButton_Click);
            // 
            // prikaziIzvjesceButton
            // 
            this.prikaziIzvjesceButton.Location = new System.Drawing.Point(684, 137);
            this.prikaziIzvjesceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prikaziIzvjesceButton.Name = "prikaziIzvjesceButton";
            this.prikaziIzvjesceButton.Size = new System.Drawing.Size(112, 50);
            this.prikaziIzvjesceButton.TabIndex = 5;
            this.prikaziIzvjesceButton.Text = "Prikaži izvješće";
            this.prikaziIzvjesceButton.UseVisualStyleBackColor = true;
            this.prikaziIzvjesceButton.Click += new System.EventHandler(this.prikaziIzvjesceButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Tjedno";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 20);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Mjesečno";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 149);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 20);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Godišnje";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 123);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 20);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "Kvartalno";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 20);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Dan";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Upišite od kojeg datuma: ";
            // 
            // datumTextBox
            // 
            this.datumTextBox.Location = new System.Drawing.Point(664, 27);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(100, 22);
            this.datumTextBox.TabIndex = 19;
            // 
            // periodGroupBox
            // 
            this.periodGroupBox.Controls.Add(this.checkBox2);
            this.periodGroupBox.Controls.Add(this.checkBox5);
            this.periodGroupBox.Controls.Add(this.checkBox4);
            this.periodGroupBox.Controls.Add(this.checkBox3);
            this.periodGroupBox.Controls.Add(this.checkBox1);
            this.periodGroupBox.Location = new System.Drawing.Point(476, 51);
            this.periodGroupBox.Name = "periodGroupBox";
            this.periodGroupBox.Size = new System.Drawing.Size(156, 185);
            this.periodGroupBox.TabIndex = 20;
            this.periodGroupBox.TabStop = false;
            this.periodGroupBox.Text = "Vremenski period";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 224);
            this.dataGridView1.TabIndex = 31;
            // 
            // IzradaIzvjescaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(833, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.periodGroupBox);
            this.Controls.Add(this.datumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vratiAsortimanButton);
            this.Controls.Add(this.prikaziIzvjesceButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IzradaIzvjescaForma";
            this.Text = "IzradaIzvjescaForma";
            this.Load += new System.EventHandler(this.IzradaIzvjescaForma_Load);
            this.periodGroupBox.ResumeLayout(false);
            this.periodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vratiAsortimanButton;
        private System.Windows.Forms.Button prikaziIzvjesceButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.GroupBox periodGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
=======
﻿namespace NaruciISjedi
{
    partial class IzradaIzvjescaForma
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
            this.vratiAsortimanButton = new System.Windows.Forms.Button();
            this.prikaziIzvjesceButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.periodGroupBox = new System.Windows.Forms.GroupBox();
            this.periodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vratiAsortimanButton
            // 
            this.vratiAsortimanButton.Location = new System.Drawing.Point(20, 379);
            this.vratiAsortimanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vratiAsortimanButton.Name = "vratiAsortimanButton";
            this.vratiAsortimanButton.Size = new System.Drawing.Size(171, 50);
            this.vratiAsortimanButton.TabIndex = 7;
            this.vratiAsortimanButton.Text = "Vrati se na pregled asortimana";
            this.vratiAsortimanButton.UseVisualStyleBackColor = true;
            this.vratiAsortimanButton.Click += new System.EventHandler(this.vratiAsortimanButton_Click);
            // 
            // prikaziIzvjesceButton
            // 
            this.prikaziIzvjesceButton.Location = new System.Drawing.Point(423, 379);
            this.prikaziIzvjesceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prikaziIzvjesceButton.Name = "prikaziIzvjesceButton";
            this.prikaziIzvjesceButton.Size = new System.Drawing.Size(112, 50);
            this.prikaziIzvjesceButton.TabIndex = 5;
            this.prikaziIzvjesceButton.Text = "Prikaži izvješće";
            this.prikaziIzvjesceButton.UseVisualStyleBackColor = true;
            this.prikaziIzvjesceButton.Click += new System.EventHandler(this.prikaziIzvjesceButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Tjedno";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 20);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Mjesečno";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 168);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(83, 20);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Godišnje";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 125);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 20);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "Kvartalno";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 20);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Dan";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Upišite od kojeg datuma: ";
            // 
            // datumTextBox
            // 
            this.datumTextBox.Location = new System.Drawing.Point(403, 42);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(100, 22);
            this.datumTextBox.TabIndex = 19;
            // 
            // periodGroupBox
            // 
            this.periodGroupBox.Controls.Add(this.checkBox2);
            this.periodGroupBox.Controls.Add(this.checkBox5);
            this.periodGroupBox.Controls.Add(this.checkBox4);
            this.periodGroupBox.Controls.Add(this.checkBox3);
            this.periodGroupBox.Controls.Add(this.checkBox1);
            this.periodGroupBox.Location = new System.Drawing.Point(13, 25);
            this.periodGroupBox.Name = "periodGroupBox";
            this.periodGroupBox.Size = new System.Drawing.Size(156, 228);
            this.periodGroupBox.TabIndex = 20;
            this.periodGroupBox.TabStop = false;
            this.periodGroupBox.Text = "Vremenski period";
            // 
            // IzradaIzvjescaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.periodGroupBox);
            this.Controls.Add(this.datumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vratiAsortimanButton);
            this.Controls.Add(this.prikaziIzvjesceButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IzradaIzvjescaForma";
            this.Text = "IzradaIzvjescaForma";
            this.Load += new System.EventHandler(this.IzradaIzvjescaForma_Load);
            this.periodGroupBox.ResumeLayout(false);
            this.periodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vratiAsortimanButton;
        private System.Windows.Forms.Button prikaziIzvjesceButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.GroupBox periodGroupBox;
    }
>>>>>>> d3e06f60736f549431e354586ba48dd44d5938f2:Software/NaručiISjedi/NaruciISjedi/IzradaIzvjescaForma.Designer.cs
}