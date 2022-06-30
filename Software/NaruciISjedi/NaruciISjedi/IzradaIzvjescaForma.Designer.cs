namespace NaruciISjedi
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
            this.datumMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.prikaziIzvjesceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vratiAsortimanButton
            // 
            this.vratiAsortimanButton.Location = new System.Drawing.Point(20, 379);
            this.vratiAsortimanButton.Name = "vratiAsortimanButton";
            this.vratiAsortimanButton.Size = new System.Drawing.Size(170, 51);
            this.vratiAsortimanButton.TabIndex = 7;
            this.vratiAsortimanButton.Text = "Vrati se na pregled asortimana";
            this.vratiAsortimanButton.UseVisualStyleBackColor = true;
            // 
            // datumMonthCalendar
            // 
            this.datumMonthCalendar.Location = new System.Drawing.Point(20, 21);
            this.datumMonthCalendar.Name = "datumMonthCalendar";
            this.datumMonthCalendar.TabIndex = 6;
            // 
            // prikaziIzvjesceButton
            // 
            this.prikaziIzvjesceButton.Location = new System.Drawing.Point(423, 379);
            this.prikaziIzvjesceButton.Name = "prikaziIzvjesceButton";
            this.prikaziIzvjesceButton.Size = new System.Drawing.Size(112, 51);
            this.prikaziIzvjesceButton.TabIndex = 5;
            this.prikaziIzvjesceButton.Text = "Prikaži izvješće";
            this.prikaziIzvjesceButton.UseVisualStyleBackColor = true;
            // 
            // IzradaIzvjescaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources.cookies_dessert_sweet_dessert_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.vratiAsortimanButton);
            this.Controls.Add(this.datumMonthCalendar);
            this.Controls.Add(this.prikaziIzvjesceButton);
            this.Name = "IzradaIzvjescaForma";
            this.Text = "IzradaIzvjescaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vratiAsortimanButton;
        private System.Windows.Forms.MonthCalendar datumMonthCalendar;
        private System.Windows.Forms.Button prikaziIzvjesceButton;
    }
}