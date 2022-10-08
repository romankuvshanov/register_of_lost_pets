
namespace PIS_20_01
{
    partial class MainForm
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
            this.buttonMyAds = new System.Windows.Forms.Button();
            this.buttonAllAds = new System.Windows.Forms.Button();
            this.buttonNewAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMyAds
            // 
            this.buttonMyAds.Location = new System.Drawing.Point(495, 429);
            this.buttonMyAds.Name = "buttonMyAds";
            this.buttonMyAds.Size = new System.Drawing.Size(183, 75);
            this.buttonMyAds.TabIndex = 0;
            this.buttonMyAds.Text = "Мои объявления";
            this.buttonMyAds.UseVisualStyleBackColor = true;
            this.buttonMyAds.Visible = false;
            this.buttonMyAds.Click += new System.EventHandler(this.buttonMyAds_Click);
            // 
            // buttonAllAds
            // 
            this.buttonAllAds.Location = new System.Drawing.Point(12, 12);
            this.buttonAllAds.Name = "buttonAllAds";
            this.buttonAllAds.Size = new System.Drawing.Size(184, 75);
            this.buttonAllAds.TabIndex = 1;
            this.buttonAllAds.Text = "Все объявления";
            this.buttonAllAds.UseVisualStyleBackColor = true;
            this.buttonAllAds.Click += new System.EventHandler(this.buttonAllAds_Click);
            // 
            // buttonNewAd
            // 
            this.buttonNewAd.Location = new System.Drawing.Point(495, 348);
            this.buttonNewAd.Name = "buttonNewAd";
            this.buttonNewAd.Size = new System.Drawing.Size(183, 75);
            this.buttonNewAd.TabIndex = 2;
            this.buttonNewAd.Text = "Подать объявление";
            this.buttonNewAd.UseVisualStyleBackColor = true;
            this.buttonNewAd.Visible = false;
            this.buttonNewAd.Click += new System.EventHandler(this.buttonNewAd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 516);
            this.Controls.Add(this.buttonNewAd);
            this.Controls.Add(this.buttonAllAds);
            this.Controls.Add(this.buttonMyAds);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMyAds;
        private System.Windows.Forms.Button buttonAllAds;
        private System.Windows.Forms.Button buttonNewAd;
    }
}