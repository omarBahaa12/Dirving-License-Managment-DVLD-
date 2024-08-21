namespace DVLD_UITier.International_License
{
    partial class FrmAddInternationalLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Link_LicensePersonHistory = new System.Windows.Forms.LinkLabel();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.Chip_Issue = new Guna.UI2.WinForms.Guna2Chip();
            this.ucDetailInternationalLicense1 = new DVLD_UITier.UserControls.UCDetailInternationalLicense();
            this.ucLicenseInfo1 = new DVLD_UITier.UserControls.UCLicenseInfo();
            this.ucFindByLocalLicense1 = new DVLD_UITier.UserControls.UCFindByLocalLicense();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "International License Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "License Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Application Info";
            // 
            // Link_LicensePersonHistory
            // 
            this.Link_LicensePersonHistory.AutoSize = true;
            this.Link_LicensePersonHistory.Enabled = false;
            this.Link_LicensePersonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_LicensePersonHistory.Location = new System.Drawing.Point(69, 883);
            this.Link_LicensePersonHistory.Name = "Link_LicensePersonHistory";
            this.Link_LicensePersonHistory.Size = new System.Drawing.Size(204, 18);
            this.Link_LicensePersonHistory.TabIndex = 7;
            this.Link_LicensePersonHistory.TabStop = true;
            this.Link_LicensePersonHistory.Text = "Show License Person History";
            this.Link_LicensePersonHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LicensePersonHistory_LinkClicked);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(517, 870);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(139, 45);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Chip_Issue
            // 
            this.Chip_Issue.AutoRoundedCorners = true;
            this.Chip_Issue.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Chip_Issue.BorderRadius = 21;
            this.Chip_Issue.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Chip_Issue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chip_Issue.ForeColor = System.Drawing.Color.White;
            this.Chip_Issue.Location = new System.Drawing.Point(805, 870);
            this.Chip_Issue.Name = "Chip_Issue";
            this.Chip_Issue.Size = new System.Drawing.Size(130, 45);
            this.Chip_Issue.TabIndex = 9;
            this.Chip_Issue.Text = "Issue";
            this.Chip_Issue.Click += new System.EventHandler(this.Chip_Issue_Click);
            // 
            // ucDetailInternationalLicense1
            // 
            this.ucDetailInternationalLicense1.Location = new System.Drawing.Point(2, 620);
            this.ucDetailInternationalLicense1.Name = "ucDetailInternationalLicense1";
            this.ucDetailInternationalLicense1.Size = new System.Drawing.Size(917, 225);
            this.ucDetailInternationalLicense1.TabIndex = 3;
            // 
            // ucLicenseInfo1
            // 
            this.ucLicenseInfo1.Location = new System.Drawing.Point(2, 56);
            this.ucLicenseInfo1.Name = "ucLicenseInfo1";
            this.ucLicenseInfo1.Size = new System.Drawing.Size(873, 540);
            this.ucLicenseInfo1.TabIndex = 2;
            // 
            // ucFindByLocalLicense1
            // 
            this.ucFindByLocalLicense1.Location = new System.Drawing.Point(557, -1);
            this.ucFindByLocalLicense1.Name = "ucFindByLocalLicense1";
            this.ucFindByLocalLicense1.Size = new System.Drawing.Size(431, 54);
            this.ucFindByLocalLicense1.TabIndex = 0;
            // 
            // FrmAddInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 934);
            this.Controls.Add(this.Chip_Issue);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Link_LicensePersonHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucDetailInternationalLicense1);
            this.Controls.Add(this.ucLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucFindByLocalLicense1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add International License";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAddInternationalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UCFindByLocalLicense ucFindByLocalLicense1;
        private System.Windows.Forms.Label label1;
        private UserControls.UCLicenseInfo ucLicenseInfo1;
        private UserControls.UCDetailInternationalLicense ucDetailInternationalLicense1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Link_LicensePersonHistory;
        private Guna.UI2.WinForms.Guna2Button Btn_Close;
        private Guna.UI2.WinForms.Guna2Chip Chip_Issue;
    }
}