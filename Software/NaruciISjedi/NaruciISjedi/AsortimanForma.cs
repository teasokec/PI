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
    public partial class AsortimanForma : Form
    {
        public AsortimanForma()
        {
            InitializeComponent();
        }

        private void AsortimanForma_Load(object sender, EventArgs e)
        {
            using (var context = new PI2241_DBEntities())
            {
               // var query = from p in 
            }
        }
    }
}
