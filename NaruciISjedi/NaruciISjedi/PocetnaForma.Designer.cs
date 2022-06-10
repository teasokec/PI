namespace NaruciISjedi
{
    partial class PocetnaForma
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.Location = new System.Drawing.Point(157, 134);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(179, 51);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Font = new System.Drawing.Font("MS Gothic", 15.75F);
            this.btnRegistracija.Location = new System.Drawing.Point(157, 218);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(179, 50);
            this.btnRegistracija.TabIndex = 1;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naruči i (s)jedi";
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(505, 343);
            this.pbBackground.TabIndex = 2;
            this.pbBackground.TabStop = false;
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.pbBackground);
            this.Name = "PocetnaForma";
            this.Text = "Dobrodošli";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label label1;
    }
}

