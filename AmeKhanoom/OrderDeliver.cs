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
    public partial class OrderDeliver : Form
    {
        public OrderDeliver()
        {
            InitializeComponent();
            OrderTable.DataSource = BaseData.deliveredorders;
            number.DataPropertyName = "Number";
            delivercode.DataPropertyName = "DeliveryCode";
            Subscode.DataPropertyName = "CustomerSubsCode";
            price.DataPropertyName = "Price";
            deliverytime.DataPropertyName = "DeliveryTime";
        }

        private void DeliverBtn_Click(object sender, EventArgs e)
        {

            Delivery delivery = new Delivery();
            delivery.Show();
        }

        private void SellBtn_Click(object sender, EventArgs e)
        {
            Selling selling = new Selling();
            selling.Show();
        }
    }
}
