namespace NaruciISjedi
{
    partial class DodavanjeArtiklaForma
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.vrstaComboBox = new System.Windows.Forms.ComboBox();
            this.slikaRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.sastojciRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(205, 407);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(103, 407);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // vrstaComboBox
            // 
            this.vrstaComboBox.FormattingEnabled = true;
            this.vrstaComboBox.Location = new System.Drawing.Point(168, 328);
            this.vrstaComboBox.Name = "vrstaComboBox";
            this.vrstaComboBox.Size = new System.Drawing.Size(152, 21);
            this.vrstaComboBox.TabIndex = 21;
            // 
            // slikaRichTextBox
            // 
            this.slikaRichTextBox.Location = new System.Drawing.Point(168, 218);
            this.slikaRichTextBox.Name = "slikaRichTextBox";
            this.slikaRichTextBox.Size = new System.Drawing.Size(152, 96);
            this.slikaRichTextBox.TabIndex = 20;
            this.slikaRichTextBox.Text = "";
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.Location = new System.Drawing.Point(168, 183);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(152, 20);
            this.cijenaTextBox.TabIndex = 19;
            // 
            // sastojciRichTextBox
            // 
            this.sastojciRichTextBox.Location = new System.Drawing.Point(168, 63);
            this.sastojciRichTextBox.Name = "sastojciRichTextBox";
            this.sastojciRichTextBox.Size = new System.Drawing.Size(152, 96);
            this.sastojciRichTextBox.TabIndex = 18;
            this.sastojciRichTextBox.Text = "";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(168, 24);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(152, 20);
            this.nazivTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Slika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Vrsta proizvoda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cijena proizvoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sastojci:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv:";
            // 
            // DodavanjeArtiklaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(434, 450);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "DodavanjeArtiklaForma";
            this.Text = "DodavanjeArtiklaForma";
            this.Load += new System.EventHandler(this.DodavanjeArtiklaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox vrstaComboBox;
        private System.Windows.Forms.RichTextBox slikaRichTextBox;
        private System.Windows.Forms.TextBox cijenaTextBox;
        private System.Windows.Forms.RichTextBox sastojciRichTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}