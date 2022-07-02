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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kreirajIzvjesceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kosaricaButton
            // 
            this.kosaricaButton.Location = new System.Drawing.Point(502, 308);
            this.kosaricaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kosaricaButton.Name = "kosaricaButton";
            this.kosaricaButton.Size = new System.Drawing.Size(84, 41);
            this.kosaricaButton.TabIndex = 5;
            this.kosaricaButton.Text = "Košarica";
            this.kosaricaButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 273);
            this.dataGridView1.TabIndex = 4;
            // 
            // kreirajIzvjesceButton
            // 
            this.kreirajIzvjesceButton.Location = new System.Drawing.Point(14, 308);
            this.kreirajIzvjesceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kreirajIzvjesceButton.Name = "kreirajIzvjesceButton";
            this.kreirajIzvjesceButton.Size = new System.Drawing.Size(84, 41);
            this.kreirajIzvjesceButton.TabIndex = 3;
            this.kreirajIzvjesceButton.Text = "Kreiraj izvješće";
            this.kreirajIzvjesceButton.UseVisualStyleBackColor = true;
            // 
            // AsortimanForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.kosaricaButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kreirajIzvjesceButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AsortimanForma";
            this.Text = "AsortimanForma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kosaricaButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kreirajIzvjesceButton;
    }
}