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
    public partial class FormMyAds : Form
    {
        public FormMyAds()
        {
            InitializeComponent();
            fillDataGrid();
        }

        private void dataGridViewЬнAds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Form formWatchTheAdd = new FormWatchTheAd();
            formWatchTheAdd.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form formChangeAd = new FormChangeAd();
            formChangeAd.ShowDialog();
        }

        private void fillDataGrid()
        {
            dataGridViewMyAds.Rows.Add("1", "Кошка");
            dataGridViewMyAds.Rows.Add("2", "Собака");
            dataGridViewMyAds.Rows.Add("3", "Морж");
            dataGridViewMyAds.Rows.Add("4", "Лев");
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            dataGridViewMyAds.Rows.Remove(dataGridViewMyAds.CurrentRow);
        }
    }
}
