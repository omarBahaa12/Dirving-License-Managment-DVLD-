namespace DVLD_UITier
{
    partial class UCUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUserInfo));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Lb_ShowActive = new System.Windows.Forms.Label();
            this.Lb_ShowUserID = new System.Windows.Forms.Label();
            this.Lb_ShowUserName = new System.Windows.Forms.Label();
            this.Lb_Active = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.Lb_ShowActive);
            this.guna2ShadowPanel1.Controls.Add(this.Lb_ShowUserID);
            this.guna2ShadowPanel1.Controls.Add(this.Lb_ShowUserName);
            this.guna2ShadowPanel1.Controls.Add(this.Lb_Active);
            this.guna2ShadowPanel1.Controls.Add(this.Lb_UserID);
            this.guna2ShadowPanel1.Controls.Add(this.Lb_UserName);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(867, 120);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // Lb_ShowActive
            // 
            this.Lb_ShowActive.AutoSize = true;
            this.Lb_ShowActive.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowActive.Location = new System.Drawing.Point(762, 33);
            this.Lb_ShowActive.Name = "Lb_ShowActive";
            this.Lb_ShowActive.Size = new System.Drawing.Size(0, 20);
            this.Lb_ShowActive.TabIndex = 7;
            // 
            // Lb_ShowUserID
            // 
            this.Lb_ShowUserID.AutoSize = true;
            this.Lb_ShowUserID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowUserID.Location = new System.Drawing.Point(124, 19);
            this.Lb_ShowUserID.Name = "Lb_ShowUserID";
            this.Lb_ShowUserID.Size = new System.Drawing.Size(0, 20);
            this.Lb_ShowUserID.TabIndex = 5;
            // 
            // Lb_ShowUserName
            // 
            this.Lb_ShowUserName.AutoSize = true;
            this.Lb_ShowUserName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowUserName.Location = new System.Drawing.Point(404, 30);
            this.Lb_ShowUserName.Name = "Lb_ShowUserName";
            this.Lb_ShowUserName.Size = new System.Drawing.Size(0, 20);
            this.Lb_ShowUserName.TabIndex = 4;
            // 
            // Lb_Active
            // 
            this.Lb_Active.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Active.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Active.ImageIndex = 2;
            this.Lb_Active.ImageList = this.imageList1;
            this.Lb_Active.Location = new System.Drawing.Point(618, 17);
            this.Lb_Active.Name = "Lb_Active";
            this.Lb_Active.Size = new System.Drawing.Size(138, 51);
            this.Lb_Active.TabIndex = 3;
            this.Lb_Active.Text = "Active";
            this.Lb_Active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.png");
            this.imageList1.Images.SetKeyName(1, "reset-password.png");
            this.imageList1.Images.SetKeyName(2, "active-user.png");
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserID.Location = new System.Drawing.Point(22, 19);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(96, 24);
            this.Lb_UserID.TabIndex = 1;
            this.Lb_UserID.Text = "User ID:";
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_UserName.ImageIndex = 0;
            this.Lb_UserName.ImageList = this.imageList1;
            this.Lb_UserName.Location = new System.Drawing.Point(239, 19);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(159, 46);
            this.Lb_UserName.TabIndex = 0;
            this.Lb_UserName.Text = "User Name";
            this.Lb_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "UCUserInfo";
            this.Size = new System.Drawing.Size(867, 120);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label Lb_Active;
        private System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_ShowUserName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Lb_ShowUserID;
        private System.Windows.Forms.Label Lb_ShowActive;
    }
}
