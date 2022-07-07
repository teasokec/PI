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
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
        }


        private void btnPrijava_Click(object sender, EventArgs e)
        {
            PrijavaForma form = new PrijavaForma();
            this.Hide();
            form.ShowDialog();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Hide();
            PocetnaForma form = new PocetnaForma();
            form.ShowDialog();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;
            string kontakt = kontaktTextBox.Text;
            string adresa = adresaTextBox.Text;
            string korIme = korisnickoImeTextBox.Text;
            string lozinka = lozinkaTextBox.Text;
            int uloga = cmbUloga.SelectedIndex;

            using (var context = new PI2241_DBEntities1())
            {
                User user = new User()
                {
                    ime = ime,
                    prezime = prezime,
                    kontakt = kontakt,
                    adresa = adresa,
                    korisnickoIme = korIme,
                    lozinka = lozinka,
                    IDUloga = 6
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            using (var context = new PI2241_DBEntities1())
            {
                var query = from r in context.Roles
                            select r.naziv;

                cmbUloga.DataSource = query.ToList();
            }
        }
    }
}
