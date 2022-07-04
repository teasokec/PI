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
            this.kreirajIzvjesceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
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
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(14, 10);
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
            // AsortimanForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.kosaricaButton);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.kreirajIzvjesceButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AsortimanForma";
            this.Text = "AsortimanForma";
            this.Load += new System.EventHandler(this.AsortimanForma_Load);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
>>>>>>> f2e04d4b240743016ef30c8d20dc7c49ec710f8e
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kosaricaButton;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button kreirajIzvjesceButton;
    }
}