using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using server;


namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void doVivod(List<server.Tovar> lstTovar)
        {
            lvList.Items.Clear();
            int i = 1;
            foreach (server.Tovar tovar in lstTovar)
            {
                ListViewItem newItem = new ListViewItem(i.ToString());
                lvList.Items.Add(newItem);
                newItem.SubItems.Add(tovar.getName());
                newItem.SubItems.Add(tovar.getPrice().ToString());
                newItem.SubItems.Add(tovar.getKol().ToString());
                newItem.SubItems.Add((tovar.getKol() * tovar.getPrice()).ToString());
                i++;
            }
        }
        TovarOperation tovarOperation = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TcpClientChannel chan = new TcpClientChannel();
                ChannelServices.RegisterChannel(chan, false);
                tovarOperation = (TovarOperation)Activator.GetObject(
                typeof(TovarOperation), "tcp://localhost:9000/TalkIsGood");
                doVivod(tovarOperation.getListOfTovar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd();
            f.ShowDialog();
            if (f.getTovar != null)
            {
                try
                {
                    doVivod(tovarOperation.addNewTovar(f.getTovar));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (txt.Text != "") btnDecide_Click(sender, e);

        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            try
            {
                txt.Text = tovarOperation.getSumOfTovar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                doVivod(tovarOperation.getListOfTovar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvList.SelectedIndices.Count < 1)
            {
                MessageBox.Show(this, "Выберите элемент для удаления!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    tovarOperation.delTovar(lvList.SelectedIndices[0]);
                    doVivod(tovarOperation.getListOfTovar());
                    if (txt.Text != "") btnDecide_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Ошибка соединения: +" + ex, "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
