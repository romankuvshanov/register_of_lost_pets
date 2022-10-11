
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.labelAuth = new System.Windows.Forms.Label();
            this.labelAuthLogin = new System.Windows.Forms.Label();
            this.textBoxAuthLogin = new System.Windows.Forms.TextBox();
            this.labelAuthPass = new System.Windows.Forms.Label();
            this.textBoxAuthPass = new System.Windows.Forms.TextBox();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.buttonAuthGuest = new System.Windows.Forms.Button();
            this.labelExitCross = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(11, 8);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(177, 29);
            this.labelAuth.TabIndex = 0;
            this.labelAuth.Text = "Авторизация";
            // 
            // labelAuthLogin
            // 
            this.labelAuthLogin.AutoSize = true;
            this.labelAuthLogin.Location = new System.Drawing.Point(12, 54);
            this.labelAuthLogin.Name = "labelAuthLogin";
            this.labelAuthLogin.Size = new System.Drawing.Size(59, 20);
            this.labelAuthLogin.TabIndex = 1;
            this.labelAuthLogin.Text = "Логин:";
            // 
            // textBoxAuthLogin
            // 
            this.textBoxAuthLogin.Location = new System.Drawing.Point(89, 48);
            this.textBoxAuthLogin.Name = "textBoxAuthLogin";
            this.textBoxAuthLogin.Size = new System.Drawing.Size(155, 26);
            this.textBoxAuthLogin.TabIndex = 2;
            // 
            // labelAuthPass
            // 
            this.labelAuthPass.AutoSize = true;
            this.labelAuthPass.Location = new System.Drawing.Point(12, 86);
            this.labelAuthPass.Name = "labelAuthPass";
            this.labelAuthPass.Size = new System.Drawing.Size(71, 20);
            this.labelAuthPass.TabIndex = 3;
            this.labelAuthPass.Text = "Пароль:";
            // 
            // textBoxAuthPass
            // 
            this.textBoxAuthPass.Location = new System.Drawing.Point(89, 80);
            this.textBoxAuthPass.Name = "textBoxAuthPass";
            this.textBoxAuthPass.PasswordChar = '*';
            this.textBoxAuthPass.Size = new System.Drawing.Size(155, 26);
            this.textBoxAuthPass.TabIndex = 4;
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(12, 122);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(146, 63);
            this.buttonAuth.TabIndex = 5;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // buttonAuthGuest
            // 
            this.buttonAuthGuest.Location = new System.Drawing.Point(164, 122);
            this.buttonAuthGuest.Name = "buttonAuthGuest";
            this.buttonAuthGuest.Size = new System.Drawing.Size(146, 63);
            this.buttonAuthGuest.TabIndex = 6;
            this.buttonAuthGuest.Text = "Войти как гость";
            this.buttonAuthGuest.UseVisualStyleBackColor = true;
            this.buttonAuthGuest.Click += new System.EventHandler(this.buttonAuthGuest_Click);
            // 
            // labelExitCross
            // 
            this.labelExitCross.AutoSize = true;
            this.labelExitCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExitCross.Location = new System.Drawing.Point(658, 8);
            this.labelExitCross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExitCross.Name = "labelExitCross";
            this.labelExitCross.Size = new System.Drawing.Size(39, 37);
            this.labelExitCross.TabIndex = 7;
            this.labelExitCross.Text = "X";
            this.labelExitCross.Click += new System.EventHandler(this.labelExitCross_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 244);
            this.ControlBox = false;
            this.Controls.Add(this.labelExitCross);
            this.Controls.Add(this.buttonAuthGuest);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.textBoxAuthPass);
            this.Controls.Add(this.labelAuthPass);
            this.Controls.Add(this.textBoxAuthLogin);
            this.Controls.Add(this.labelAuthLogin);
            this.Controls.Add(this.labelAuth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.Text = "Реестр объявлений о пропаже животных - Авторизация";
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
        private System.Windows.Forms.Label labelExitCross;
    }
}

