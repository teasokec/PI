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
            this.components = new System.ComponentModel.Container();
            this.kosaricaButton = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.kreirajIzvjesceButton = new System.Windows.Forms.Button();
            this.kolicinaButton = new System.Windows.Forms.Button();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVrstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaProizvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sastojciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaProizvodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
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
            this.dgvProizvodi.AutoGenerateColumns = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proizvodIDDataGridViewTextBoxColumn,
            this.iDVrstaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaProizvodaDataGridViewTextBoxColumn,
            this.Količina,
            this.sastojciDataGridViewTextBoxColumn,
            this.slikaProizvodaDataGridViewTextBoxColumn,
            this.ordersDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvProizvodi.DataSource = this.productBindingSource;
            this.dgvProizvodi.Location = new System.Drawing.Point(19, 12);
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
            // kolicinaButton
            // 
            this.kolicinaButton.Location = new System.Drawing.Point(425, 379);
            this.kolicinaButton.Name = "kolicinaButton";
            this.kolicinaButton.Size = new System.Drawing.Size(109, 45);
            this.kolicinaButton.TabIndex = 7;
            this.kolicinaButton.Text = "Unesi zadanu kolicinu";
            this.kolicinaButton.UseVisualStyleBackColor = true;
            this.kolicinaButton.Click += new System.EventHandler(this.kolicinaButton_Click);
            // 
            // Količina
            // 
            this.Količina.HeaderText = "Količina";
            this.Količina.MinimumWidth = 6;
            this.Količina.Name = "Količina";
            this.Količina.Width = 125;
            // 
            // proizvodIDDataGridViewTextBoxColumn
            // 
            this.proizvodIDDataGridViewTextBoxColumn.DataPropertyName = "proizvodID";
            this.proizvodIDDataGridViewTextBoxColumn.HeaderText = "proizvodID";
            this.proizvodIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proizvodIDDataGridViewTextBoxColumn.Name = "proizvodIDDataGridViewTextBoxColumn";
            this.proizvodIDDataGridViewTextBoxColumn.Visible = false;
            this.proizvodIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDVrstaDataGridViewTextBoxColumn
            // 
            this.iDVrstaDataGridViewTextBoxColumn.DataPropertyName = "IDVrsta";
            this.iDVrstaDataGridViewTextBoxColumn.HeaderText = "IDVrsta";
            this.iDVrstaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDVrstaDataGridViewTextBoxColumn.Name = "iDVrstaDataGridViewTextBoxColumn";
            this.iDVrstaDataGridViewTextBoxColumn.Visible = false;
            this.iDVrstaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // cijenaProizvodaDataGridViewTextBoxColumn
            // 
            this.cijenaProizvodaDataGridViewTextBoxColumn.DataPropertyName = "cijenaProizvoda";
            this.cijenaProizvodaDataGridViewTextBoxColumn.HeaderText = "cijenaProizvoda";
            this.cijenaProizvodaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaProizvodaDataGridViewTextBoxColumn.Name = "cijenaProizvodaDataGridViewTextBoxColumn";
            this.cijenaProizvodaDataGridViewTextBoxColumn.Width = 125;
            // 
            // sastojciDataGridViewTextBoxColumn
            // 
            this.sastojciDataGridViewTextBoxColumn.DataPropertyName = "sastojci";
            this.sastojciDataGridViewTextBoxColumn.HeaderText = "sastojci";
            this.sastojciDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sastojciDataGridViewTextBoxColumn.Name = "sastojciDataGridViewTextBoxColumn";
            this.sastojciDataGridViewTextBoxColumn.Width = 125;
            // 
            // slikaProizvodaDataGridViewTextBoxColumn
            // 
            this.slikaProizvodaDataGridViewTextBoxColumn.DataPropertyName = "slikaProizvoda";
            this.slikaProizvodaDataGridViewTextBoxColumn.HeaderText = "slikaProizvoda";
            this.slikaProizvodaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.slikaProizvodaDataGridViewTextBoxColumn.Name = "slikaProizvodaDataGridViewTextBoxColumn";
            this.slikaProizvodaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            this.ordersDataGridViewTextBoxColumn.Visible = false;
            this.ordersDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            this.typeDataGridViewTextBoxColumn.Width = 125;
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
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.Location = new System.Drawing.Point(278, 390);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(100, 22);
            this.kolicinaTextBox.TabIndex = 8;
            // 
            // AsortimanForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NaruciISjedi.Properties.Resources._256x256bb;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(this.kolicinaButton);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kosaricaButton;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button kreirajIzvjesceButton;
        private System.Windows.Forms.Button kolicinaButton;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVrstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaProizvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.DataGridViewTextBoxColumn sastojciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaProizvodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TextBox kolicinaTextBox;
    }
}