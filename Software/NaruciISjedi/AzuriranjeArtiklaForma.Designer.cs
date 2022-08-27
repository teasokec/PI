namespace NaruciISjedi
{
    partial class AzuriranjeArtiklaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.sastojciRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.slikaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.vrstaComboBox = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sastojci:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena proizvoda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrsta proizvoda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Slika:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(167, 34);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(152, 20);
            this.nazivTextBox.TabIndex = 5;
            // 
            // sastojciRichTextBox
            // 
            this.sastojciRichTextBox.Location = new System.Drawing.Point(167, 73);
            this.sastojciRichTextBox.Name = "sastojciRichTextBox";
            this.sastojciRichTextBox.Size = new System.Drawing.Size(152, 96);
            this.sastojciRichTextBox.TabIndex = 6;
            this.sastojciRichTextBox.Text = "";
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.Location = new System.Drawing.Point(167, 193);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(152, 20);
            this.cijenaTextBox.TabIndex = 7;
            // 
            // slikaRichTextBox
            // 
            this.slikaRichTextBox.Location = new System.Drawing.Point(167, 228);
            this.slikaRichTextBox.Name = "slikaRichTextBox";
            this.slikaRichTextBox.Size = new System.Drawing.Size(152, 96);
            this.slikaRichTextBox.TabIndex = 8;
            this.slikaRichTextBox.Text = "";
            // 
            // vrstaComboBox
            // 
            this.vrstaComboBox.FormattingEnabled = true;
            this.vrstaComboBox.Location = new System.Drawing.Point(167, 338);
            this.vrstaComboBox.Name = "vrstaComboBox";
            this.vrstaComboBox.Size = new System.Drawing.Size(152, 21);
            this.vrstaComboBox.TabIndex = 9;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(102, 417);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(204, 417);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // AzuriranjeArtiklaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(389, 486);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.vrstaComboBox);
            this.Controls.Add(this.slikaRichTextBox);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(this.sastojciRichTextBox);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AzuriranjeArtiklaForma";
            this.Text = "Ažuriranje artikla";
            this.Load += new System.EventHandler(this.AzuriranjeArtiklaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.RichTextBox sastojciRichTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.RichTextBox slikaRichTextBox;
        private System.Windows.Forms.ComboBox vrstaComboBox;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}