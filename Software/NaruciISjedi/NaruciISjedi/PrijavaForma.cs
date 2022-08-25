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
            bool pronadjen = true;
            using (var context = new PI2241_DBEntities1())
            {
                foreach (var item in context.Users)
                {
                    if (item.korisnickoIme == korIme && item.lozinka == lozinka)
                    {
                        AsortimanForma asortimanForma = new AsortimanForma(item);
                        this.Hide();
                        asortimanForma.ShowDialog();
                    }
                    else
                    {
                        pronadjen = false;
                    }
                    
                }
            }
            if (!pronadjen)
            {
                MessageBox.Show("Krivo uneseni podaci!");
            }
        }

        private void PrijavaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
