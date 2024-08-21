namespace DVLD_UITier.LocalLicenseOperation
{
    partial class FrmRenewLocalLicense
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
            this.Chip_Issue = new Guna.UI2.WinForms.Guna2Chip();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.ucRenewL_License1 = new DVLD_UITier.UserControls.UCRenewL_License();
            this.ucFindByLocalLicense1 = new DVLD_UITier.UserControls.UCFindByLocalLicense();
            this.ucLicenseInfo1 = new DVLD_UITier.UserControls.UCLicenseInfo();
            this.Link_ShowNewLicense = new System.Windows.Forms.LinkLabel();
            this.Link_PersonLicense = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew Local License";
            // 
            // Chip_Issue
            // 
            this.Chip_Issue.AutoRoundedCorners = true;
            this.Chip_Issue.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.Chip_Issue.BorderRadius = 19;
            this.Chip_Issue.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Chip_Issue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chip_Issue.ForeColor = System.Drawing.Color.White;
            this.Chip_Issue.Location = new System.Drawing.Point(780, 871);
            this.Chip_Issue.Name = "Chip_Issue";
            this.Chip_Issue.Size = new System.Drawing.Size(130, 40);
            this.Chip_Issue.TabIndex = 4;
            this.Chip_Issue.Text = "Issue";
            this.Chip_Issue.Click += new System.EventHandler(this.Chip_Issue_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.LightSlateGray;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(434, 871);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(153, 40);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ucRenewL_License1
            // 
            this.ucRenewL_License1.Location = new System.Drawing.Point(12, 441);
            this.ucRenewL_License1.Name = "ucRenewL_License1";
            this.ucRenewL_License1.Size = new System.Drawing.Size(934, 424);
            this.ucRenewL_License1.TabIndex = 3;
            // 
            // ucFindByLocalLicense1
            // 
            this.ucFindByLocalLicense1.Location = new System.Drawing.Point(565, 12);
            this.ucFindByLocalLicense1.Name = "ucFindByLocalLicense1";
            this.ucFindByLocalLicense1.Size = new System.Drawing.Size(420, 53);
            this.ucFindByLocalLicense1.TabIndex = 2;
            // 
            // ucLicenseInfo1
            // 
            this.ucLicenseInfo1.Location = new System.Drawing.Point(1, 59);
            this.ucLicenseInfo1.Name = "ucLicenseInfo1";
            this.ucLicenseInfo1.Size = new System.Drawing.Size(1000, 386);
            this.ucLicenseInfo1.TabIndex = 1;
            // 
            // Link_ShowNewLicense
            // 
            this.Link_ShowNewLicense.AutoSize = true;
            this.Link_ShowNewLicense.Enabled = false;
            this.Link_ShowNewLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_ShowNewLicense.Location = new System.Drawing.Point(205, 895);
            this.Link_ShowNewLicense.Name = "Link_ShowNewLicense";
            this.Link_ShowNewLicense.Size = new System.Drawing.Size(163, 18);
            this.Link_ShowNewLicense.TabIndex = 6;
            this.Link_ShowNewLicense.TabStop = true;
            this.Link_ShowNewLicense.Text = "Show New License Info";
            this.Link_ShowNewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ShowNewLicense_LinkClicked);
            // 
            // Link_PersonLicense
            // 
            this.Link_PersonLicense.AutoSize = true;
            this.Link_PersonLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_PersonLicense.Location = new System.Drawing.Point(9, 895);
            this.Link_PersonLicense.Name = "Link_PersonLicense";
            this.Link_PersonLicense.Size = new System.Drawing.Size(162, 18);
            this.Link_PersonLicense.TabIndex = 7;
            this.Link_PersonLicense.TabStop = true;
            this.Link_PersonLicense.Text = "Person License History";
            this.Link_PersonLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_PersonLicense_LinkClicked);
            // 
            // FrmRenewLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 936);
            this.Controls.Add(this.Link_PersonLicense);
            this.Controls.Add(this.Link_ShowNewLicense);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Chip_Issue);
            this.Controls.Add(this.ucRenewL_License1);
            this.Controls.Add(this.ucFindByLocalLicense1);
            this.Controls.Add(this.ucLicenseInfo1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRenewLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Local License";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRenewLocalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UserControls.UCLicenseInfo ucLicenseInfo1;
        private UserControls.UCFindByLocalLicense ucFindByLocalLicense1;
        private UserControls.UCRenewL_License ucRenewL_License1;
        private Guna.UI2.WinForms.Guna2Chip Chip_Issue;
        private Guna.UI2.WinForms.Guna2Button Btn_Close;
        private System.Windows.Forms.LinkLabel Link_ShowNewLicense;
        private System.Windows.Forms.LinkLabel Link_PersonLicense;
    }
}