<<<<<<< HEAD:Software/NaruciISjedi/NaruciISjedi/IspisIzvjescaForma.cs
﻿using System;
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
    public partial class IspisIzvjescaForma : Form
    {
        private User korisnik;

        public IspisIzvjescaForma(User user)
        {
            InitializeComponent();
            korisnik = user;
        }

        private void kreirajGrafButton_Click(object sender, EventArgs e)
        {

        }

        private void ispisiSlikovnoButton_Click(object sender, EventArgs e)
        {

        }

        private void vratiAsortimanButton_Click(object sender, EventArgs e)
        {
            AsortimanForma form = new AsortimanForma(korisnik);
            this.Hide();
            form.ShowDialog();
        }

        private void ispisiIzvjesceButton_Click(object sender, EventArgs e)
        {

        }

        private void IspisIzvjescaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
=======
﻿using System;
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
    public partial class IspisIzvjescaForma : Form
    {
        private User korisnik;

        public IspisIzvjescaForma(User user)
        {
            InitializeComponent();
            korisnik = user;
        }

        private void kreirajGrafButton_Click(object sender, EventArgs e)
        {

        }

        private void ispisiSlikovnoButton_Click(object sender, EventArgs e)
        {

        }

        private void vratiAsortimanButton_Click(object sender, EventArgs e)
        {
            AsortimanForma form = new AsortimanForma(korisnik);
            this.Hide();
            form.ShowDialog();
        }

        private void ispisiIzvjesceButton_Click(object sender, EventArgs e)
        {

        }

        private void IspisIzvjescaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> d3e06f60736f549431e354586ba48dd44d5938f2:Software/NaručiISjedi/NaruciISjedi/IspisIzvjescaForma.cs
