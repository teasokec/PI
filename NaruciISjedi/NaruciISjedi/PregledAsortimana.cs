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
    public partial class PregledAsortimana : Form
    {
        public PregledAsortimana()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pI2241_DBDataSet);

        }

        private void PregledAsortimana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pI2241_DBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.pI2241_DBDataSet.Product);

        }
    }
}
