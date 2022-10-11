using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIS_20_01.Services;

namespace PIS_20_01
{
    public partial class AuthForm : Form
    {
        static readonly AuthService authService;

        static AuthForm()
        {
            authService = new AuthService();
        }
        public AuthForm()
        {
            InitializeComponent();
            this.Text = $"{Properties.Settings.Default.applicationCaption} - Авторизация";
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (AuthService.TryAuth(textBoxAuthLogin.Text, textBoxAuthPass.Text)){
                Form formAllAds = new AllAdsForm();
                formAllAds.Show();
                this.Hide();
            }
            else MessageBox.Show("Неверный логин или пароль");
        }

        private void buttonAuthGuest_Click(object sender, EventArgs e)
        {
            Form allAdsForm = new AllAdsForm("guest");
            allAdsForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
