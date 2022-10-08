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
    public partial class AllAdsForm : Form
    {
        public AllAdsForm()
        {
            InitializeComponent();
            fillDataGrid();
        }

        public AllAdsForm(string role)
        {
            InitializeComponent();
            if (role == "guest")
            {
                buttonEdit.Enabled = false;
                buttonDel.Enabled = false;
            }
            fillDataGrid();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Form formWatchTheAd = new FormWatchTheAd();
            formWatchTheAd.ShowDialog();
        }

        private void fillDataGrid()
        {
            dataGridViewAllAds.Rows.Add("1", "Кошка");
            dataGridViewAllAds.Rows.Add("2", "Собака");
            dataGridViewAllAds.Rows.Add("3", "Морж");
            dataGridViewAllAds.Rows.Add("4", "Лев");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            dataGridViewAllAds.Rows.Remove(dataGridViewAllAds.CurrentRow);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form formChangeAd = new FormChangeAd();
            formChangeAd.ShowDialog();
        }

        private void buttonNewAd_Click(object sender, EventArgs e)
        {
            Form formAddNew = new FormAddNew();
            formAddNew.ShowDialog();
        }

        private void AllAdsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
