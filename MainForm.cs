using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_20_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string role)
        {
            InitializeComponent();
            
        }

        private void buttonAllAds_Click(object sender, EventArgs e)
        {
            Form formAllAds = new AllAdsForm();
            formAllAds.ShowDialog();
        }

        private void buttonNewAd_Click(object sender, EventArgs e)
        {
            Form formAddNew = new FormAddNew();
            formAddNew.ShowDialog();
        }

        private void buttonMyAds_Click(object sender, EventArgs e)
        {
            Form formMyAds = new FormMyAds();
            formMyAds.ShowDialog();
        }
    }
}
