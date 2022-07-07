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
    public partial class Olderorder : Form
    {
        Archieve archieve = new Archieve();
        public Olderorder()
        {
            InitializeComponent();
            OrderTable.DataSource = BaseData.archieve;
            number.DataPropertyName = "Number";
            delivercode.DataPropertyName = "DeliveryCode";
            Subscode.DataPropertyName = "CustomerSubsCode";
            price.DataPropertyName = "Price";
            deliverytime.DataPropertyName = "DeliveryTime";
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            archieve.Load();
        }
    }
}
