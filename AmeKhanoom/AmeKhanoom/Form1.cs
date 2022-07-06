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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DateTime now = DateTime.Today;
            DateLbl.Text = "Date: " + now.ToString("dd/MM/yyyy");
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders();
            manageOrders.Show();
        }

        private void SubsBtn_Click(object sender, EventArgs e)
        {
            ManageSub manageSub = new ManageSub();
            manageSub.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Show();
        }
    }
}
