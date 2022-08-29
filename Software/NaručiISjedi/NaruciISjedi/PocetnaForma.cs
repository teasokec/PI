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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void prijaviButton_Click(object sender, EventArgs e)
        {
            PrijavaForma form = new PrijavaForma();
            this.Hide();
            form.ShowDialog();
        }

        private void asortimanButton_Click(object sender, EventArgs e)
        {
            AsortimanForma forma = new AsortimanForma(null);
            this.Hide();
            forma.ShowDialog();
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            RegistracijaForm form = new RegistracijaForm();
            this.Hide();
            form.ShowDialog();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
