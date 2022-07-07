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
    public partial class ManageSub : Form
    {
        public ManageSub()
        {
            InitializeComponent();
            SubsTable.DataSource = BaseData.subscribers;
            subcode.DataPropertyName = "SubsCode";
            fname.DataPropertyName = "FirstName";
            lname.DataPropertyName = "LastName";
            credit.DataPropertyName = "Credits";
            ccnumber.DataPropertyName = "CreditCardNumber";
            
        }

        private void AddSubBtn_Click(object sender, EventArgs e)
        {
            Addsub adddsub = new Addsub();
            adddsub.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditSubs editSubs = new EditSubs();
            editSubs.Show();
        }

        private void AddCreditBtn_Click(object sender, EventArgs e)
        {
            AddCredit addCredit = new AddCredit();
            addCredit.Show();
        }

        private void DeleteSubBtn_Click(object sender, EventArgs e)
        {
            DeleteSubs deleteSubs = new DeleteSubs();
            deleteSubs.Show();
        }
    }
}
