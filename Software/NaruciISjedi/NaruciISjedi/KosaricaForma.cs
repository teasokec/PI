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
    public partial class KosaricaForma : Form
    {
        Order izabraniProizvodi;
        public KosaricaForma(Order narudzba)
        {
            InitializeComponent();
            narudzba = izabraniProizvodi;
        }
        private void KosaricaForma_Load(object sender, EventArgs e)
        {

            using (var context = new PI2241_DBEntities1())
            {
                var query = from a in context.Orders.Include("Product").Include("User")
                            select a;
                kosaricaDataGridView.DataSource = query.ToList();
            }

        }
    }
}
