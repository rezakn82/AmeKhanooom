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
    public partial class Addorder : Form
    {
        Orders order=new Orders(0, "", 0, 0, 0, 0, 0, 0, 0, "");
        Subscribers subscribers = new Subscribers("", "", "", "", 0, 0);
        public Addorder()
        {
            InitializeComponent();
            if (BaseData.orders.Count == 0)
            {
                NLbl.Text = "1";
            }
            else
            {
                NLbl.Text = (BaseData.orders[BaseData.orders.Count - 1].Number + 1).ToString();
            }
            SiLbl.Text = BaseData.cookies[0].Price.ToString();
            SaLbl.Text = BaseData.cookies[1].Price.ToString();
            ChLbl.Text = BaseData.cookies[2].Price.ToString();
            RaLbl.Text = BaseData.cookies[3].Price.ToString();
            GiLbl.Text = BaseData.cookies[4].Price.ToString();

            TxtCh.Text = "0";
            TxtSa.Text = "0";
            TxtSi.Text = "0";
            TxtRa.Text = "0";
            TxtGi.Text = "0";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {        
            int prise = order.CalcPrice(Convert.ToInt32(TxtSi.Text), Convert.ToInt32(TxtSa.Text), Convert.ToInt32(TxtCh.Text), Convert.ToInt32(TxtRa.Text), Convert.ToInt32(TxtGi.Text));
            
            order.Add(Convert.ToInt32(NLbl.Text), RandomCode.RandomString(), Convert.ToInt32(TxtSubcode.Text),prise,
                     Convert.ToInt32(TxtSi.Text), Convert.ToInt32(TxtSa.Text), Convert.ToInt32(TxtCh.Text), Convert.ToInt32(TxtRa.Text), Convert.ToInt32(TxtGi.Text),DelivetimeCbox.Text);
        }

        private void AddCredit_Click(object sender, EventArgs e)
        {
            AddCredit addCredit = new AddCredit();
            addCredit.Show();
        }

        private void CaclpriseBtn_Click(object sender, EventArgs e)
        {
            int price = order.CalcPrice(Convert.ToInt32(TxtSi.Text), Convert.ToInt32(TxtSa.Text), Convert.ToInt32(TxtCh.Text), Convert.ToInt32(TxtRa.Text), Convert.ToInt32(TxtGi.Text));
            PriseLbl.Text = price.ToString();
            Subscribers subscriber = (Subscribers)subscribers.FindSub(Convert.ToInt32(TxtSubcode.Text));
            custcredLbl.Text = subscriber.Credits.ToString();
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

        private void TxtSubcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
