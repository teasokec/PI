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
    public partial class IzradaIzvjescaForma : Form
    {
        private User korisnik;

        public IzradaIzvjescaForma(User user)
        {
            InitializeComponent();
            korisnik = user;
        }

        private void vratiAsortimanButton_Click(object sender, EventArgs e)
        {
            AsortimanForma form = new AsortimanForma(korisnik);
            this.Hide();
            form.ShowDialog();
        }

        private void prikaziIzvjesceButton_Click(object sender, EventArgs e)
        {
            IspisIzvjescaForma form = new IspisIzvjescaForma(korisnik);
            this.Hide();
            form.ShowDialog();
        }
        public void OdabraniPodatci()
        {
            string datum = datumTextBox.Text;
            string[] datumPolje = datum.Split('.');
            int dan = int.Parse(datumPolje[0]);
            int mjesec = int.Parse(datumPolje[1]);
            int godina = int.Parse(datumPolje[2]);
            string vremenskiPeriod = periodGroupBox.Text;
            
            using(var context = new PI2241_DBEntities1())
            {
                var query = from a in context.Orders
                            where a.vrijemeDostave.ToString() == datum && a.vrijemeDostave.ToString() == vremenskiPeriod
                            select a;
            }
        }

        private void IzradaIzvjescaForma_Load(object sender, EventArgs e)
        {
            using (var context =new PI2241_DBEntities1())
            {
                var query = from a in context.Orders
                            select a;
                narudzbeDataGridView.DataSource = query.ToList();
            }
        }
    }
}
