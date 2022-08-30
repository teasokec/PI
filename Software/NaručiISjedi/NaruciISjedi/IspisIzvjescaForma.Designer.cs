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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vratiAsortimanButton = new System.Windows.Forms.Button();
            this.ispisiSlikovnoButton = new System.Windows.Forms.Button();
            this.ispisiIzvjesceButton = new System.Windows.Forms.Button();
            this.kreirajGrafButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vratiAsortimanButton
            // 
            this.vratiAsortimanButton.Location = new System.Drawing.Point(542, 389);
            this.vratiAsortimanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vratiAsortimanButton.Name = "vratiAsortimanButton";
            this.vratiAsortimanButton.Size = new System.Drawing.Size(171, 50);
            this.vratiAsortimanButton.TabIndex = 8;
            this.vratiAsortimanButton.Text = "Vrati se na pregled asortimana";
            this.vratiAsortimanButton.UseVisualStyleBackColor = true;
            this.vratiAsortimanButton.Click += new System.EventHandler(this.vratiAsortimanButton_Click);
            // 
            // ispisiSlikovnoButton
            // 
            this.ispisiSlikovnoButton.Location = new System.Drawing.Point(161, 389);
            this.ispisiSlikovnoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ispisiSlikovnoButton.Name = "ispisiSlikovnoButton";
            this.ispisiSlikovnoButton.Size = new System.Drawing.Size(112, 50);
            this.ispisiSlikovnoButton.TabIndex = 7;
            this.ispisiSlikovnoButton.Text = "Ispiši slikovni prikaz";
            this.ispisiSlikovnoButton.UseVisualStyleBackColor = true;
            this.ispisiSlikovnoButton.Click += new System.EventHandler(this.ispisiSlikovnoButton_Click);
            // 
            // ispisiIzvjesceButton
            // 
            this.ispisiIzvjesceButton.Location = new System.Drawing.Point(290, 389);
            this.ispisiIzvjesceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ispisiIzvjesceButton.Name = "ispisiIzvjesceButton";
            this.ispisiIzvjesceButton.Size = new System.Drawing.Size(112, 50);
            this.ispisiIzvjesceButton.TabIndex = 6;
            this.ispisiIzvjesceButton.Text = "Ispiši izvješće";
            this.ispisiIzvjesceButton.UseVisualStyleBackColor = true;
            this.ispisiIzvjesceButton.Click += new System.EventHandler(this.ispisiIzvjesceButton_Click);
            // 
            // kreirajGrafButton
            // 
            this.kreirajGrafButton.Location = new System.Drawing.Point(12, 389);
            this.kreirajGrafButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kreirajGrafButton.Name = "kreirajGrafButton";
            this.kreirajGrafButton.Size = new System.Drawing.Size(112, 50);
            this.kreirajGrafButton.TabIndex = 5;
            this.kreirajGrafButton.Text = "Kreiraj slikovni prikaz";
            this.kreirajGrafButton.UseVisualStyleBackColor = true;
            this.kreirajGrafButton.Click += new System.EventHandler(this.kreirajGrafButton_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "OrdersRep";
            reportDataSource1.Value = this.orderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NaruciISjedi.OrdersPrikazOsnovno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(701, 372);
            this.reportViewer1.TabIndex = 9;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(NaruciISjedi.Order);
            // 
            // IspisIzvjescaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.vratiAsortimanButton);
            this.Controls.Add(this.ispisiSlikovnoButton);
            this.Controls.Add(this.ispisiIzvjesceButton);
            this.Controls.Add(this.kreirajGrafButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IspisIzvjescaForma";
            this.Text = "IspisIzvjescaForma";
            this.Load += new System.EventHandler(this.IspisIzvjescaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vratiAsortimanButton;
        private System.Windows.Forms.Button ispisiSlikovnoButton;
        private System.Windows.Forms.Button ispisiIzvjesceButton;
        private System.Windows.Forms.Button kreirajGrafButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}