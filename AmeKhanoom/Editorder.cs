using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmeKhanoom
{
    public partial class Editorder : Form
    {
        Orders order = new Orders(0, "", 0, 0, 0, 0, 0, 0, 0, "");
        public Editorder()
        {
            InitializeComponent();
        }

        private void FindOrderBtn_Click(object sender, EventArgs e)
        {
            Orders wantedorder = order.Findorder(Txtdelcode.Text,Convert.ToInt32(Txtnum.Text));
            if (wantedorder != null)
            {
                TxtSi.Text = wantedorder.CookieSi.ToString();
                TxtSa.Text = wantedorder.CookieSa.ToString();
                TxtCh.Text = wantedorder.CookieCh.ToString();
                TxtRa.Text = wantedorder.CookieRa.ToString();
                TxtGi.Text = wantedorder.CookieGi.ToString();
                deltimeCbox.SelectedItem = wantedorder.DeliveryTime;
                Txtdelcode.ReadOnly = true;
                Txtnum.ReadOnly = true;
            }
            else
            {
                order.OrderNotFound();
            }
        }

        private void CaclpriseBtn_Click(object sender, EventArgs e)
        {
            int price = order.CalcPrice(Convert.ToInt32(TxtSi.Text), Convert.ToInt32(TxtSa.Text), Convert.ToInt32(TxtCh.Text), Convert.ToInt32(TxtRa.Text), Convert.ToInt32(TxtGi.Text));
            PriseLbl.Text = price.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int price = order.CalcPrice(Convert.ToInt32(TxtSi.Text), Convert.ToInt32(TxtSa.Text), Convert.ToInt32(TxtCh.Text), Convert.ToInt32(TxtRa.Text), Convert.ToInt32(TxtGi.Text));

            order.Edit(Txtdelcode.Text, price, Convert.ToInt32(TxtSi.Text), Convert.ToInt32(TxtSa.Text),
                       Convert.ToInt32(TxtCh.Text), Convert.ToInt32(TxtRa.Text), Convert.ToInt32(TxtGi.Text),deltimeCbox.Text, Convert.ToInt32(Txtnum.Text));
        }

        private void TxtSi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtSa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtCh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void TxtGi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
