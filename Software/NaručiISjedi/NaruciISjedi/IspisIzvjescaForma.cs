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
            using (var context = new PI2241_DBEntities1())
            {
                var query = from a in context.Orders
                            orderby a.kolicina descending
                            select a;
                List<Order> narudzbaLista = query.ToList();
                orderBindingSource.DataSource = narudzbaLista;
            }
            this.reportViewer2.RefreshReport(); //iz nekog razloga ne prihvaća datasource
        }

        private void ispisiSlikovnoButton_Click(object sender, EventArgs e)
        {
            List<Order> podatciZaIspis = DohvacanjePodataka();
            Document document = new Document();
            Page page = new Page();
            document.Pages.Add(page);
            ceTe.DynamicPDF.PageElements.Table2 table2 = new ceTe.DynamicPDF.PageElements.Table2(0, 140, 600, 600);
            table2.Columns.Add(180);
            table2.Columns.Add(60);
            table2.Columns.Add(60);
            table2.Columns.Add(80);
            table2.Columns.Add(90);
            ceTe.DynamicPDF.PageElements.Row2 row1 = table2.Rows.Add(35, ceTe.DynamicPDF.Font.HelveticaBold, 12, Grayscale.Black,
           Grayscale.Gray);
            foreach (var item in podatciZaIspis)
            {
                ceTe.DynamicPDF.PageElements.Row2 row2 = table2.Rows.Add(25, ceTe.DynamicPDF.Font.HelveticaBold, 12, Grayscale.Black,
           Grayscale.Gray);
                
                row2.Cells.Add(item.Product.ToString());
                row2.Cells.Add(item.kolicina.ToString());
            }
            if (document != null) 
            {
                document.Draw("C:\\Users\\Korisnik\\Desktop\\IzvjesceGraf.pdf");
            }
            else
            {
                int broj = 0;
                broj++;
                document.Draw("C:\\Users\\Korisnik\\Desktop\\IzvjesceGraf"+broj+".pdf");
            }
            
            string path = "C:\\Users\\Korisnik\\Desktop\\IzvjesceGraf.pdf";
        }

        private void vratiAsortimanButton_Click(object sender, EventArgs e)
        {
            AsortimanForma form = new AsortimanForma(korisnik);
            this.Hide();
            form.ShowDialog();
        }

        private void ispisiIzvjesceButton_Click(object sender, EventArgs e)
        {
            List<Order> podatciZaIspis = DohvacanjePodataka();
            Document document = new Document();
            Page page = new Page();
            document.Pages.Add(page);
            ceTe.DynamicPDF.PageElements.Table2 table2 = new ceTe.DynamicPDF.PageElements.Table2(0, 140, 600, 600);
            table2.Columns.Add(180);
            table2.Columns.Add(60);
            table2.Columns.Add(60);
            table2.Columns.Add(80);
            table2.Columns.Add(90);
            ceTe.DynamicPDF.PageElements.Row2 row1 = table2.Rows.Add(35, ceTe.DynamicPDF.Font.HelveticaBold, 12, Grayscale.Black,
           Grayscale.Gray);
            foreach (var item in podatciZaIspis)
            {
                ceTe.DynamicPDF.PageElements.Row2 row2 = table2.Rows.Add(25, ceTe.DynamicPDF.Font.HelveticaBold, 12, Grayscale.Black,
           Grayscale.Gray);
                row2.Cells.Add(item.IDProizvod.ToString());
                row2.Cells.Add(item.Product.ToString());
                row2.Cells.Add(item.kolicina.ToString());
            }
            if (document != null)
            {
                document.Draw("C:\\Users\\Korisnik\\Desktop\\IzvjesceGraf.pdf");
            }
            else
            {
                int broj = 0;
                broj++;
                document.Draw("C:\\Users\\Korisnik\\Desktop\\IzvjesceGraf" + broj + ".pdf");
            }

            string path = "C:\\Users\\Korisnik\\Desktop\\IzvjesceGraf.pdf";
        }

        private void IspisIzvjescaForma_Load(object sender, EventArgs e)
        {
            
                orderBindingSource.DataSource = DohvacanjePodataka();
            this.reportViewer1.RefreshReport(); //hvata datasource i prikazuje izvješće
            
        }
        private List<Order> DohvacanjePodataka()
        {
            List<Order> narudzbaLista;
            using (var context = new PI2241_DBEntities1())
            {
                var query = from a in context.Orders
                            orderby a.kolicina descending
                            select a;
                return narudzbaLista = query.ToList();
            }
        }
    }
}
