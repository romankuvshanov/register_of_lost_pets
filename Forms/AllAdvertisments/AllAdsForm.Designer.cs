
namespace PIS_20_01
{
    partial class AllAdsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAdsForm));
            this.labelAllAds = new System.Windows.Forms.Label();
            this.panelTopHeadlineCheckbox = new System.Windows.Forms.Panel();
            this.panelCheckboxTop = new System.Windows.Forms.Panel();
            this.checkBoxMyAdsOnly = new System.Windows.Forms.CheckBox();
            this.panelDataGridViewMiddle = new System.Windows.Forms.Panel();
            this.dataGridViewAllAds = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottomButtons = new System.Windows.Forms.Panel();
            this.buttonNewAd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelTopHeadlineCheckbox.SuspendLayout();
            this.panelCheckboxTop.SuspendLayout();
            this.panelDataGridViewMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAds)).BeginInit();
            this.panelBottomButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAllAds
            // 
            this.labelAllAds.AutoSize = true;
            this.labelAllAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllAds.Location = new System.Drawing.Point(3, 22);
            this.labelAllAds.Name = "labelAllAds";
            this.labelAllAds.Size = new System.Drawing.Size(223, 30);
            this.labelAllAds.TabIndex = 0;
            this.labelAllAds.Text = "Все объявления";
            // 
            // panelTopHeadlineCheckbox
            // 
            this.panelTopHeadlineCheckbox.Controls.Add(this.panelCheckboxTop);
            this.panelTopHeadlineCheckbox.Controls.Add(this.labelAllAds);
            this.panelTopHeadlineCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopHeadlineCheckbox.Location = new System.Drawing.Point(0, 0);
            this.panelTopHeadlineCheckbox.Name = "panelTopHeadlineCheckbox";
            this.panelTopHeadlineCheckbox.Size = new System.Drawing.Size(1067, 65);
            this.panelTopHeadlineCheckbox.TabIndex = 1;
            // 
            // panelCheckboxTop
            // 
            this.panelCheckboxTop.Controls.Add(this.checkBoxMyAdsOnly);
            this.panelCheckboxTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCheckboxTop.Location = new System.Drawing.Point(724, 0);
            this.panelCheckboxTop.Name = "panelCheckboxTop";
            this.panelCheckboxTop.Size = new System.Drawing.Size(343, 65);
            this.panelCheckboxTop.TabIndex = 2;
            // 
            // checkBoxMyAdsOnly
            // 
            this.checkBoxMyAdsOnly.AutoSize = true;
            this.checkBoxMyAdsOnly.Location = new System.Drawing.Point(22, 30);
            this.checkBoxMyAdsOnly.Name = "checkBoxMyAdsOnly";
            this.checkBoxMyAdsOnly.Size = new System.Drawing.Size(318, 24);
            this.checkBoxMyAdsOnly.TabIndex = 1;
            this.checkBoxMyAdsOnly.Text = "Отображать только мои объявления";
            this.checkBoxMyAdsOnly.UseVisualStyleBackColor = true;
            // 
            // panelDataGridViewMiddle
            // 
            this.panelDataGridViewMiddle.Controls.Add(this.dataGridViewAllAds);
            this.panelDataGridViewMiddle.Controls.Add(this.panelBottomButtons);
            this.panelDataGridViewMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridViewMiddle.Location = new System.Drawing.Point(0, 65);
            this.panelDataGridViewMiddle.Name = "panelDataGridViewMiddle";
            this.panelDataGridViewMiddle.Size = new System.Drawing.Size(1067, 492);
            this.panelDataGridViewMiddle.TabIndex = 2;
            // 
            // dataGridViewAllAds
            // 
            this.dataGridViewAllAds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllAds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllAds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName});
            this.dataGridViewAllAds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllAds.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllAds.Name = "dataGridViewAllAds";
            this.dataGridViewAllAds.RowHeadersVisible = false;
            this.dataGridViewAllAds.RowHeadersWidth = 62;
            this.dataGridViewAllAds.RowTemplate.Height = 28;
            this.dataGridViewAllAds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllAds.Size = new System.Drawing.Size(1067, 424);
            this.dataGridViewAllAds.TabIndex = 1;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            // 
            // panelBottomButtons
            // 
            this.panelBottomButtons.Controls.Add(this.buttonNewAd);
            this.panelBottomButtons.Controls.Add(this.buttonDel);
            this.panelBottomButtons.Controls.Add(this.buttonEdit);
            this.panelBottomButtons.Controls.Add(this.buttonOpen);
            this.panelBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomButtons.Location = new System.Drawing.Point(0, 424);
            this.panelBottomButtons.Name = "panelBottomButtons";
            this.panelBottomButtons.Size = new System.Drawing.Size(1067, 68);
            this.panelBottomButtons.TabIndex = 0;
            // 
            // buttonNewAd
            // 
            this.buttonNewAd.Location = new System.Drawing.Point(404, 5);
            this.buttonNewAd.Name = "buttonNewAd";
            this.buttonNewAd.Size = new System.Drawing.Size(183, 51);
            this.buttonNewAd.TabIndex = 3;
            this.buttonNewAd.Text = "Подать объявление";
            this.buttonNewAd.UseVisualStyleBackColor = true;
            this.buttonNewAd.Click += new System.EventHandler(this.buttonNewAd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(272, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(126, 51);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(140, 5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(126, 51);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(8, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(126, 51);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // AllAdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 557);
            this.Controls.Add(this.panelDataGridViewMiddle);
            this.Controls.Add(this.panelTopHeadlineCheckbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllAdsForm";
            this.Text = "Реестр объявлений о пропаже животных - Все объявления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AllAdsForm_FormClosed);
            this.panelTopHeadlineCheckbox.ResumeLayout(false);
            this.panelTopHeadlineCheckbox.PerformLayout();
            this.panelCheckboxTop.ResumeLayout(false);
            this.panelCheckboxTop.PerformLayout();
            this.panelDataGridViewMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAds)).EndInit();
            this.panelBottomButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAllAds;
        private System.Windows.Forms.Panel panelTopHeadlineCheckbox;
        private System.Windows.Forms.Panel panelDataGridViewMiddle;
        private System.Windows.Forms.DataGridView dataGridViewAllAds;
        private System.Windows.Forms.Panel panelBottomButtons;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.CheckBox checkBoxMyAdsOnly;
        private System.Windows.Forms.Button buttonNewAd;
        private System.Windows.Forms.Panel panelCheckboxTop;
    }
}