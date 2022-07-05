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
            using (var context = new PI2241_DBEntities())
            {
                var query = from p in context.Products.Include("Orders").Include("Type")
                            select p;

                dgvProizvodi.DataSource = query.ToList();
            }
        }

        private void kreirajIzvjesceButton_Click(object sender, EventArgs e)
        {
            IzradaIzvjescaForma form = new IzradaIzvjescaForma();
            this.Hide();
            form.ShowDialog();
        }

        private void kosaricaButton_Click(object sender, EventArgs e)
        {
            KosaricaForma form = new KosaricaForma();
            this.Hide();
            form.ShowDialog();
        }

    }
}
