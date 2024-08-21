namespace DVLD_UITier.LocalLicenseOperation
{
    partial class FrmLicensePersonHistory
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
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.ucLicenseHistory1 = new DVLD_UITier.UserControls.UCLicenseHistory();
            this.ucDetailedInfo1 = new DVLD_UITier.UCDetailedInfo();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(700, 694);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(180, 59);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ucLicenseHistory1
            // 
            this.ucLicenseHistory1.Location = new System.Drawing.Point(-9, 411);
            this.ucLicenseHistory1.Name = "ucLicenseHistory1";
            this.ucLicenseHistory1.Size = new System.Drawing.Size(1131, 254);
            this.ucLicenseHistory1.TabIndex = 1;
            // 
            // ucDetailedInfo1
            // 
            this.ucDetailedInfo1.ID = 0;
            this.ucDetailedInfo1.Location = new System.Drawing.Point(193, 0);
            this.ucDetailedInfo1.Name = "ucDetailedInfo1";
            this.ucDetailedInfo1.Size = new System.Drawing.Size(906, 405);
            this.ucDetailedInfo1.TabIndex = 0;
            // 
            // FrmLicensePersonHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 765);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.ucLicenseHistory1);
            this.Controls.Add(this.ucDetailedInfo1);
            this.Name = "FrmLicensePersonHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Person History";
            this.ResumeLayout(false);

        }

        #endregion

        private UCDetailedInfo ucDetailedInfo1;
        private UserControls.UCLicenseHistory ucLicenseHistory1;
        private Guna.UI2.WinForms.Guna2Button Btn_Close;
    }
}