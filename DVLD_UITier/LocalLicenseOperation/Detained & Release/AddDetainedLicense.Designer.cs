namespace DVLD_UITier.LocalLicenseOperation.Detained___Release
{
    partial class AddDetainedLicense
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
            this.ucFindByLocalLicense1 = new DVLD_UITier.UserControls.UCFindByLocalLicense();
            this.ucDetainedLicenseInfo1 = new DVLD_UITier.UserControls.UCDetainedLicenseInfo();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chip_Detained = new Guna.UI2.WinForms.Guna2Chip();
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
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detained License";
            // 
            // ucLicenseInfo1
            // 
            this.ucLicenseInfo1.Location = new System.Drawing.Point(1, 100);
            this.ucLicenseInfo1.Name = "ucLicenseInfo1";
            this.ucLicenseInfo1.Size = new System.Drawing.Size(961, 375);
            this.ucLicenseInfo1.TabIndex = 1;
            // 
            // ucFindByLocalLicense1
            // 
            this.ucFindByLocalLicense1.Location = new System.Drawing.Point(309, 41);
            this.ucFindByLocalLicense1.Name = "ucFindByLocalLicense1";
            this.ucFindByLocalLicense1.Size = new System.Drawing.Size(420, 53);
            this.ucFindByLocalLicense1.TabIndex = 0;
            // 
            // ucDetainedLicenseInfo1
            // 
            this.ucDetainedLicenseInfo1.Location = new System.Drawing.Point(1, 504);
            this.ucDetainedLicenseInfo1.Name = "ucDetainedLicenseInfo1";
            this.ucDetainedLicenseInfo1.Size = new System.Drawing.Size(751, 150);
            this.ucDetainedLicenseInfo1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "License Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detained Application Info";
            // 
            // Chip_Detained
            // 
            this.Chip_Detained.AutoRoundedCorners = true;
            this.Chip_Detained.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.Chip_Detained.BorderRadius = 19;
            this.Chip_Detained.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Chip_Detained.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chip_Detained.ForeColor = System.Drawing.Color.White;
            this.Chip_Detained.Location = new System.Drawing.Point(721, 676);
            this.Chip_Detained.Name = "Chip_Detained";
            this.Chip_Detained.Size = new System.Drawing.Size(130, 40);
            this.Chip_Detained.TabIndex = 6;
            this.Chip_Detained.Text = "Detained";
            this.Chip_Detained.Click += new System.EventHandler(this.Chip_Detained_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Close.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(442, 676);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(145, 45);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Link_PersonLicense
            // 
            this.Link_PersonLicense.AutoSize = true;
            this.Link_PersonLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_PersonLicense.Location = new System.Drawing.Point(12, 676);
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
            this.Link_ShowNewLicense.Location = new System.Drawing.Point(208, 676);
            this.Link_ShowNewLicense.Name = "Link_ShowNewLicense";
            this.Link_ShowNewLicense.Size = new System.Drawing.Size(163, 18);
            this.Link_ShowNewLicense.TabIndex = 8;
            this.Link_ShowNewLicense.TabStop = true;
            this.Link_ShowNewLicense.Text = "Show New License Info";
            this.Link_ShowNewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ShowNewLicense_LinkClicked);
            // 
            // AddDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 769);
            this.Controls.Add(this.Link_PersonLicense);
            this.Controls.Add(this.Link_ShowNewLicense);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Chip_Detained);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucDetainedLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucLicenseInfo1);
            this.Controls.Add(this.ucFindByLocalLicense1);
            this.Name = "AddDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Detained License";
            this.Load += new System.EventHandler(this.AddDetainedLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UCFindByLocalLicense ucFindByLocalLicense1;
        private UserControls.UCLicenseInfo ucLicenseInfo1;
        private System.Windows.Forms.Label label1;
        private UserControls.UCDetainedLicenseInfo ucDetainedLicenseInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Chip Chip_Detained;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
        private System.Windows.Forms.LinkLabel Link_PersonLicense;
        private System.Windows.Forms.LinkLabel Link_ShowNewLicense;
    }
}