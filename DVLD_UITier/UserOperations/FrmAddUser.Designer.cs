namespace DVLD_UITier
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersonalInfo = new System.Windows.Forms.TabPage();
            this.Btn_Next = new RJCodeAdvance.RJControls.RJButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LoginInfo = new System.Windows.Forms.TabPage();
            this.Btn_Cancel = new RJCodeAdvance.RJControls.RJButton();
            this.Btn_Save = new RJCodeAdvance.RJControls.RJButton();
            this.ucDetailedInfo1 = new DVLD_UITier.UCDetailedInfo();
            this.ucFindByNationalNo1 = new DVLD_UITier.UCFindByNationalNo();
            this.ucLoginInformations1 = new DVLD_UITier.UCLoginInformations();
            this.tabControl1.SuspendLayout();
            this.PersonalInfo.SuspendLayout();
            this.LoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonalInfo);
            this.tabControl1.Controls.Add(this.LoginInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.Controls.Add(this.Btn_Next);
            this.PersonalInfo.Controls.Add(this.ucDetailedInfo1);
            this.PersonalInfo.Controls.Add(this.ucFindByNationalNo1);
            this.PersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfo.Size = new System.Drawing.Size(914, 463);
            this.PersonalInfo.TabIndex = 0;
            this.PersonalInfo.Text = "Personal Info";
            this.PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // Btn_Next
            // 
            this.Btn_Next.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Next.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Btn_Next.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Next.BorderRadius = 0;
            this.Btn_Next.BorderSize = 0;
            this.Btn_Next.FlatAppearance.BorderSize = 0;
            this.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Next.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.ForeColor = System.Drawing.Color.Black;
            this.Btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Next.ImageIndex = 0;
            this.Btn_Next.ImageList = this.imageList1;
            this.Btn_Next.Location = new System.Drawing.Point(684, 402);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(109, 57);
            this.Btn_Next.TabIndex = 2;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Next.TextColor = System.Drawing.Color.Black;
            this.Btn_Next.UseVisualStyleBackColor = false;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "right.png");
            this.imageList1.Images.SetKeyName(1, "cross.png");
            this.imageList1.Images.SetKeyName(2, "diskette.png");
            // 
            // LoginInfo
            // 
            this.LoginInfo.Controls.Add(this.ucLoginInformations1);
            this.LoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginInfo.Location = new System.Drawing.Point(4, 29);
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.LoginInfo.Size = new System.Drawing.Size(914, 463);
            this.LoginInfo.TabIndex = 1;
            this.LoginInfo.Text = "Login Info";
            this.LoginInfo.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Cancel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Btn_Cancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Cancel.BorderRadius = 0;
            this.Btn_Cancel.BorderSize = 0;
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.ImageIndex = 1;
            this.Btn_Cancel.ImageList = this.imageList1;
            this.Btn_Cancel.Location = new System.Drawing.Point(450, 498);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(133, 55);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancel.TextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Save.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Btn_Save.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Save.BorderRadius = 0;
            this.Btn_Save.BorderSize = 0;
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.Black;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Save.ImageIndex = 2;
            this.Btn_Save.ImageList = this.imageList1;
            this.Btn_Save.Location = new System.Drawing.Point(764, 502);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(120, 55);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Save.TextColor = System.Drawing.Color.Black;
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // ucDetailedInfo1
            // 
            this.ucDetailedInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDetailedInfo1.ID = 0;
            this.ucDetailedInfo1.Location = new System.Drawing.Point(3, 55);
            this.ucDetailedInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDetailedInfo1.Name = "ucDetailedInfo1";
            this.ucDetailedInfo1.Size = new System.Drawing.Size(908, 558);
            this.ucDetailedInfo1.TabIndex = 1;
            // 
            // ucFindByNationalNo1
            // 
            this.ucFindByNationalNo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucFindByNationalNo1.Location = new System.Drawing.Point(3, 3);
            this.ucFindByNationalNo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucFindByNationalNo1.Name = "ucFindByNationalNo1";
            this.ucFindByNationalNo1.Size = new System.Drawing.Size(908, 52);
            this.ucFindByNationalNo1.TabIndex = 0;
            // 
            // ucLoginInformations1
            // 
            this.ucLoginInformations1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucLoginInformations1.IsActive = false;
            this.ucLoginInformations1.Location = new System.Drawing.Point(3, 3);
            this.ucLoginInformations1.Name = "ucLoginInformations1";
            this.ucLoginInformations1.Password = null;
            this.ucLoginInformations1.Size = new System.Drawing.Size(908, 445);
            this.ucLoginInformations1.TabIndex = 0;
            this.ucLoginInformations1.UserName = null;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 565);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUser";
            this.tabControl1.ResumeLayout(false);
            this.PersonalInfo.ResumeLayout(false);
            this.LoginInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonalInfo;
        private RJCodeAdvance.RJControls.RJButton Btn_Next;
        private UCDetailedInfo ucDetailedInfo1;
        private UCFindByNationalNo ucFindByNationalNo1;
        private System.Windows.Forms.TabPage LoginInfo;
        private System.Windows.Forms.ImageList imageList1;
        private RJCodeAdvance.RJControls.RJButton Btn_Cancel;
        private RJCodeAdvance.RJControls.RJButton Btn_Save;
        private UCLoginInformations ucLoginInformations1;
    }
}