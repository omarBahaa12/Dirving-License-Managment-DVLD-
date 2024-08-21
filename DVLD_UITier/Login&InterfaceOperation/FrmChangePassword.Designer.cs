namespace DVLD_UITier
{
    partial class FrmChangePassword
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
            this.Btn_Save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucChangePassword1 = new DVLD_UITier.UCChangePassword();
            this.ucUserInfo1 = new DVLD_UITier.UCUserInfo();
            this.ucDetailedInfo1 = new DVLD_UITier.UCDetailedInfo();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.FillColor = System.Drawing.Color.White;
            this.Btn_Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::DVLD_UITier.Properties.Resources.diskette;
            this.Btn_Save.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Save.Location = new System.Drawing.Point(613, 687);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(147, 59);
            this.Btn_Save.TabIndex = 3;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
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
            this.Btn_Cancel.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_Cancel.Location = new System.Drawing.Point(252, 687);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(147, 56);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // ucChangePassword1
            // 
            this.ucChangePassword1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucChangePassword1.Location = new System.Drawing.Point(0, 460);
            this.ucChangePassword1.Name = "ucChangePassword1";
            this.ucChangePassword1.NewPassword = null;
            this.ucChangePassword1.Size = new System.Drawing.Size(484, 221);
            this.ucChangePassword1.TabIndex = 2;
            // 
            // ucUserInfo1
            // 
            this.ucUserInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUserInfo1.Location = new System.Drawing.Point(0, 376);
            this.ucUserInfo1.Name = "ucUserInfo1";
            this.ucUserInfo1.Size = new System.Drawing.Size(829, 78);
            this.ucUserInfo1.TabIndex = 1;
            // 
            // ucDetailedInfo1
            // 
            this.ucDetailedInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDetailedInfo1.ID = 0;
            this.ucDetailedInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucDetailedInfo1.Name = "ucDetailedInfo1";
            this.ucDetailedInfo1.Size = new System.Drawing.Size(829, 376);
            this.ucDetailedInfo1.TabIndex = 0;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 751);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.ucChangePassword1);
            this.Controls.Add(this.ucUserInfo1);
            this.Controls.Add(this.ucDetailedInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);

        }

        #endregion

        private UCDetailedInfo ucDetailedInfo1;
        private UCUserInfo ucUserInfo1;
        private UCChangePassword ucChangePassword1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Save;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Cancel;
    }
}