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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            Form formAllAds = new AllAdsForm();
            formAllAds.ShowDialog();
        }

        private void buttonAuthGuest_Click(object sender, EventArgs e)
        {
            Form allAdsForm = new AllAdsForm("guest");
            allAdsForm.ShowDialog();
        }
    }
}
