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
    public partial class Addsub : Form
    {
        Subscribers subscriber;
        public Addsub()
        {
            InitializeComponent();
            if (Lists.subscribers.Count == 0)
            {
                TxtSubcode.Text = "10000";
            }
            else
            {
                TxtSubcode.Text = (Lists.subscribers[Lists.subscribers.Count-1].SubsCode+1).ToString();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            subscriber = new Subscribers("", "", "", "", 0);
            subscriber.Add(TxtFname.Text, TxtLname.Text, TxtCCnumber.Text, TxtPhone.Text, Convert.ToInt32(TxtSubcode.Text));
            this.Close();
        }
    }
}
