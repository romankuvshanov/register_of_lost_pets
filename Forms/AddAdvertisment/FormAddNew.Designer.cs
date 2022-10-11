
namespace PIS_20_01
{
    partial class FormAddNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNew));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelFields = new System.Windows.Forms.Label();
            this.labelNewAd = new System.Windows.Forms.Label();
            this.dateTimePickerAnimalRegDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAnimalBirthDay = new System.Windows.Forms.DateTimePicker();
            this.textBoxOwnersName = new System.Windows.Forms.TextBox();
            this.labelOwnersName = new System.Windows.Forms.Label();
            this.textBoxAnimalPasportNumber = new System.Windows.Forms.TextBox();
            this.labelAnimalPasport = new System.Windows.Forms.Label();
            this.labelAnimalRegDate = new System.Windows.Forms.Label();
            this.textBoxAnimalBreed = new System.Windows.Forms.TextBox();
            this.labelAnimalBreed = new System.Windows.Forms.Label();
            this.labelAnimalBirthDay = new System.Windows.Forms.Label();
            this.textBoxAnimalName = new System.Windows.Forms.TextBox();
            this.labelAnimalName = new System.Windows.Forms.Label();
            this.textBoxAnimalCategory = new System.Windows.Forms.TextBox();
            this.labelAnimalCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 61);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelFields
            // 
            this.labelFields.AutoSize = true;
            this.labelFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFields.Location = new System.Drawing.Point(14, 38);
            this.labelFields.Name = "labelFields";
            this.labelFields.Size = new System.Drawing.Size(366, 15);
            this.labelFields.TabIndex = 33;
            this.labelFields.Text = "Поля, выделенные звёздочкой, обязательны для заполнения";
            // 
            // labelNewAd
            // 
            this.labelNewAd.AutoSize = true;
            this.labelNewAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewAd.Location = new System.Drawing.Point(12, 9);
            this.labelNewAd.Name = "labelNewAd";
            this.labelNewAd.Size = new System.Drawing.Size(261, 29);
            this.labelNewAd.TabIndex = 32;
            this.labelNewAd.Text = "Подать объявление";
            // 
            // dateTimePickerAnimalRegDate
            // 
            this.dateTimePickerAnimalRegDate.Location = new System.Drawing.Point(337, 239);
            this.dateTimePickerAnimalRegDate.Name = "dateTimePickerAnimalRegDate";
            this.dateTimePickerAnimalRegDate.Size = new System.Drawing.Size(282, 26);
            this.dateTimePickerAnimalRegDate.TabIndex = 47;
            this.dateTimePickerAnimalRegDate.Value = new System.DateTime(2022, 10, 11, 0, 0, 0, 0);
            // 
            // dateTimePickerAnimalBirthDay
            // 
            this.dateTimePickerAnimalBirthDay.Location = new System.Drawing.Point(337, 157);
            this.dateTimePickerAnimalBirthDay.Name = "dateTimePickerAnimalBirthDay";
            this.dateTimePickerAnimalBirthDay.Size = new System.Drawing.Size(282, 26);
            this.dateTimePickerAnimalBirthDay.TabIndex = 46;
            this.dateTimePickerAnimalBirthDay.Value = new System.DateTime(2022, 10, 11, 0, 0, 0, 0);
            // 
            // textBoxOwnersName
            // 
            this.textBoxOwnersName.Location = new System.Drawing.Point(337, 321);
            this.textBoxOwnersName.Name = "textBoxOwnersName";
            this.textBoxOwnersName.Size = new System.Drawing.Size(282, 26);
            this.textBoxOwnersName.TabIndex = 45;
            // 
            // labelOwnersName
            // 
            this.labelOwnersName.AutoSize = true;
            this.labelOwnersName.Location = new System.Drawing.Point(13, 324);
            this.labelOwnersName.Name = "labelOwnersName";
            this.labelOwnersName.Size = new System.Drawing.Size(318, 20);
            this.labelOwnersName.TabIndex = 44;
            this.labelOwnersName.Text = "ФИО владельца домашнего животного*";
            // 
            // textBoxAnimalPasportNumber
            // 
            this.textBoxAnimalPasportNumber.Location = new System.Drawing.Point(337, 280);
            this.textBoxAnimalPasportNumber.Name = "textBoxAnimalPasportNumber";
            this.textBoxAnimalPasportNumber.Size = new System.Drawing.Size(282, 26);
            this.textBoxAnimalPasportNumber.TabIndex = 43;
            // 
            // labelAnimalPasport
            // 
            this.labelAnimalPasport.AutoSize = true;
            this.labelAnimalPasport.Location = new System.Drawing.Point(13, 283);
            this.labelAnimalPasport.Name = "labelAnimalPasport";
            this.labelAnimalPasport.Size = new System.Drawing.Size(316, 20);
            this.labelAnimalPasport.TabIndex = 42;
            this.labelAnimalPasport.Text = "Номер паспорта домашнего животного*";
            // 
            // labelAnimalRegDate
            // 
            this.labelAnimalRegDate.AutoSize = true;
            this.labelAnimalRegDate.Location = new System.Drawing.Point(13, 242);
            this.labelAnimalRegDate.Name = "labelAnimalRegDate";
            this.labelAnimalRegDate.Size = new System.Drawing.Size(239, 20);
            this.labelAnimalRegDate.TabIndex = 41;
            this.labelAnimalRegDate.Text = "Дата регистрации животного*";
            // 
            // textBoxAnimalBreed
            // 
            this.textBoxAnimalBreed.Location = new System.Drawing.Point(337, 198);
            this.textBoxAnimalBreed.Name = "textBoxAnimalBreed";
            this.textBoxAnimalBreed.Size = new System.Drawing.Size(282, 26);
            this.textBoxAnimalBreed.TabIndex = 40;
            // 
            // labelAnimalBreed
            // 
            this.labelAnimalBreed.AutoSize = true;
            this.labelAnimalBreed.Location = new System.Drawing.Point(13, 201);
            this.labelAnimalBreed.Name = "labelAnimalBreed";
            this.labelAnimalBreed.Size = new System.Drawing.Size(74, 20);
            this.labelAnimalBreed.TabIndex = 39;
            this.labelAnimalBreed.Text = "Порода*";
            // 
            // labelAnimalBirthDay
            // 
            this.labelAnimalBirthDay.AutoSize = true;
            this.labelAnimalBirthDay.Location = new System.Drawing.Point(13, 160);
            this.labelAnimalBirthDay.Name = "labelAnimalBirthDay";
            this.labelAnimalBirthDay.Size = new System.Drawing.Size(134, 20);
            this.labelAnimalBirthDay.TabIndex = 38;
            this.labelAnimalBirthDay.Text = "Дата рождения*";
            // 
            // textBoxAnimalName
            // 
            this.textBoxAnimalName.Location = new System.Drawing.Point(337, 116);
            this.textBoxAnimalName.Name = "textBoxAnimalName";
            this.textBoxAnimalName.Size = new System.Drawing.Size(282, 26);
            this.textBoxAnimalName.TabIndex = 37;
            // 
            // labelAnimalName
            // 
            this.labelAnimalName.AutoSize = true;
            this.labelAnimalName.Location = new System.Drawing.Point(13, 119);
            this.labelAnimalName.Name = "labelAnimalName";
            this.labelAnimalName.Size = new System.Drawing.Size(131, 20);
            this.labelAnimalName.TabIndex = 36;
            this.labelAnimalName.Text = "Имя животного*";
            // 
            // textBoxAnimalCategory
            // 
            this.textBoxAnimalCategory.Location = new System.Drawing.Point(337, 75);
            this.textBoxAnimalCategory.Name = "textBoxAnimalCategory";
            this.textBoxAnimalCategory.Size = new System.Drawing.Size(282, 26);
            this.textBoxAnimalCategory.TabIndex = 35;
            // 
            // labelAnimalCategory
            // 
            this.labelAnimalCategory.AutoSize = true;
            this.labelAnimalCategory.Location = new System.Drawing.Point(13, 78);
            this.labelAnimalCategory.Name = "labelAnimalCategory";
            this.labelAnimalCategory.Size = new System.Drawing.Size(180, 20);
            this.labelAnimalCategory.TabIndex = 34;
            this.labelAnimalCategory.Text = "Категория животного*";
            // 
            // FormAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 468);
            this.Controls.Add(this.dateTimePickerAnimalRegDate);
            this.Controls.Add(this.dateTimePickerAnimalBirthDay);
            this.Controls.Add(this.textBoxOwnersName);
            this.Controls.Add(this.labelOwnersName);
            this.Controls.Add(this.textBoxAnimalPasportNumber);
            this.Controls.Add(this.labelAnimalPasport);
            this.Controls.Add(this.labelAnimalRegDate);
            this.Controls.Add(this.textBoxAnimalBreed);
            this.Controls.Add(this.labelAnimalBreed);
            this.Controls.Add(this.labelAnimalBirthDay);
            this.Controls.Add(this.textBoxAnimalName);
            this.Controls.Add(this.labelAnimalName);
            this.Controls.Add(this.textBoxAnimalCategory);
            this.Controls.Add(this.labelAnimalCategory);
            this.Controls.Add(this.labelFields);
            this.Controls.Add(this.labelNewAd);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddNew";
            this.Text = "Реестр объявлений о пропаже животных - Подать объявление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelFields;
        private System.Windows.Forms.Label labelNewAd;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnimalRegDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnimalBirthDay;
        private System.Windows.Forms.TextBox textBoxOwnersName;
        private System.Windows.Forms.Label labelOwnersName;
        private System.Windows.Forms.TextBox textBoxAnimalPasportNumber;
        private System.Windows.Forms.Label labelAnimalPasport;
        private System.Windows.Forms.Label labelAnimalRegDate;
        private System.Windows.Forms.TextBox textBoxAnimalBreed;
        private System.Windows.Forms.Label labelAnimalBreed;
        private System.Windows.Forms.Label labelAnimalBirthDay;
        private System.Windows.Forms.TextBox textBoxAnimalName;
        private System.Windows.Forms.Label labelAnimalName;
        private System.Windows.Forms.TextBox textBoxAnimalCategory;
        private System.Windows.Forms.Label labelAnimalCategory;
    }
}