namespace DVLD_UITier
{
    partial class FrmUser_sDetailedInfo
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
            this.Btn_Cancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucUserInfo1 = new DVLD_UITier.UCUserInfo();
            this.ucDetailedInfo1 = new DVLD_UITier.UCDetailedInfo();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Animated = true;
            this.Btn_Cancel.AnimatedGIF = true;
            this.Btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Cancel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.Location = new System.Drawing.Point(554, 500);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(125, 52);
            this.Btn_Cancel.TabIndex = 0;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // ucUserInfo1
            // 
            this.ucUserInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucUserInfo1.Location = new System.Drawing.Point(0, 361);
            this.ucUserInfo1.Name = "ucUserInfo1";
            this.ucUserInfo1.Size = new System.Drawing.Size(918, 118);
            this.ucUserInfo1.TabIndex = 2;
            // 
            // ucDetailedInfo1
            // 
            this.ucDetailedInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDetailedInfo1.ID = 0;
            this.ucDetailedInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucDetailedInfo1.Name = "ucDetailedInfo1";
            this.ucDetailedInfo1.Size = new System.Drawing.Size(918, 361);
            this.ucDetailedInfo1.TabIndex = 1;
            // 
            // FrmUser_sDetailedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 584);
            this.Controls.Add(this.ucUserInfo1);
            this.Controls.Add(this.ucDetailedInfo1);
            this.Controls.Add(this.Btn_Cancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser_sDetailedInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Btn_Cancel;
        private UCDetailedInfo ucDetailedInfo1;
        private UCUserInfo ucUserInfo1;
    }
}