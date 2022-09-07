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
        private Order narudzba;
        private User korisnik;

        public AsortimanForma(User user)
        {
            InitializeComponent();
            korisnik = user;
        }

        private void AsortimanForma_Load(object sender, EventArgs e)
        {
            OsvjeziPrikaz();
            kolicnaComboBox.Items.Add(0);
            kolicnaComboBox.Items.Add(1);
            kolicnaComboBox.Items.Add(2);
            kolicnaComboBox.Items.Add(3);
            kolicnaComboBox.Items.Add(4);
            kolicnaComboBox.Items.Add(5);
            kolicnaComboBox.Items.Add(10);
            kolicnaComboBox.Items.Add(20);
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
            for (int i = 0; i < dgvProizvodi.RowCount; i++)
            {

                if (dgvProizvodi[0, i].Value != null)
                {
                    using (var context = new PI2241_DBEntities1())
                    {

                        Order narudzba = new Order()
                        {

                            kolicina = int.Parse(dgvProizvodi[0, i].Value.ToString()),
                            IDProizvod = int.Parse(dgvProizvodi[2, i].Value.ToString()),
                            Product = (Product)dgvProizvodi.CurrentRow.Tag
                        };
                        context.Orders.Add(narudzba);
                    }

                    
                }
            }
            KosaricaForma forma = new KosaricaForma(narudzba);
            this.Hide();
            forma.ShowDialog();
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

        private void kolicinaButton_Click(object sender, EventArgs e)
        {
            string kolicinaOrder = kolicnaComboBox.SelectedItem.ToString();
            
            using (var context = new PI2241_DBEntities1())
            {
                var query = from p in context.Products.Include("Orders").Include("Type")
                            select new Product
                            {
                                Kolicina=int.Parse(kolicinaOrder)
                            };
            }
        }
    }
}

