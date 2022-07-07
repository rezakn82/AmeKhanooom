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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SubRbtn.Checked)
            {
                BaseData.backupsubs.Save();
            }
            else if (OrderRbtn.Checked)
            {
                BaseData.backuporders.Save();
            }
            else
            {
                MessageBox.Show("Pleas Select One", "Error");
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (SubRbtn.Checked)
            {
                BaseData.backupsubs.Load();
            }
            else if (OrderRbtn.Checked)
            {
                BaseData.backuporders.Load();
            }
            else
            {
                MessageBox.Show("Pleas Select One", "Error");
            }
        }
    }
}
