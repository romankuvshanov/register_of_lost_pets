﻿
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
            this.labelAllAds = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewAllAds = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonNewAd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAds)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAllAds
            // 
            this.labelAllAds.AutoSize = true;
            this.labelAllAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllAds.Location = new System.Drawing.Point(2, 14);
            this.labelAllAds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAllAds.Name = "labelAllAds";
            this.labelAllAds.Size = new System.Drawing.Size(147, 22);
            this.labelAllAds.TabIndex = 0;
            this.labelAllAds.Text = "Все объявления";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.labelAllAds);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 42);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(384, 8);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Отображать только мои";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewAllAds);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 250);
            this.panel2.TabIndex = 2;
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
            this.dataGridViewAllAds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAllAds.Name = "dataGridViewAllAds";
            this.dataGridViewAllAds.RowHeadersVisible = false;
            this.dataGridViewAllAds.RowHeadersWidth = 62;
            this.dataGridViewAllAds.RowTemplate.Height = 28;
            this.dataGridViewAllAds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllAds.Size = new System.Drawing.Size(533, 206);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonNewAd);
            this.panel3.Controls.Add(this.buttonDel);
            this.panel3.Controls.Add(this.buttonEdit);
            this.panel3.Controls.Add(this.buttonOpen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 206);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 44);
            this.panel3.TabIndex = 0;
            // 
            // buttonNewAd
            // 
            this.buttonNewAd.Location = new System.Drawing.Point(269, 4);
            this.buttonNewAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNewAd.Name = "buttonNewAd";
            this.buttonNewAd.Size = new System.Drawing.Size(122, 31);
            this.buttonNewAd.TabIndex = 3;
            this.buttonNewAd.Text = "Подать объявление";
            this.buttonNewAd.UseVisualStyleBackColor = true;
            this.buttonNewAd.Click += new System.EventHandler(this.buttonNewAd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(181, 2);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(84, 33);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(93, 2);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 33);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(5, 3);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(84, 33);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // AllAdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AllAdsForm";
            this.Text = "Все объвления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AllAdsForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAllAds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewAllAds;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonNewAd;
    }
}