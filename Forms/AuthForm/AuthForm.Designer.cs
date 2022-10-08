
namespace PIS_20_01
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAuth = new System.Windows.Forms.Label();
            this.labelAuthLogin = new System.Windows.Forms.Label();
            this.textBoxAuthLogin = new System.Windows.Forms.TextBox();
            this.labelAuthPass = new System.Windows.Forms.Label();
            this.textBoxAuthPass = new System.Windows.Forms.TextBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.buttonAuthGuest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(50, 5);
            this.labelAuth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(109, 20);
            this.labelAuth.TabIndex = 0;
            this.labelAuth.Text = "Авторизация";
            // 
            // labelAuthLogin
            // 
            this.labelAuthLogin.AutoSize = true;
            this.labelAuthLogin.Location = new System.Drawing.Point(11, 27);
            this.labelAuthLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthLogin.Name = "labelAuthLogin";
            this.labelAuthLogin.Size = new System.Drawing.Size(41, 13);
            this.labelAuthLogin.TabIndex = 1;
            this.labelAuthLogin.Text = "Логин:";
            // 
            // textBoxAuthLogin
            // 
            this.textBoxAuthLogin.Location = new System.Drawing.Point(63, 27);
            this.textBoxAuthLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAuthLogin.Name = "textBoxAuthLogin";
            this.textBoxAuthLogin.Size = new System.Drawing.Size(108, 20);
            this.textBoxAuthLogin.TabIndex = 2;
            // 
            // labelAuthPass
            // 
            this.labelAuthPass.AutoSize = true;
            this.labelAuthPass.Location = new System.Drawing.Point(11, 52);
            this.labelAuthPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAuthPass.Name = "labelAuthPass";
            this.labelAuthPass.Size = new System.Drawing.Size(48, 13);
            this.labelAuthPass.TabIndex = 3;
            this.labelAuthPass.Text = "Пароль:";
            // 
            // textBoxAuthPass
            // 
            this.textBoxAuthPass.Location = new System.Drawing.Point(63, 49);
            this.textBoxAuthPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAuthPass.Name = "textBoxAuthPass";
            this.textBoxAuthPass.PasswordChar = '*';
            this.textBoxAuthPass.Size = new System.Drawing.Size(107, 20);
            this.textBoxAuthPass.TabIndex = 4;
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(11, 77);
            this.buttonAuth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(97, 41);
            this.buttonAuth.TabIndex = 5;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // buttonAuthGuest
            // 
            this.buttonAuthGuest.Location = new System.Drawing.Point(112, 77);
            this.buttonAuthGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAuthGuest.Name = "buttonAuthGuest";
            this.buttonAuthGuest.Size = new System.Drawing.Size(97, 41);
            this.buttonAuthGuest.TabIndex = 6;
            this.buttonAuthGuest.Text = "Войти как гость";
            this.buttonAuthGuest.UseVisualStyleBackColor = true;
            this.buttonAuthGuest.Click += new System.EventHandler(this.buttonAuthGuest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(449, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 133);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAuthGuest);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.textBoxAuthPass);
            this.Controls.Add(this.labelAuthPass);
            this.Controls.Add(this.textBoxAuthLogin);
            this.Controls.Add(this.labelAuthLogin);
            this.Controls.Add(this.labelAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AuthForm";
            this.Text = "Реестр объявлений о пропаже животных - Вход и регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelAuthLogin;
        private System.Windows.Forms.TextBox textBoxAuthLogin;
        private System.Windows.Forms.Label labelAuthPass;
        private System.Windows.Forms.TextBox textBoxAuthPass;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Button buttonAuthGuest;
        private System.Windows.Forms.Label label1;
    }
}

