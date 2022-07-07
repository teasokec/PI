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
    public partial class PrijavaForma : Form
    {
        public PrijavaForma()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            PocetnaForma forma = new PocetnaForma();
            this.Hide();
            forma.ShowDialog();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijaForm form = new RegistracijaForm();
            this.Hide();
            form.ShowDialog();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korIme = tbKorIme.Text;
            string lozinka = tbLozinka.Text;

            AsortimanForma asortimanForma = new AsortimanForma();

            using (var context = new PI2241_DBEntities1())
            {
                var query = from u in context.Users
                            where u.korisnickoIme == korIme && u.lozinka == lozinka
                            select u;

                if (query.Count() > 0)
                {
                    this.Hide();
                    asortimanForma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Krivo uneseni podaci!");
                }
            }
        }
    }
}
