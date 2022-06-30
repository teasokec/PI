using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaruciISjedi
{
    public partial class PregledAsortimana : Form
    {
        public PregledAsortimana()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
        }

        private void PregledAsortimana_Load(object sender, EventArgs e)
        {
            using (var context = new PI2241_DBEntities1())
            {
                var query = from p in context.Products.Include("Orders").Include("Type")
                            select p;

                dgvProducts.DataSource = query.ToList();
                dgvProducts.Columns["Orders"].Visible = false;
                dgvProducts.Columns["Type"].Visible = false;
                btnAzuriraj.Enabled = false;
                btnDodaj.Enabled = false;
                btnObrisi.Enabled = false;
                
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajForm dodajForm = new DodajForm();
            this.Hide();
            dodajForm.ShowDialog();
            this.Show();
        }

        private void tbUnos_TextChanged(object sender, EventArgs e)
        {
            string unos = tbUnos.Text;
            using (var context = new PI2241_DBEntities1())
            {
                var query = from p in context.Products
                            where p.naziv.Contains(unos)
                            select p;

                dgvProducts.DataSource = query.ToList();
            }
        }
    }
}
