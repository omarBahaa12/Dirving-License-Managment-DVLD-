namespace DVLD_UITier.LocalLicenseOperation
{
    partial class FrmReplaceForLostOrDamaged
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
            this.ucLicenseInfo1 = new DVLD_UITier.UserControls.UCLicenseInfo();
            this.ucLostOrDamaged1 = new DVLD_UITier.UserControls.UCLostOrDamaged();
            this.ucFindByLocalLicense1 = new DVLD_UITier.UserControls.UCFindByLocalLicense();
            this.ucDamagedorLostApplication1 = new DVLD_UITier.UserControls.UCDamagedorLostApplication();
            this.Chip_Issue = new Guna.UI2.WinForms.Guna2Chip();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Link_PersonLicense = new System.Windows.Forms.LinkLabel();
            this.Link_ShowNewLicense = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replace For Damaged or lost";
            // 
            // ucLicenseInfo1
            // 
            this.ucLicenseInfo1.Location = new System.Drawing.Point(12, 114);
            this.ucLicenseInfo1.Name = "ucLicenseInfo1";
            this.ucLicenseInfo1.Size = new System.Drawing.Size(961, 375);
            this.ucLicenseInfo1.TabIndex = 3;
            // 
            // ucLostOrDamaged1
            // 
            this.ucLostOrDamaged1.Location = new System.Drawing.Point(810, 9);
            this.ucLostOrDamaged1.Name = "ucLostOrDamaged1";
            this.ucLostOrDamaged1.Size = new System.Drawing.Size(226, 99);
            this.ucLostOrDamaged1.TabIndex = 2;
            // 
            // ucFindByLocalLicense1
            // 
            this.ucFindByLocalLicense1.Location = new System.Drawing.Point(2, 41);
            this.ucFindByLocalLicense1.Name = "ucFindByLocalLicense1";
            this.ucFindByLocalLicense1.Size = new System.Drawing.Size(420, 53);
            this.ucFindByLocalLicense1.TabIndex = 1;
            // 
            // ucDamagedorLostApplication1
            // 
            this.ucDamagedorLostApplication1.Location = new System.Drawing.Point(2, 472);
            this.ucDamagedorLostApplication1.Name = "ucDamagedorLostApplication1";
            this.ucDamagedorLostApplication1.Size = new System.Drawing.Size(746, 159);
            this.ucDamagedorLostApplication1.TabIndex = 4;
            // 
            // Chip_Issue
            // 
            this.Chip_Issue.AutoRoundedCorners = true;
            this.Chip_Issue.BorderColor = System.Drawing.Color.PowderBlue;
            this.Chip_Issue.BorderRadius = 21;
            this.Chip_Issue.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Chip_Issue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chip_Issue.ForeColor = System.Drawing.Color.White;
            this.Chip_Issue.Location = new System.Drawing.Point(797, 643);
            this.Chip_Issue.Name = "Chip_Issue";
            this.Chip_Issue.Size = new System.Drawing.Size(130, 45);
            this.Chip_Issue.TabIndex = 5;
            this.Chip_Issue.Text = "Issue";
            this.Chip_Issue.Click += new System.EventHandler(this.Chip_Issue_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.Gainsboro;
            this.Btn_Close.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(584, 643);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(146, 45);
            this.Btn_Close.TabIndex = 6;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Link_PersonLicense
            // 
            this.Link_PersonLicense.AutoSize = true;
            this.Link_PersonLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_PersonLicense.Location = new System.Drawing.Point(10, 670);
            this.Link_PersonLicense.Name = "Link_PersonLicense";
            this.Link_PersonLicense.Size = new System.Drawing.Size(162, 18);
            this.Link_PersonLicense.TabIndex = 9;
            this.Link_PersonLicense.TabStop = true;
            this.Link_PersonLicense.Text = "Person License History";
            this.Link_PersonLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_PersonLicense_LinkClicked);
            // 
            // Link_ShowNewLicense
            // 
            this.Link_ShowNewLicense.AutoSize = true;
            this.Link_ShowNewLicense.Enabled = false;
            this.Link_ShowNewLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_ShowNewLicense.Location = new System.Drawing.Point(206, 670);
            this.Link_ShowNewLicense.Name = "Link_ShowNewLicense";
            this.Link_ShowNewLicense.Size = new System.Drawing.Size(163, 18);
            this.Link_ShowNewLicense.TabIndex = 8;
            this.Link_ShowNewLicense.TabStop = true;
            this.Link_ShowNewLicense.Text = "Show New License Info";
            this.Link_ShowNewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ShowNewLicense_LinkClicked);
            // 
            // FrmReplaceForLostOrDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 769);
            this.Controls.Add(this.Link_PersonLicense);
            this.Controls.Add(this.Link_ShowNewLicense);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Chip_Issue);
            this.Controls.Add(this.ucDamagedorLostApplication1);
            this.Controls.Add(this.ucLicenseInfo1);
            this.Controls.Add(this.ucLostOrDamaged1);
            this.Controls.Add(this.ucFindByLocalLicense1);
            this.Controls.Add(this.label1);
            this.Name = "FrmReplaceForLostOrDamaged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace For Lost & Damaged";
            this.Load += new System.EventHandler(this.FrmReplaceForLostOrDamaged_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UserControls.UCFindByLocalLicense ucFindByLocalLicense1;
        private UserControls.UCLostOrDamaged ucLostOrDamaged1;
        private UserControls.UCLicenseInfo ucLicenseInfo1;
        private UserControls.UCDamagedorLostApplication ucDamagedorLostApplication1;
        private Guna.UI2.WinForms.Guna2Chip Chip_Issue;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
        private System.Windows.Forms.LinkLabel Link_PersonLicense;
        private System.Windows.Forms.LinkLabel Link_ShowNewLicense;
    }
}