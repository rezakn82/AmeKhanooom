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
    public partial class AddCredit : Form
    {
        Subscribers subscriber;
        public AddCredit()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            subscriber = new Subscribers("", "", "", "", 0);
            subscriber.AddCredit(Convert.ToInt32(TxtSubcode.Text), Convert.ToInt32(TxtCredit.Text));
            this.Close();
        }
    }
}
