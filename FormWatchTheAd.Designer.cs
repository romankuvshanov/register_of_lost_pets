
namespace PIS_20_01
{
    partial class FormWatchTheAd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.labelAnimalPasport = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAnimalBreed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAnimalCategory = new System.Windows.Forms.Label();
            this.buttonRespond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(565, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ФИО владельца домашнего животного: Интизанова Софья Николаевна";
            // 
            // labelAnimalPasport
            // 
            this.labelAnimalPasport.AutoSize = true;
            this.labelAnimalPasport.Location = new System.Drawing.Point(10, 215);
            this.labelAnimalPasport.Name = "labelAnimalPasport";
            this.labelAnimalPasport.Size = new System.Drawing.Size(376, 20);
            this.labelAnimalPasport.TabIndex = 18;
            this.labelAnimalPasport.Text = " Номер паспорта домашнего животного: 123456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Дата регистрации животного: 01.10.2022";
            // 
            // labelAnimalBreed
            // 
            this.labelAnimalBreed.AutoSize = true;
            this.labelAnimalBreed.Location = new System.Drawing.Point(12, 129);
            this.labelAnimalBreed.Name = "labelAnimalBreed";
            this.labelAnimalBreed.Size = new System.Drawing.Size(150, 20);
            this.labelAnimalBreed.TabIndex = 16;
            this.labelAnimalBreed.Text = "Порода: Сиамская";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Дата рождения: 08.10.2018";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя животного: Фея";
            // 
            // labelAnimalCategory
            // 
            this.labelAnimalCategory.AutoSize = true;
            this.labelAnimalCategory.Location = new System.Drawing.Point(12, 9);
            this.labelAnimalCategory.Name = "labelAnimalCategory";
            this.labelAnimalCategory.Size = new System.Drawing.Size(231, 20);
            this.labelAnimalCategory.TabIndex = 13;
            this.labelAnimalCategory.Text = "Категория животного: Кошка";
            // 
            // buttonRespond
            // 
            this.buttonRespond.Location = new System.Drawing.Point(16, 283);
            this.buttonRespond.Name = "buttonRespond";
            this.buttonRespond.Size = new System.Drawing.Size(212, 54);
            this.buttonRespond.TabIndex = 20;
            this.buttonRespond.Text = "Откликнуться";
            this.buttonRespond.UseVisualStyleBackColor = true;
            this.buttonRespond.Click += new System.EventHandler(this.buttonRespond_Click);
            // 
            // FormWatchTheAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRespond);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAnimalPasport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAnimalBreed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAnimalCategory);
            this.Name = "FormWatchTheAd";
            this.Text = "Просмотр объявления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAnimalPasport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAnimalBreed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAnimalCategory;
        private System.Windows.Forms.Button buttonRespond;
    }
}