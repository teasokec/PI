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
            using (var context = new baza_podataka())
            {
                var query = from p in context.Products.Include("Orders").Include("Type")
                            select p;

                dgvProizvodi.DataSource = query.ToList();
                
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

            KosaricaForma forma = new KosaricaForma();
            this.Hide();
            forma.ShowDialog();
        }
        
        
    }
}
