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
        private User korisnik;

        public AsortimanForma(User user)
        {
            InitializeComponent();
            korisnik = user;
        }

        private void AsortimanForma_Load(object sender, EventArgs e)
        {
            if (korisnik.IDUloga == 4)
            {
                OsvjeziPrikaz();
                kreirajIzvjesceButton.Visible = false;
                btnArtikl.Visible = false;
                btnDodaj.Visible = false;
                btnOdjava.Visible = false;
            }
 
            else if (korisnik.IDUloga != 4)
            {
                OsvjeziPrikaz();
                kreirajIzvjesceButton.Visible = true;
                btnArtikl.Visible = true;
                btnDodaj.Visible = true;
                btnOdjava.Visible = true;
            }
            else
            {
                btnOdjava.Visible = true;
            }
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
            IzradaIzvjescaForma forma = new IzradaIzvjescaForma(korisnik);
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

            AzuriranjeArtiklaForma azuriranje = new AzuriranjeArtiklaForma(selektirani, korisnik);
            this.Hide();
            azuriranje.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodavanjeArtiklaForma dodavanje = new DodavanjeArtiklaForma(korisnik);
            this.Hide();
            dodavanje.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            korisnik = null;
            PocetnaForma pocetnaForma = new PocetnaForma();
            this.Hide();
            pocetnaForma.ShowDialog();
        }
    }
}
