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
    public partial class DodavanjeArtiklaForma : Form
    {
        public DodavanjeArtiklaForma()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
            AsortimanForma asortimanForma = new AsortimanForma();
            asortimanForma.ShowDialog();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string naziv = nazivTextBox.Text;
            string sastojci = sastojciRichTextBox.Text;
            string cijena = cijenaTextBox.Text;
            var vrsta = vrstaComboBox.SelectedIndex;

            using (var context = new PI2241_DBEntities1())
            {
                var query = from p in context.Products
                            select p;

                int brojac = query.Count();

                Product product = new Product
                {
                    proizvodID = brojac + 1,
                    naziv = naziv,
                    sastojci = sastojci,
                    cijenaProizvoda = float.Parse(cijena),
                    IDVrsta = vrsta + 1,
                };

                context.Products.Add(product);
                context.SaveChanges();
            }
            Close();
            AsortimanForma forma = new AsortimanForma();
            forma.ShowDialog();
        }

        private void DodavanjeArtiklaForma_Load(object sender, EventArgs e)
        {
            using (var context = new PI2241_DBEntities1())
            {
                var query = from t in context.Types
                            select t.naziv;

                vrstaComboBox.DataSource = query.ToList();
            }
        }
    }
    }

