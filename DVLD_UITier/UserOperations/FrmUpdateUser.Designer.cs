namespace DVLD_UITier
{
    partial class FrmUpdateUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateUser));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucDetailedInfo1 = new DVLD_UITier.UCDetailedInfo();
            this.ucFindByNationalNo1 = new DVLD_UITier.UCFindByNationalNo();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucLoginInformations1 = new DVLD_UITier.UCLoginInformations();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
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
            this.guna2TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(140, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1039, 501);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.Black;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(140, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucDetailedInfo1);
            this.tabPage1.Controls.Add(this.ucFindByNationalNo1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(144, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucDetailedInfo1
            // 
            this.ucDetailedInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDetailedInfo1.ID = 0;
            this.ucDetailedInfo1.Location = new System.Drawing.Point(3, 60);
            this.ucDetailedInfo1.Name = "ucDetailedInfo1";
            this.ucDetailedInfo1.Size = new System.Drawing.Size(885, 392);
            this.ucDetailedInfo1.TabIndex = 2;
            // 
            // ucFindByNationalNo1
            // 
            this.ucFindByNationalNo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFindByNationalNo1.Location = new System.Drawing.Point(3, 3);
            this.ucFindByNationalNo1.Name = "ucFindByNationalNo1";
            this.ucFindByNationalNo1.Size = new System.Drawing.Size(885, 57);
            this.ucFindByNationalNo1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucLoginInformations1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(144, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucLoginInformations1
            // 
            this.ucLoginInformations1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucLoginInformations1.IsActive = false;
            this.ucLoginInformations1.Location = new System.Drawing.Point(3, 3);
            this.ucLoginInformations1.Name = "ucLoginInformations1";
            this.ucLoginInformations1.Password = null;
            this.ucLoginInformations1.Size = new System.Drawing.Size(511, 487);
            this.ucLoginInformations1.TabIndex = 0;
            this.ucLoginInformations1.UserName = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "right.png");
            this.imageList1.Images.SetKeyName(1, "cross.png");
            this.imageList1.Images.SetKeyName(2, "diskette.png");
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Cancel.FillColor = System.Drawing.Color.White;
            this.Btn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Cancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Cancel.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Cancel.Location = new System.Drawing.Point(487, 543);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(166, 55);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.FillColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::DVLD_UITier.Properties.Resources.diskette;
            this.Btn_Save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Save.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Save.IndicateFocus = true;
            this.Btn_Save.Location = new System.Drawing.Point(806, 543);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.PressedColor = System.Drawing.Color.Gainsboro;
            this.Btn_Save.Size = new System.Drawing.Size(161, 55);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FrmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 615);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateUser";
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UCLoginInformations ucLoginInformations1;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Save;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Cancel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private UCFindByNationalNo ucFindByNationalNo1;
        private UCDetailedInfo ucDetailedInfo1;
    }
}