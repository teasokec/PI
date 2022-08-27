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
            this.components = new System.ComponentModel.Container();
            this.kosaricaButton = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.kreirajIzvjesceButton = new System.Windows.Forms.Button();
            this.btnArtikl = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOdjava = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kosaricaButton
            // 
            this.kosaricaButton.Location = new System.Drawing.Point(502, 308);
            this.kosaricaButton.Margin = new System.Windows.Forms.Padding(2);
            this.kosaricaButton.Name = "kosaricaButton";
            this.kosaricaButton.Size = new System.Drawing.Size(84, 41);
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
            this.dgvProizvodi.Location = new System.Drawing.Point(9, 9);
            this.dgvProizvodi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(573, 273);
            this.dgvProizvodi.TabIndex = 4;
            // 
            // kreirajIzvjesceButton
            // 
            this.kreirajIzvjesceButton.Location = new System.Drawing.Point(14, 308);
            this.kreirajIzvjesceButton.Margin = new System.Windows.Forms.Padding(2);
            this.kreirajIzvjesceButton.Name = "kreirajIzvjesceButton";
            this.kreirajIzvjesceButton.Size = new System.Drawing.Size(84, 41);
            this.kreirajIzvjesceButton.TabIndex = 3;
            this.kreirajIzvjesceButton.Text = "Kreiraj izvješće";
            this.kreirajIzvjesceButton.UseVisualStyleBackColor = true;
            this.kreirajIzvjesceButton.Click += new System.EventHandler(this.kreirajIzvjesceButton_Click);
            // 
            // btnArtikl
            // 
            this.btnArtikl.Location = new System.Drawing.Point(103, 308);
            this.btnArtikl.Name = "btnArtikl";
            this.btnArtikl.Size = new System.Drawing.Size(78, 41);
            this.btnArtikl.TabIndex = 6;
            this.btnArtikl.Text = "Detalji o artiklu";
            this.btnArtikl.UseVisualStyleBackColor = true;
            this.btnArtikl.Click += new System.EventHandler(this.btnArtikl_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(187, 308);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 41);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj novi proizvod";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(NaruciISjedi.Product);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(NaruciISjedi.User);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(NaruciISjedi.Type);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(NaruciISjedi.Order);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(422, 308);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 41);
            this.btnOdjava.TabIndex = 8;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // AsortimanForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnArtikl);
            this.Controls.Add(this.kosaricaButton);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.kreirajIzvjesceButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AsortimanForma";
            this.Text = "AsortimanForma";
            this.Load += new System.EventHandler(this.AsortimanForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kosaricaButton;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button kreirajIzvjesceButton;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button btnArtikl;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdjava;
    }
}