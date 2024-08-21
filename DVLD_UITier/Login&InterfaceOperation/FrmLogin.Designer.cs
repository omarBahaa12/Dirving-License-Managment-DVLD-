namespace DVLD_UITier
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lb_UserName = new System.Windows.Forms.Label();
            this.Lb_Password = new System.Windows.Forms.Label();
            this.Txtb_UserName = new RJCodeAdvance.RJControls.RJTextBox();
            this.Txtb_Password = new RJCodeAdvance.RJControls.RJTextBox();
            this.Btn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_ShowPassword = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Chb_Remember = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = global::DVLD_UITier.Properties.Resources.Untitled;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(415, 420);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(415, 506);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(612, 32);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(107, 48);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Login";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Lb_UserName
            // 
            this.Lb_UserName.AutoSize = true;
            this.Lb_UserName.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_UserName.Location = new System.Drawing.Point(480, 153);
            this.Lb_UserName.Name = "Lb_UserName";
            this.Lb_UserName.Size = new System.Drawing.Size(126, 27);
            this.Lb_UserName.TabIndex = 3;
            this.Lb_UserName.Text = "User Name";
            // 
            // Lb_Password
            // 
            this.Lb_Password.AutoSize = true;
            this.Lb_Password.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Password.Location = new System.Drawing.Point(497, 271);
            this.Lb_Password.Name = "Lb_Password";
            this.Lb_Password.Size = new System.Drawing.Size(109, 27);
            this.Lb_Password.TabIndex = 4;
            this.Lb_Password.Text = "Password";
            // 
            // Txtb_UserName
            // 
            this.Txtb_UserName.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_UserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_UserName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_UserName.BorderRadius = 0;
            this.Txtb_UserName.BorderSize = 2;
            this.Txtb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_UserName.Location = new System.Drawing.Point(626, 145);
            this.Txtb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_UserName.Multiline = false;
            this.Txtb_UserName.Name = "Txtb_UserName";
            this.Txtb_UserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_UserName.PasswordChar = false;
            this.Txtb_UserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_UserName.PlaceholderText = "";
            this.Txtb_UserName.Size = new System.Drawing.Size(149, 35);
            this.Txtb_UserName.TabIndex = 5;
            this.Txtb_UserName.Texts = "";
            this.Txtb_UserName.UnderlinedStyle = false;
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
            this.Txtb_Password.Location = new System.Drawing.Point(626, 263);
            this.Txtb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_Password.Multiline = false;
            this.Txtb_Password.Name = "Txtb_Password";
            this.Txtb_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_Password.PasswordChar = true;
            this.Txtb_Password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_Password.PlaceholderText = "";
            this.Txtb_Password.Size = new System.Drawing.Size(149, 35);
            this.Txtb_Password.TabIndex = 6;
            this.Txtb_Password.Texts = "";
            this.Txtb_Password.UnderlinedStyle = false;
            // 
            // Btn_Login
            // 
            this.Btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(639, 411);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(127, 52);
            this.Btn_Login.TabIndex = 7;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_ShowPassword
            // 
            this.Btn_ShowPassword.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowPassword.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowPassword.Image")));
            this.Btn_ShowPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_ShowPassword.ImageRotate = 0F;
            this.Btn_ShowPassword.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_ShowPassword.Location = new System.Drawing.Point(793, 263);
            this.Btn_ShowPassword.Name = "Btn_ShowPassword";
            this.Btn_ShowPassword.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowPassword.Size = new System.Drawing.Size(43, 35);
            this.Btn_ShowPassword.TabIndex = 8;
            this.Btn_ShowPassword.MouseEnter += new System.EventHandler(this.Btn_ShowPassword_MouseEnter);
            this.Btn_ShowPassword.MouseLeave += new System.EventHandler(this.Btn_ShowPassword_MouseLeave);
            // 
            // Chb_Remember
            // 
            this.Chb_Remember.AutoSize = true;
            this.Chb_Remember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Chb_Remember.CheckedState.BorderRadius = 0;
            this.Chb_Remember.CheckedState.BorderThickness = 0;
            this.Chb_Remember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Chb_Remember.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_Remember.Location = new System.Drawing.Point(626, 343);
            this.Chb_Remember.Name = "Chb_Remember";
            this.Chb_Remember.Size = new System.Drawing.Size(141, 24);
            this.Chb_Remember.TabIndex = 9;
            this.Chb_Remember.Text = "Remember me";
            this.Chb_Remember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Chb_Remember.UncheckedState.BorderRadius = 0;
            this.Chb_Remember.UncheckedState.BorderThickness = 0;
            this.Chb_Remember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 506);
            this.Controls.Add(this.Chb_Remember);
            this.Controls.Add(this.Btn_ShowPassword);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txtb_Password);
            this.Controls.Add(this.Txtb_UserName);
            this.Controls.Add(this.Lb_Password);
            this.Controls.Add(this.Lb_UserName);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label Lb_UserName;
        private System.Windows.Forms.Label Lb_Password;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_UserName;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_Password;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Login;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_ShowPassword;
        private Guna.UI2.WinForms.Guna2CheckBox Chb_Remember;
    }
}