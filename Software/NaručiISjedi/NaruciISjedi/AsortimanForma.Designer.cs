namespace NaruciISjedi
{
    partial class AsortimanForma
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
            this.kosaricaButton = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.kolicina_textbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kreirajIzvjesceButton = new System.Windows.Forms.Button();
            this.btnArtikl = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.kolicnaComboBox = new System.Windows.Forms.ComboBox();
            this.kolicinaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // kosaricaButton
            // 
            this.kosaricaButton.Location = new System.Drawing.Point(551, 399);
            this.kosaricaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kosaricaButton.Name = "kosaricaButton";
            this.kosaricaButton.Size = new System.Drawing.Size(112, 50);
            this.kosaricaButton.TabIndex = 5;
            this.kosaricaButton.Text = "Košarica";
            this.kosaricaButton.UseVisualStyleBackColor = true;
            this.kosaricaButton.Click += new System.EventHandler(this.kosaricaButton_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kolicina_textbox});
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 11);
            this.dgvProizvodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(651, 362);
            this.dgvProizvodi.TabIndex = 4;
            // 
            // kolicina_textbox
            // 
            this.kolicina_textbox.HeaderText = "Količina";
            this.kolicina_textbox.MinimumWidth = 6;
            this.kolicina_textbox.Name = "kolicina_textbox";
            this.kolicina_textbox.Width = 125;
            // 
            // kreirajIzvjesceButton
            // 
            this.kreirajIzvjesceButton.Location = new System.Drawing.Point(123, 379);
            this.kreirajIzvjesceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kreirajIzvjesceButton.Name = "kreirajIzvjesceButton";
            this.kreirajIzvjesceButton.Size = new System.Drawing.Size(112, 50);
            this.kreirajIzvjesceButton.TabIndex = 3;
            this.kreirajIzvjesceButton.Text = "Kreiraj izvješće";
            this.kreirajIzvjesceButton.UseVisualStyleBackColor = true;
            this.kreirajIzvjesceButton.Click += new System.EventHandler(this.kreirajIzvjesceButton_Click);
            // 
            // btnArtikl
            // 
            this.btnArtikl.Location = new System.Drawing.Point(12, 379);
            this.btnArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.btnArtikl.Name = "btnArtikl";
            this.btnArtikl.Size = new System.Drawing.Size(104, 50);
            this.btnArtikl.TabIndex = 6;
            this.btnArtikl.Text = "Detalji o artiklu";
            this.btnArtikl.UseVisualStyleBackColor = true;
            this.btnArtikl.Click += new System.EventHandler(this.btnArtikl_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(16, 437);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 50);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj novi proizvod";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(124, 435);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(100, 50);
            this.btnOdjava.TabIndex = 8;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // kolicnaComboBox
            // 
            this.kolicnaComboBox.FormattingEnabled = true;
            this.kolicnaComboBox.Location = new System.Drawing.Point(691, 51);
            this.kolicnaComboBox.Name = "kolicnaComboBox";
            this.kolicnaComboBox.Size = new System.Drawing.Size(151, 24);
            this.kolicnaComboBox.TabIndex = 9;
            // 
            // kolicinaButton
            // 
            this.kolicinaButton.Location = new System.Drawing.Point(715, 101);
            this.kolicinaButton.Name = "kolicinaButton";
            this.kolicinaButton.Size = new System.Drawing.Size(103, 45);
            this.kolicinaButton.TabIndex = 10;
            this.kolicinaButton.Text = "Upiši količinu";
            this.kolicinaButton.UseVisualStyleBackColor = true;
            this.kolicinaButton.Click += new System.EventHandler(this.kolicinaButton_Click);
            // 
            // AsortimanForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(863, 493);
            this.Controls.Add(this.kolicinaButton);
            this.Controls.Add(this.kolicnaComboBox);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnArtikl);
            this.Controls.Add(this.kosaricaButton);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.kreirajIzvjesceButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AsortimanForma";
            this.Text = "AsortimanForma";
            this.Load += new System.EventHandler(this.AsortimanForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kosaricaButton;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button kreirajIzvjesceButton;
        private System.Windows.Forms.Button btnArtikl;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.ComboBox kolicnaComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina_textbox;
        private System.Windows.Forms.Button kolicinaButton;
    }
}