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
    public partial class Delivery : Form
    {
        Orders order = new Orders(0, "", 0, 0, 0, 0, 0, 0, 0, "");
        public Delivery()
        {
            InitializeComponent();
        }

        private void DeliverBtn_Click(object sender, EventArgs e)
        {
            order.Deliver(TxtOrderCode.Text, Convert.ToInt32(TxtOrderNum.Text));
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
