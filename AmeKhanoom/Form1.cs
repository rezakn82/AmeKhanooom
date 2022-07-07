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
        AutoBackupOrders orders = new AutoBackupOrders();
        AutoBackupSubs subs = new AutoBackupSubs();
        CookiePrice price = new CookiePrice();
        Cookies cookie { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Configs config = new Configs();
            config.Load();
            DateTime now = DateTime.Today;
            DateLbl.Text = "Date: " + now.ToString("dd-MM-yyyy");
            cookie = new Cookies("");
            cookie.Add();
            price.Load();
            if (config.YN == 'Y')
            {
                cookie.Add();
                orders.LoadtoDeliver();
                subs.Load();
            }
            else if (config.YN == 'N')
            {
                cookie.Add();
                orders.Load();
                subs.Load();
                orders.LoadSolds();
            }

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
            price.Save();
            DialogResult dialogResult = MessageBox.Show("Is Day Over?", "Goodbye", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Configs config = new Configs();
                config.YN = 'Y';
                config.Save();
                orders.Save();
                subs.Save();
                orders.SaveSolds();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                Configs config = new Configs();
                config.YN = 'N';
                config.Save();
                orders.Save();
                subs.Save();
                orders.SaveSolds();
                Application.Exit();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Show();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void DelorderBtn_Click(object sender, EventArgs e)
        {
            OrderDeliver delivery = new OrderDeliver();
            delivery.Show();
        }

        private void OlderOrderBtn_Click(object sender, EventArgs e)
        {
            Olderorder delivery = new Olderorder();
            delivery.Show();
        }
    }
}
