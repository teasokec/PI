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

        private void registracijaButton_Click(object sender, EventArgs e)
        {

        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            NeuspjesnaPrijavaForma form = new NeuspjesnaPrijavaForma();
            form.Show();
        }
    }
}
