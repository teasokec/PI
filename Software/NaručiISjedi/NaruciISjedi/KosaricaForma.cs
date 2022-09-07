using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;

namespace NaruciISjedi
{
    public partial class KosaricaForma : Form
    {
        private User korisnik;
        private Order narudzba;
        public KosaricaForma(Order order)
        {
            InitializeComponent();
            order = narudzba;
            
            
        }
        private void KosaricaForma_Load(object sender, EventArgs e)
        {
            
        }
        private void OsvjeziPrikaz()
        {
            using (var context = new PI2241_DBEntities1())
            {
                foreach (var item in context.Orders)
                {
                    if (item.narudzbaID == narudzba.narudzbaID)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Vaša košarica je trenutno prazna!\nVratite se na asortiman i odaberite proizvode!");
                    }
                }
            }
        }
                
        private void vratiAsortimanButton_Click(object sender, EventArgs e)
        {
            AsortimanForma form = new AsortimanForma(korisnik);
            this.Hide();
            form.ShowDialog();
        }

        private void potvrdaNarudzbeButton_Click(object sender, EventArgs e)
        {
            if (kosaricaDataGridView.Rows.Count <= 1)
            {
                    MessageBox.Show("Vaša košarica je trenutno prazna!\nVratite se na asortiman i odaberite proizvode!");
                }
            else
            {
                List<Order> podatciZaIspis = DohvacanjePodataka();
                Document document = new Document();
                Page page = new Page();
                document.Pages.Add(page);
                ceTe.DynamicPDF.PageElements.Label label1 = new ceTe.DynamicPDF.PageElements.Label("Zahvaljujemo Vam se na kupnji!", 0, 35, 504, 100, ceTe.DynamicPDF.Font.TimesBoldItalic, 18, TextAlign.Right);
                //ceTe.DynamicPDF.PageElements.Label label2 = new ceTe.DynamicPDF.PageElements.Label("Ukupno za platiti: " + KosaricaForma.sum, 0, 0, 504, 100, ceTe.DynamicPDF.Font.HelveticaBold, 14, TextAlign.Center);
                ceTe.DynamicPDF.PageElements.Table2 table1 = new ceTe.DynamicPDF.PageElements.Table2(0, 140, 600, 600);
                table1.Columns.Add(180);
                table1.Columns.Add(60);
                table1.Columns.Add(60);
                table1.Columns.Add(80);
                table1.Columns.Add(90);
                ceTe.DynamicPDF.PageElements.Row2 row1 = table1.Rows.Add(35, ceTe.DynamicPDF.Font.HelveticaBold, 12, Grayscale.Black,
               Grayscale.Gray);
                foreach (var item in podatciZaIspis)
                {
                    ceTe.DynamicPDF.PageElements.Row2 row2 = table1.Rows.Add(25, ceTe.DynamicPDF.Font.HelveticaBold, 12, Grayscale.Black,
               Grayscale.Gray);

                    row2.Cells.Add(item.Product.ToString());
                    row2.Cells.Add(item.kolicina.ToString());
                    row2.Cells.Add(item.ukupnaCijena.ToString());
                    row2.Cells.Add(item.adresaDostave);

                }
                page.Elements.Add(table1);
                page.Elements.Add(label1);
               // page.Elements.Add(label2);
                
                if (document != null)
                {
                    document.Draw("C:\\Users\\Korisnik\\Desktop\\Račun.pdf");
                }
                else
                {
                    int broj = 0;
                    broj++;
                    document.Draw("C:\\Users\\Korisnik\\Desktop\\Račun" + broj + ".pdf");
                }

                string path = "C:\\Users\\Korisnik\\Desktop\\Račun.pdf";
            }
        }
        private List<Order> DohvacanjePodataka()
        {
            List<Order> narudzbaLista;
            using (var context = new PI2241_DBEntities1())
            {
                var query = from a in context.Orders
                            where a.narudzbaID==narudzba.narudzbaID
                            select a;
                return narudzbaLista = query.ToList();
            }
        }
    }
}
