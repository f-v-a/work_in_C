using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using server;

namespace client
{
    public partial class frmAdd : Form
    {
        Tovar tovar = null;
        public frmAdd()
        {
            InitializeComponent();
        }

        private void scrPrice_Scroll(object sender, ScrollEventArgs e)
        {
            lblPriceInfo.Text = scrPrice.Value.ToString();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            cmbName.SelectedIndex = 0;
            cmbIngred.SelectedIndex = 0;
            cmbRec.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTovar_Click(object sender, EventArgs e)
        {
                tovar = new Tovar();
                tovar.setName(cmbName.SelectedItem.ToString());
                tovar.setIngredients(cmbIngred.SelectedItem.ToString());
                tovar.setSroki(Convert.ToInt32(spnSrok.Value));
                tovar.setPrice(Convert.ToInt32(scrPrice.Value));
                tovar.setQuantity(Convert.ToInt32(spnKol.Value));
                tovar.setRecept(cmbRec.SelectedItem.ToString());
        }
        public Tovar getTovar
        {
            get
            {
                return tovar;
            }
        }

    }
}
