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

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijaForm registracijaForm = new RegistracijaForm();
            this.Hide();
            registracijaForm.ShowDialog();
            this.Show();
        }
    }
}
