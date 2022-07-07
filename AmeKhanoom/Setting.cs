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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            
            TxtSi.DataBindings.Add("Text", BaseData.cookies[0], "Price");
            TxtSa.DataBindings.Add("Text", BaseData.cookies[1], "Price");
            TxtCh.DataBindings.Add("Text", BaseData.cookies[2], "Price");
            TxtRa.DataBindings.Add("Text", BaseData.cookies[3], "Price");
            TxtGi.DataBindings.Add("Text", BaseData.cookies[4], "Price");
            //TxtAddress.DataBindings.Add("Text", BaseData.backupsubs , "Filepath");
        }
    }
}
