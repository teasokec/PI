namespace NaruciISjedi
{
    partial class KosaricaForma
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
            this.potvrdaNarudzbeButton = new System.Windows.Forms.Button();
            this.vratiAsortimanButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.kosaricaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // potvrdaNarudzbeButton
            // 
            this.potvrdaNarudzbeButton.Location = new System.Drawing.Point(653, 382);
            this.potvrdaNarudzbeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.potvrdaNarudzbeButton.Name = "potvrdaNarudzbeButton";
            this.potvrdaNarudzbeButton.Size = new System.Drawing.Size(133, 34);
            this.potvrdaNarudzbeButton.TabIndex = 7;
            this.potvrdaNarudzbeButton.Text = "Potvrda narudžbe";
            this.potvrdaNarudzbeButton.UseVisualStyleBackColor = true;
            this.potvrdaNarudzbeButton.Click += new System.EventHandler(this.potvrdaNarudzbeButton_Click);
            // 
            // vratiAsortimanButton
            // 
            this.vratiAsortimanButton.Location = new System.Drawing.Point(469, 377);
            this.vratiAsortimanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vratiAsortimanButton.Name = "vratiAsortimanButton";
            this.vratiAsortimanButton.Size = new System.Drawing.Size(168, 48);
            this.vratiAsortimanButton.TabIndex = 6;
            this.vratiAsortimanButton.Text = "Vrati se na pregled asortimana";
            this.vratiAsortimanButton.UseVisualStyleBackColor = true;
            this.vratiAsortimanButton.Click += new System.EventHandler(this.vratiAsortimanButton_Click);
            // 
            // kosaricaDataGridView
            // 
            this.kosaricaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kosaricaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.kosaricaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kosaricaDataGridView.Name = "kosaricaDataGridView";
            this.kosaricaDataGridView.RowHeadersWidth = 51;
            this.kosaricaDataGridView.RowTemplate.Height = 24;
            this.kosaricaDataGridView.Size = new System.Drawing.Size(413, 338);
            this.kosaricaDataGridView.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ukupna cijena:";
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.Location = new System.Drawing.Point(127, 390);
            this.cijenaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(100, 22);
            this.cijenaTextBox.TabIndex = 10;
            // 
            // KosaricaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cijenaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kosaricaDataGridView);
            this.Controls.Add(this.potvrdaNarudzbeButton);
            this.Controls.Add(this.vratiAsortimanButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KosaricaForma";
            this.Text = "KosaricaForma";
            this.Load += new System.EventHandler(this.KosaricaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kosaricaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button potvrdaNarudzbeButton;
        private System.Windows.Forms.Button vratiAsortimanButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView kosaricaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cijenaTextBox;
    }
}