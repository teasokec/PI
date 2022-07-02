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
            this.label1 = new System.Windows.Forms.Label();
            this.prijaviButton = new System.Windows.Forms.Button();
            this.asortimanButton = new System.Windows.Forms.Button();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(132, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naruči i (s)jedi";
            // 
            // prijaviButton
            // 
            this.prijaviButton.Location = new System.Drawing.Point(113, 195);
            this.prijaviButton.Margin = new System.Windows.Forms.Padding(2);
            this.prijaviButton.Name = "prijaviButton";
            this.prijaviButton.Size = new System.Drawing.Size(101, 60);
            this.prijaviButton.TabIndex = 1;
            this.prijaviButton.Text = "PRIJAVA";
            this.prijaviButton.UseVisualStyleBackColor = true;
            this.prijaviButton.Click += new System.EventHandler(this.prijaviButton_Click);
            // 
            // asortimanButton
            // 
            this.asortimanButton.Location = new System.Drawing.Point(383, 195);
            this.asortimanButton.Margin = new System.Windows.Forms.Padding(2);
            this.asortimanButton.Name = "asortimanButton";
            this.asortimanButton.Size = new System.Drawing.Size(104, 60);
            this.asortimanButton.TabIndex = 2;
            this.asortimanButton.Text = "PREGLED ASORTIMANA";
            this.asortimanButton.UseVisualStyleBackColor = true;
            this.asortimanButton.Click += new System.EventHandler(this.asortimanButton_Click);
            // 
            // registracijaButton
            // 
            this.registracijaButton.Location = new System.Drawing.Point(250, 195);
            this.registracijaButton.Margin = new System.Windows.Forms.Padding(2);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(101, 60);
            this.registracijaButton.TabIndex = 3;
            this.registracijaButton.Text = "REGISTRACIJA";
            this.registracijaButton.UseVisualStyleBackColor = true;
            this.registracijaButton.Click += new System.EventHandler(this.registracijaButton_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.asortimanButton);
            this.Controls.Add(this.prijaviButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PocetnaForma";
            this.Text = "Glavni Izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prijaviButton;
        private System.Windows.Forms.Button asortimanButton;
        private System.Windows.Forms.Button registracijaButton;
    }
}

