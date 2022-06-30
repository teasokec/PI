namespace NaruciISjedi
{
    partial class IspisIzvjescaForma
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
            this.ispisiSlikovnoButton = new System.Windows.Forms.Button();
            this.ispisiIzvjesceButton = new System.Windows.Forms.Button();
            this.kreirajGrafButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vratiAsortimanButton
            // 
            this.vratiAsortimanButton.Location = new System.Drawing.Point(405, 200);
            this.vratiAsortimanButton.Name = "vratiAsortimanButton";
            this.vratiAsortimanButton.Size = new System.Drawing.Size(170, 51);
            this.vratiAsortimanButton.TabIndex = 8;
            this.vratiAsortimanButton.Text = "Vrati se na pregled asortimana";
            this.vratiAsortimanButton.UseVisualStyleBackColor = true;
            // 
            // ispisiSlikovnoButton
            // 
            this.ispisiSlikovnoButton.Location = new System.Drawing.Point(225, 200);
            this.ispisiSlikovnoButton.Name = "ispisiSlikovnoButton";
            this.ispisiSlikovnoButton.Size = new System.Drawing.Size(112, 51);
            this.ispisiSlikovnoButton.TabIndex = 7;
            this.ispisiSlikovnoButton.Text = "Ispiši slikovni prikaz";
            this.ispisiSlikovnoButton.UseVisualStyleBackColor = true;
            // 
            // ispisiIzvjesceButton
            // 
            this.ispisiIzvjesceButton.Location = new System.Drawing.Point(601, 200);
            this.ispisiIzvjesceButton.Name = "ispisiIzvjesceButton";
            this.ispisiIzvjesceButton.Size = new System.Drawing.Size(112, 51);
            this.ispisiIzvjesceButton.TabIndex = 6;
            this.ispisiIzvjesceButton.Text = "Ispiši izvješće";
            this.ispisiIzvjesceButton.UseVisualStyleBackColor = true;
            // 
            // kreirajGrafButton
            // 
            this.kreirajGrafButton.Location = new System.Drawing.Point(12, 200);
            this.kreirajGrafButton.Name = "kreirajGrafButton";
            this.kreirajGrafButton.Size = new System.Drawing.Size(112, 51);
            this.kreirajGrafButton.TabIndex = 5;
            this.kreirajGrafButton.Text = "Kreiraj slikovni prikaz";
            this.kreirajGrafButton.UseVisualStyleBackColor = true;
            // 
            // IspisIzvjescaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources.cookies_dessert_sweet_dessert_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.vratiAsortimanButton);
            this.Controls.Add(this.ispisiSlikovnoButton);
            this.Controls.Add(this.ispisiIzvjesceButton);
            this.Controls.Add(this.kreirajGrafButton);
            this.Name = "IspisIzvjescaForma";
            this.Text = "IspisIzvjescaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vratiAsortimanButton;
        private System.Windows.Forms.Button ispisiSlikovnoButton;
        private System.Windows.Forms.Button ispisiIzvjesceButton;
        private System.Windows.Forms.Button kreirajGrafButton;
    }
}