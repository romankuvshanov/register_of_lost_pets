
namespace PIS_20_01
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(12, 9);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(68, 29);
            this.labelAuth.TabIndex = 0;
            this.labelAuth.Text = "Вход";
            // 
            // labelAuthLogin
            // 
            this.labelAuthLogin.AutoSize = true;
            this.labelAuthLogin.Location = new System.Drawing.Point(17, 42);
            this.labelAuthLogin.Name = "labelAuthLogin";
            this.labelAuthLogin.Size = new System.Drawing.Size(59, 20);
            this.labelAuthLogin.TabIndex = 1;
            this.labelAuthLogin.Text = "Логин:";
            // 
            // textBoxAuthLogin
            // 
            this.textBoxAuthLogin.Location = new System.Drawing.Point(94, 42);
            this.textBoxAuthLogin.Name = "textBoxAuthLogin";
            this.textBoxAuthLogin.Size = new System.Drawing.Size(160, 26);
            this.textBoxAuthLogin.TabIndex = 2;
            // 
            // labelAuthPass
            // 
            this.labelAuthPass.AutoSize = true;
            this.labelAuthPass.Location = new System.Drawing.Point(17, 80);
            this.labelAuthPass.Name = "labelAuthPass";
            this.labelAuthPass.Size = new System.Drawing.Size(71, 20);
            this.labelAuthPass.TabIndex = 3;
            this.labelAuthPass.Text = "Пароль:";
            // 
            // textBoxAuthPass
            // 
            this.textBoxAuthPass.Location = new System.Drawing.Point(95, 75);
            this.textBoxAuthPass.Name = "textBoxAuthPass";
            this.textBoxAuthPass.Size = new System.Drawing.Size(159, 26);
            this.textBoxAuthPass.TabIndex = 4;
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(17, 118);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(146, 63);
            this.buttonAuth.TabIndex = 5;
            this.buttonAuth.Text = "Войти";
            this.buttonAuth.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 287);
            this.Controls.Add(this.buttonAuth);
            this.Controls.Add(this.textBoxAuthPass);
            this.Controls.Add(this.labelAuthPass);
            this.Controls.Add(this.textBoxAuthLogin);
            this.Controls.Add(this.labelAuthLogin);
            this.Controls.Add(this.labelAuth);
            this.Name = "Form1";
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
    }
}

