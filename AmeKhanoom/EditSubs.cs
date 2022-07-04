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
    public partial class EditSubs : Form
    {
        Subscribers subscriber;
        public EditSubs()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindSubBtn_Click(object sender, EventArgs e)
        {
            subscriber = new Subscribers("", "", "", "", 0);
            Subscribers Wantedsub = subscriber.FindSub(Convert.ToInt32(TxtSubcode.Text));
            if (Wantedsub != null)
            {
                TxtFname.Text = Wantedsub.FirstName;
                TxtLname.Text = Wantedsub.LastName;
                TxtCCnumber.Text = Wantedsub.CreditCardNumber;
                TxtPhone.Text = Wantedsub.PhoneNumber;
                TxtSubcode.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Subscriber not found!", "Wrong Input");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            subscriber = new Subscribers("", "", "", "", 0);
            subscriber.Edit(Convert.ToInt32(TxtSubcode.Text),TxtFname.Text,TxtLname.Text,TxtCCnumber.Text,TxtPhone.Text);
        }
    }
}
