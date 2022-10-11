
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWatchTheAd));
            this.labelOwnersName = new System.Windows.Forms.Label();
            this.labelAnimalPasport = new System.Windows.Forms.Label();
            this.labelAnimalRegDate = new System.Windows.Forms.Label();
            this.labelAnimalBreed = new System.Windows.Forms.Label();
            this.labelAnimalBirthDay = new System.Windows.Forms.Label();
            this.labelAnimalName = new System.Windows.Forms.Label();
            this.labelAnimalCategory = new System.Windows.Forms.Label();
            this.buttonRespond = new System.Windows.Forms.Button();
            this.labelWatchAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOwnersName
            // 
            this.labelOwnersName.AutoSize = true;
            this.labelOwnersName.Location = new System.Drawing.Point(12, 314);
            this.labelOwnersName.Name = "labelOwnersName";
            this.labelOwnersName.Size = new System.Drawing.Size(565, 20);
            this.labelOwnersName.TabIndex = 19;
            this.labelOwnersName.Text = "ФИО владельца домашнего животного: Интизанова Софья Николаевна";
            // 
            // labelAnimalPasport
            // 
            this.labelAnimalPasport.AutoSize = true;
            this.labelAnimalPasport.Location = new System.Drawing.Point(12, 273);
            this.labelAnimalPasport.Name = "labelAnimalPasport";
            this.labelAnimalPasport.Size = new System.Drawing.Size(372, 20);
            this.labelAnimalPasport.TabIndex = 18;
            this.labelAnimalPasport.Text = "Номер паспорта домашнего животного: 123456";
            // 
            // labelAnimalRegDate
            // 
            this.labelAnimalRegDate.AutoSize = true;
            this.labelAnimalRegDate.Location = new System.Drawing.Point(12, 232);
            this.labelAnimalRegDate.Name = "labelAnimalRegDate";
            this.labelAnimalRegDate.Size = new System.Drawing.Size(321, 20);
            this.labelAnimalRegDate.TabIndex = 17;
            this.labelAnimalRegDate.Text = "Дата регистрации животного: 01.10.2022";
            // 
            // labelAnimalBreed
            // 
            this.labelAnimalBreed.AutoSize = true;
            this.labelAnimalBreed.Location = new System.Drawing.Point(12, 191);
            this.labelAnimalBreed.Name = "labelAnimalBreed";
            this.labelAnimalBreed.Size = new System.Drawing.Size(150, 20);
            this.labelAnimalBreed.TabIndex = 16;
            this.labelAnimalBreed.Text = "Порода: Сиамская";
            // 
            // labelAnimalBirthDay
            // 
            this.labelAnimalBirthDay.AutoSize = true;
            this.labelAnimalBirthDay.Location = new System.Drawing.Point(12, 150);
            this.labelAnimalBirthDay.Name = "labelAnimalBirthDay";
            this.labelAnimalBirthDay.Size = new System.Drawing.Size(216, 20);
            this.labelAnimalBirthDay.TabIndex = 15;
            this.labelAnimalBirthDay.Text = "Дата рождения: 08.10.2018";
            // 
            // labelAnimalName
            // 
            this.labelAnimalName.AutoSize = true;
            this.labelAnimalName.Location = new System.Drawing.Point(12, 109);
            this.labelAnimalName.Name = "labelAnimalName";
            this.labelAnimalName.Size = new System.Drawing.Size(166, 20);
            this.labelAnimalName.TabIndex = 14;
            this.labelAnimalName.Text = "Имя животного: Фея";
            // 
            // labelAnimalCategory
            // 
            this.labelAnimalCategory.AutoSize = true;
            this.labelAnimalCategory.Location = new System.Drawing.Point(12, 68);
            this.labelAnimalCategory.Name = "labelAnimalCategory";
            this.labelAnimalCategory.Size = new System.Drawing.Size(231, 20);
            this.labelAnimalCategory.TabIndex = 13;
            this.labelAnimalCategory.Text = "Категория животного: Кошка";
            // 
            // buttonRespond
            // 
            this.buttonRespond.Location = new System.Drawing.Point(12, 349);
            this.buttonRespond.Name = "buttonRespond";
            this.buttonRespond.Size = new System.Drawing.Size(212, 54);
            this.buttonRespond.TabIndex = 20;
            this.buttonRespond.Text = "Откликнуться";
            this.buttonRespond.UseVisualStyleBackColor = true;
            this.buttonRespond.Click += new System.EventHandler(this.buttonRespond_Click);
            // 
            // labelWatchAd
            // 
            this.labelWatchAd.AutoSize = true;
            this.labelWatchAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWatchAd.Location = new System.Drawing.Point(12, 9);
            this.labelWatchAd.Name = "labelWatchAd";
            this.labelWatchAd.Size = new System.Drawing.Size(295, 29);
            this.labelWatchAd.TabIndex = 21;
            this.labelWatchAd.Text = "Просмотр объявления";
            // 
            // FormWatchTheAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWatchAd);
            this.Controls.Add(this.buttonRespond);
            this.Controls.Add(this.labelOwnersName);
            this.Controls.Add(this.labelAnimalPasport);
            this.Controls.Add(this.labelAnimalRegDate);
            this.Controls.Add(this.labelAnimalBreed);
            this.Controls.Add(this.labelAnimalBirthDay);
            this.Controls.Add(this.labelAnimalName);
            this.Controls.Add(this.labelAnimalCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormWatchTheAd";
            this.Text = "Реестр объявлений о пропаже животных - Просмотр объявления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOwnersName;
        private System.Windows.Forms.Label labelAnimalPasport;
        private System.Windows.Forms.Label labelAnimalRegDate;
        private System.Windows.Forms.Label labelAnimalBreed;
        private System.Windows.Forms.Label labelAnimalBirthDay;
        private System.Windows.Forms.Label labelAnimalName;
        private System.Windows.Forms.Label labelAnimalCategory;
        private System.Windows.Forms.Button buttonRespond;
        private System.Windows.Forms.Label labelWatchAd;
    }
}