namespace NaruciISjedi
{
    partial class RegistracijaForm
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
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbKontakt = new System.Windows.Forms.TextBox();
            this.tbKorIme = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(265, 43);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(121, 21);
            this.cmbUloga.TabIndex = 32;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(265, 319);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(121, 20);
            this.tbLozinka.TabIndex = 31;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(265, 135);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(121, 20);
            this.tbPrezime.TabIndex = 30;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(265, 177);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(121, 20);
            this.tbAdresa.TabIndex = 29;
            // 
            // tbKontakt
            // 
            this.tbKontakt.Location = new System.Drawing.Point(265, 227);
            this.tbKontakt.Name = "tbKontakt";
            this.tbKontakt.Size = new System.Drawing.Size(121, 20);
            this.tbKontakt.TabIndex = 28;
            // 
            // tbKorIme
            // 
            this.tbKorIme.Location = new System.Drawing.Point(265, 271);
            this.tbKorIme.Name = "tbKorIme";
            this.tbKorIme.Size = new System.Drawing.Size(121, 20);
            this.tbKorIme.TabIndex = 27;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(265, 96);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(121, 20);
            this.tbIme.TabIndex = 26;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(265, 361);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(97, 47);
            this.btnOdustani.TabIndex = 25;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegistriraj.Location = new System.Drawing.Point(133, 361);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(97, 47);
            this.btnRegistriraj.TabIndex = 24;
            this.btnRegistriraj.Text = "Registriraj korisnika";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(71, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Korisničko ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(71, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lozinka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(71, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(71, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(70, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kontakt:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(71, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ime:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(70, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Uloga:";
            // 
            // RegistracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(483, 460);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbKontakt);
            this.Controls.Add(this.tbKorIme);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnRegistriraj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "RegistracijaForm";
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbKontakt;
        private System.Windows.Forms.TextBox tbKorIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}