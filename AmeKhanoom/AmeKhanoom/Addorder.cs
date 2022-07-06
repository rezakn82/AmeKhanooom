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
        Orders order;
        public Addorder()
        {
            InitializeComponent();
            if (Lists.orders.Count == 0)
            {
                NLbl.Text = "1";
            }
            else
            {
                NLbl.Text = (Lists.orders[Lists.orders.Count - 1].Number + 1).ToString();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            order = new Orders(0, 0, 0, 0, 0, 0, 0, 0, 0, "");
            order.Add(Convert.ToInt32(NLbl.Text),RandomCode.DeliveryCodeGenerator(),Convert.ToInt32(TxtSubcode.Text))
        }
    }
}
