﻿namespace NaruciISjedi
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kosaricaButton
            // 
            this.kosaricaButton.Location = new System.Drawing.Point(669, 379);
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
            this.dgvProizvodi.Location = new System.Drawing.Point(12, 11);
            this.dgvProizvodi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(764, 336);
            this.dgvProizvodi.TabIndex = 4;
            // 
            // kreirajIzvjesceButton
            // 
            this.kreirajIzvjesceButton.Location = new System.Drawing.Point(19, 379);
            this.kreirajIzvjesceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kreirajIzvjesceButton.Name = "kreirajIzvjesceButton";
            this.kreirajIzvjesceButton.Size = new System.Drawing.Size(112, 50);
            this.kreirajIzvjesceButton.TabIndex = 3;
            this.kreirajIzvjesceButton.Text = "Kreiraj izvješće";
            this.kreirajIzvjesceButton.UseVisualStyleBackColor = true;
            this.kreirajIzvjesceButton.Click += new System.EventHandler(this.kreirajIzvjesceButton_Click);
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
            // AsortimanForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kosaricaButton);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.kreirajIzvjesceButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}