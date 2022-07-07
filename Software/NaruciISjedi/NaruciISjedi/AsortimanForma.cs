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
    public partial class AsortimanForma : Form
    {
        private Product izabraniProizvod;
        

        public AsortimanForma()
        {
            InitializeComponent();
        }

        private void AsortimanForma_Load(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
        }

        private void OsvjeziPrikaz()
        {
            using (var context = new PI2241_DBEntities1())
            {
                var query = from p in context.Products.Include("Orders").Include("Type")
                            select p;

                dgvProizvodi.DataSource = query.ToList();
                dgvProizvodi.Columns["proizvodID"].Visible = false;
                dgvProizvodi.Columns["IDVrsta"].Visible = false;
                dgvProizvodi.Columns["Orders"].Visible = false;
            }
        }

        private void kreirajIzvjesceButton_Click(object sender, EventArgs e)
        {
            IzradaIzvjescaForma forma = new IzradaIzvjescaForma();
            this.Hide();
            forma.ShowDialog();
        }


        private void kosaricaButton_Click(object sender, EventArgs e)
        {

            KosaricaForma forma = new KosaricaForma(izabraniProizvod);
            this.Hide();
            forma.ShowDialog();
        }
        
        public Product OdabraniProizvod()
        {
            izabraniProizvod = dgvProizvodi.CurrentRow.DataBoundItem as Product;
            return izabraniProizvod;
        }

        private void btnArtikl_Click(object sender, EventArgs e)
        {
            Product selektirani = dgvProizvodi.CurrentRow.DataBoundItem as Product;

            AzuriranjeArtiklaForma azuriranje = new AzuriranjeArtiklaForma(selektirani);
            this.Hide();
            azuriranje.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodavanjeArtiklaForma dodavanje = new DodavanjeArtiklaForma();
            this.Hide();
            dodavanje.ShowDialog();
        }
    }
}
