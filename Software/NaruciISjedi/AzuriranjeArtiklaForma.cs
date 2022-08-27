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
    public partial class AzuriranjeArtiklaForma : Form
    {
        private Product selektirani;
        private User korisnik;

        public AzuriranjeArtiklaForma(Product izabrani, User user)
        {
            InitializeComponent();
            selektirani = izabrani;
            korisnik = user;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsortimanForma asortimanForma = new AsortimanForma(korisnik);
            asortimanForma.ShowDialog();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string naziv = nazivTextBox.Text;
            string sastojci = sastojciRichTextBox.Text;
            string cijena = cijenaTextBox.Text;
            var vrsta = selektirani.IDVrsta;

            using (var context = new PI2241_DBEntities1())
            {
                context.Products.Attach(selektirani);
                selektirani.proizvodID = selektirani.proizvodID;
                selektirani.naziv = naziv;
                selektirani.sastojci = sastojci;
                selektirani.cijenaProizvoda = float.Parse(cijena);
                selektirani.IDVrsta = vrsta;

                context.SaveChanges();
            }
            Close();
            AsortimanForma forma = new AsortimanForma(korisnik);
            forma.ShowDialog();
        }

        private void AzuriranjeArtiklaForma_Load(object sender, EventArgs e)
        {
            nazivTextBox.Text = selektirani.naziv;
            sastojciRichTextBox.Text = selektirani.sastojci;
            cijenaTextBox.Text = selektirani.cijenaProizvoda.ToString();
            vrstaComboBox.Text = selektirani.IDVrsta.ToString();
        }
    }
}
