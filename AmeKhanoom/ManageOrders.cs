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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
            OrderTable.DataSource = BaseData.orders;
            number.DataPropertyName = "Number";
            delivercode.DataPropertyName = "DeliveryCode";
            Subscode.DataPropertyName = "CustomerSubsCode";
            price.DataPropertyName = "Price";
            deliverytime.DataPropertyName = "DeliveryTime";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Addorder addorder = new Addorder();
            addorder.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Editorder editorder = new Editorder();
            editorder.Show();
        }
    }
}
