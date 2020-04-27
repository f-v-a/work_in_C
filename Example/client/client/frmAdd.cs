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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTovar_Click(object sender, EventArgs e)
        {
            //код проверки на правильность ввода
            if (rdbYesParam.Checked)
            {
                tovar = new Tovar(cmbName.SelectedItem.ToString(), Convert.ToInt32(spnKol.Value), scrPrice.Value);
            }
            else
            {
                tovar = new Tovar();
                tovar.setName(cmbName.SelectedItem.ToString());
                tovar.setKol(Convert.ToInt32(spnKol.Value));
                tovar.setPrice(scrPrice.Value);
            }
            this.Close();
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
