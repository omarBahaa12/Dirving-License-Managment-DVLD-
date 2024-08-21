namespace DVLD_UITier.LicenseOperation
{
    partial class FrmAddLocalLicense
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucDetailedInfo1 = new DVLD_UITier.UCDetailedInfo();
            this.ucFindByNationalNo1 = new DVLD_UITier.UCFindByNationalNo();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucAddLocalLicense1 = new DVLD_UITier.UserControls.UCAddLocalLicense();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1187, 487);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucDetailedInfo1);
            this.tabPage1.Controls.Add(this.ucFindByNationalNo1);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(999, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucDetailedInfo1
            // 
            this.ucDetailedInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDetailedInfo1.ID = 0;
            this.ucDetailedInfo1.Location = new System.Drawing.Point(3, 52);
            this.ucDetailedInfo1.Name = "ucDetailedInfo1";
            this.ucDetailedInfo1.Size = new System.Drawing.Size(993, 421);
            this.ucDetailedInfo1.TabIndex = 1;
            // 
            // ucFindByNationalNo1
            // 
            this.ucFindByNationalNo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFindByNationalNo1.Location = new System.Drawing.Point(3, 3);
            this.ucFindByNationalNo1.Name = "ucFindByNationalNo1";
            this.ucFindByNationalNo1.Size = new System.Drawing.Size(993, 49);
            this.ucFindByNationalNo1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucAddLocalLicense1);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucAddLocalLicense1
            // 
            this.ucAddLocalLicense1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddLocalLicense1.LicenseClassID = 4;
            this.ucAddLocalLicense1.Location = new System.Drawing.Point(3, 3);
            this.ucAddLocalLicense1.Name = "ucAddLocalLicense1";
            this.ucAddLocalLicense1.Size = new System.Drawing.Size(949, 473);
            this.ucAddLocalLicense1.TabIndex = 0;
            // 
            // Btn_Save
            // 
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Btn_Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::DVLD_UITier.Properties.Resources.diskette;
            this.Btn_Save.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Save.Location = new System.Drawing.Point(891, 512);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(123, 50);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Btn_Close.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(487, 512);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(123, 50);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // FrmAddLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 587);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.guna2TabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local License";
            this.Load += new System.EventHandler(this.FrmAddLocalLicense_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UCDetailedInfo ucDetailedInfo1;
        private UCFindByNationalNo ucFindByNationalNo1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Save;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
        private UserControls.UCAddLocalLicense ucAddLocalLicense1;
    }
}