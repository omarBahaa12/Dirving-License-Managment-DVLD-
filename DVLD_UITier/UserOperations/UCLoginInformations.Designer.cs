namespace DVLD_UITier
{
    partial class UCLoginInformations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoginInformations));
            this.Txtb_UserName = new RJCodeAdvance.RJControls.RJTextBox();
            this.Txtb_Password = new RJCodeAdvance.RJControls.RJTextBox();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Lb_Activing = new System.Windows.Forms.Label();
            this.Tbtn_Activing = new RJCodeAdvance.RJControls.RJToggleButton();
            this.Lb_UserID = new System.Windows.Forms.Label();
            this.Lb_ShowUserID = new System.Windows.Forms.Label();
            this.Btn_ShowPassword = new RJCodeAdvance.RJControls.RJToggleButton();
            this.SuspendLayout();
            // 
            // Txtb_UserName
            // 
            this.Txtb_UserName.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_UserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_UserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_UserName.BorderRadius = 0;
            this.Txtb_UserName.BorderSize = 2;
            this.Txtb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_UserName.Location = new System.Drawing.Point(269, 144);
            this.Txtb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_UserName.Multiline = false;
            this.Txtb_UserName.Name = "Txtb_UserName";
            this.Txtb_UserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_UserName.PasswordChar = false;
            this.Txtb_UserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_UserName.PlaceholderText = "";
            this.Txtb_UserName.Size = new System.Drawing.Size(155, 35);
            this.Txtb_UserName.TabIndex = 0;
            this.Txtb_UserName.Texts = "";
            this.Txtb_UserName.UnderlinedStyle = false;
            this.Txtb_UserName._TextChanged += new System.EventHandler(this.Txtb_UserName__TextChanged);
            // 
            // Txtb_Password
            // 
            this.Txtb_Password.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_Password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_Password.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_Password.BorderRadius = 0;
            this.Txtb_Password.BorderSize = 2;
            this.Txtb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_Password.Location = new System.Drawing.Point(269, 234);
            this.Txtb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_Password.Multiline = false;
            this.Txtb_Password.Name = "Txtb_Password";
            this.Txtb_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_Password.PasswordChar = true;
            this.Txtb_Password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_Password.PlaceholderText = "";
            this.Txtb_Password.Size = new System.Drawing.Size(155, 35);
            this.Txtb_Password.TabIndex = 1;
            this.Txtb_Password.Texts = "";
            this.Txtb_Password.UnderlinedStyle = false;
            this.Txtb_Password._TextChanged += new System.EventHandler(this.Txtb_Password__TextChanged);
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_UserName.ImageIndex = 3;
            this.Lb_UserName.ImageList = this.imageList1;
            this.Lb_UserName.Location = new System.Drawing.Point(12, 144);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(200, 48);
            this.Lb_UserName.TabIndex = 2;
            this.Lb_UserName.Text = "User Name";
            this.Lb_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete-user.png");
            this.imageList1.Images.SetKeyName(1, "add-user(1).png");
            this.imageList1.Images.SetKeyName(2, "search.png");
            this.imageList1.Images.SetKeyName(3, "user.png");
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Password.Location = new System.Drawing.Point(103, 242);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(109, 27);
            this.Lb_Password.TabIndex = 3;
            this.Lb_Password.Text = "Password";
            // 
            // Lb_Activing
            // 
            this.Lb_Activing.AutoSize = true;
            this.Lb_Activing.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Activing.Location = new System.Drawing.Point(116, 326);
            this.Lb_Activing.Name = "Lb_Activing";
            this.Lb_Activing.Size = new System.Drawing.Size(96, 27);
            this.Lb_Activing.TabIndex = 4;
            this.Lb_Activing.Text = "Activing";
            // 
            // Tbtn_Activing
            // 
            this.Tbtn_Activing.AutoSize = true;
            this.Tbtn_Activing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tbtn_Activing.Location = new System.Drawing.Point(269, 331);
            this.Tbtn_Activing.MinimumSize = new System.Drawing.Size(45, 22);
            this.Tbtn_Activing.Name = "Tbtn_Activing";
            this.Tbtn_Activing.OffBackColor = System.Drawing.Color.Gray;
            this.Tbtn_Activing.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Tbtn_Activing.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Tbtn_Activing.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Tbtn_Activing.Size = new System.Drawing.Size(45, 22);
            this.Tbtn_Activing.TabIndex = 5;
            this.Tbtn_Activing.UseVisualStyleBackColor = true;
            this.Tbtn_Activing.CheckedChanged += new System.EventHandler(this.Tbtn_Activing_CheckedChanged);
            // 
            // Lb_UserID
            // 
            this.Lb_UserID.AutoSize = true;
            this.Lb_UserID.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserID.Location = new System.Drawing.Point(103, 62);
            this.Lb_UserID.Name = "Lb_UserID";
            this.Lb_UserID.Size = new System.Drawing.Size(98, 27);
            this.Lb_UserID.TabIndex = 6;
            this.Lb_UserID.Text = "User ID:";
            // 
            // Lb_ShowUserID
            // 
            this.Lb_ShowUserID.AutoSize = true;
            this.Lb_ShowUserID.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowUserID.Location = new System.Drawing.Point(207, 62);
            this.Lb_ShowUserID.Name = "Lb_ShowUserID";
            this.Lb_ShowUserID.Size = new System.Drawing.Size(34, 27);
            this.Lb_ShowUserID.TabIndex = 7;
            this.Lb_ShowUserID.Text = "??";
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.AutoSize = true;
            this.Btn_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ShowPassword.Location = new System.Drawing.Point(446, 242);
            this.Btn_ShowPassword.MinimumSize = new System.Drawing.Size(45, 22);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.OffBackColor = System.Drawing.Color.Gray;
            this.Btn_ShowPassword.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.Btn_ShowPassword.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_ShowPassword.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_ShowPassword.Size = new System.Drawing.Size(45, 22);
            this.Btn_ShowPassword.TabIndex = 8;
            this.Btn_ShowPassword.UseVisualStyleBackColor = true;
            this.Btn_ShowPassword.MouseEnter += new System.EventHandler(this.Btn_ShowPassword_MouseEnter);
            this.Btn_ShowPassword.MouseLeave += new System.EventHandler(this.Btn_ShowPassword_MouseLeave);
            // 
            // UCLoginInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_ShowPassword);
            this.Controls.Add(this.Lb_ShowUserID);
            this.Controls.Add(this.Lb_UserID);
            this.Controls.Add(this.Tbtn_Activing);
            this.Controls.Add(this.Lb_Activing);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.Txtb_Password);
            this.Controls.Add(this.Txtb_UserName);
            this.Name = "UCLoginInformations";
            this.Size = new System.Drawing.Size(511, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox Txtb_UserName;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_Password;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_Password;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Lb_Activing;
        private RJCodeAdvance.RJControls.RJToggleButton Tbtn_Activing;
        private System.Windows.Forms.Label Lb_UserID;
        private System.Windows.Forms.Label Lb_ShowUserID;
        private RJCodeAdvance.RJControls.RJToggleButton Btn_ShowPassword;
    }
}
