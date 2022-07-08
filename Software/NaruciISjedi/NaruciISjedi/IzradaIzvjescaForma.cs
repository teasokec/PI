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
        public IzradaIzvjescaForma()
        {
            InitializeComponent();
        }

        private void vratiAsortimanButton_Click(object sender, EventArgs e)
        {
            AsortimanForma form = new AsortimanForma(null);
            this.Hide();
            form.ShowDialog();
        }

        private void prikaziIzvjesceButton_Click(object sender, EventArgs e)
        {
            IspisIzvjescaForma form = new IspisIzvjescaForma();
            this.Hide();
            form.ShowDialog();
        }
        public void OdabraniPodatci()
        {
            string datum = datumTextBox.Text;
            string vremenskiPeriod = periodGroupBox.Text;
            
        }

        private void IzradaIzvjescaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
