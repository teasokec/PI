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
    public partial class DodavanjeArtikalaForma : Form
    {
        private User korisnik;
        public DodavanjeArtikalaForma(User user)
        {
            InitializeComponent();
            korisnik = user;

        }

        private void DodavanjeArtikalaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
