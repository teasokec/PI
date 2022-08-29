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
        Product izabraniProizvod;
        public KosaricaForma(Product proizvod)
        {
            InitializeComponent();
            proizvod = izabraniProizvod;
        }
        private void KosaricaForma_Load(object sender, EventArgs e)
        {
            kosaricaDataGridView.DataSource = izabraniProizvod;
        }

    }
}
