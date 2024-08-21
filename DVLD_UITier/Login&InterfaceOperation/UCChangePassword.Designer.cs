namespace DVLD_UITier
{
    partial class UCChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChangePassword));
            this.Lb_OldPassword = new System.Windows.Forms.Label();
            this.Lb_NewPassword = new System.Windows.Forms.Label();
            this.Lb_ConfirmPassword = new System.Windows.Forms.Label();
            this.Btn_ShwoOldPassword = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_ShowNewPassword = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Txtb_OldPassword = new System.Windows.Forms.TextBox();
            this.Txtb_NewPassword = new System.Windows.Forms.TextBox();
            this.Txtb_ConfirmPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_OldPassword
            // 
            this.Lb_OldPassword.AutoSize = true;
            this.Lb_OldPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_OldPassword.Location = new System.Drawing.Point(41, 24);
            this.Lb_OldPassword.Name = "Lb_OldPassword";
            this.Lb_OldPassword.Size = new System.Drawing.Size(150, 24);
            this.Lb_OldPassword.TabIndex = 0;
            this.Lb_OldPassword.Text = "Old Password";
            // 
            // Lb_NewPassword
            // 
            this.Lb_NewPassword.AutoSize = true;
            this.Lb_NewPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NewPassword.Location = new System.Drawing.Point(32, 89);
            this.Lb_NewPassword.Name = "Lb_NewPassword";
            this.Lb_NewPassword.Size = new System.Drawing.Size(159, 24);
            this.Lb_NewPassword.TabIndex = 1;
            this.Lb_NewPassword.Text = "New Password";
            // 
            // Lb_ConfirmPassword
            // 
            this.Lb_ConfirmPassword.AutoSize = true;
            this.Lb_ConfirmPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ConfirmPassword.Location = new System.Drawing.Point(3, 161);
            this.Lb_ConfirmPassword.Name = "Lb_ConfirmPassword";
            this.Lb_ConfirmPassword.Size = new System.Drawing.Size(200, 24);
            this.Lb_ConfirmPassword.TabIndex = 2;
            this.Lb_ConfirmPassword.Text = "Confirm Password";
            // 
            // Btn_ShwoOldPassword
            // 
            this.Btn_ShwoOldPassword.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShwoOldPassword.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShwoOldPassword.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShwoOldPassword.Image")));
            this.Btn_ShwoOldPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_ShwoOldPassword.ImageRotate = 0F;
            this.Btn_ShwoOldPassword.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_ShwoOldPassword.Location = new System.Drawing.Point(422, 19);
            this.Btn_ShwoOldPassword.Name = "Btn_ShwoOldPassword";
            this.Btn_ShwoOldPassword.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShwoOldPassword.Size = new System.Drawing.Size(40, 29);
            this.Btn_ShwoOldPassword.TabIndex = 6;
            this.Btn_ShwoOldPassword.MouseEnter += new System.EventHandler(this.Btn_ShwoOldPassword_MouseEnter);
            this.Btn_ShwoOldPassword.MouseLeave += new System.EventHandler(this.Btn_ShwoOldPassword_MouseLeave);
            // 
            // Btn_ShowNewPassword
            // 
            this.Btn_ShowNewPassword.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowNewPassword.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ShowNewPassword.Image")));
            this.Btn_ShowNewPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_ShowNewPassword.ImageRotate = 0F;
            this.Btn_ShowNewPassword.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_ShowNewPassword.Location = new System.Drawing.Point(422, 80);
            this.Btn_ShowNewPassword.Name = "Btn_ShowNewPassword";
            this.Btn_ShowNewPassword.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_ShowNewPassword.Size = new System.Drawing.Size(40, 33);
            this.Btn_ShowNewPassword.TabIndex = 7;
            this.Btn_ShowNewPassword.MouseEnter += new System.EventHandler(this.Btn_ShowNewPassword_MouseEnter);
            this.Btn_ShowNewPassword.MouseLeave += new System.EventHandler(this.Btn_ShowNewPassword_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Txtb_OldPassword
            // 
            this.Txtb_OldPassword.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_OldPassword.Location = new System.Drawing.Point(235, 25);
            this.Txtb_OldPassword.Name = "Txtb_OldPassword";
            this.Txtb_OldPassword.Size = new System.Drawing.Size(146, 27);
            this.Txtb_OldPassword.TabIndex = 8;
            this.Txtb_OldPassword.UseSystemPasswordChar = true;
            // 
            // Txtb_NewPassword
            // 
            this.Txtb_NewPassword.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_NewPassword.Location = new System.Drawing.Point(235, 89);
            this.Txtb_NewPassword.Name = "Txtb_NewPassword";
            this.Txtb_NewPassword.Size = new System.Drawing.Size(146, 27);
            this.Txtb_NewPassword.TabIndex = 9;
            this.Txtb_NewPassword.UseSystemPasswordChar = true;
            this.Txtb_NewPassword.TextChanged += new System.EventHandler(this.Txtb_NewPassword_TextChanged);
            // 
            // Txtb_ConfirmPassword
            // 
            this.Txtb_ConfirmPassword.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_ConfirmPassword.Location = new System.Drawing.Point(235, 161);
            this.Txtb_ConfirmPassword.Name = "Txtb_ConfirmPassword";
            this.Txtb_ConfirmPassword.Size = new System.Drawing.Size(146, 27);
            this.Txtb_ConfirmPassword.TabIndex = 10;
            this.Txtb_ConfirmPassword.UseSystemPasswordChar = true;
            this.Txtb_ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_ConfirmPassword_Validating);
            // 
            // UCChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txtb_ConfirmPassword);
            this.Controls.Add(this.Txtb_NewPassword);
            this.Controls.Add(this.Txtb_OldPassword);
            this.Controls.Add(this.Btn_ShowNewPassword);
            this.Controls.Add(this.Btn_ShwoOldPassword);
            this.Controls.Add(this.Lb_ConfirmPassword);
            this.Controls.Add(this.Lb_NewPassword);
            this.Controls.Add(this.Lb_OldPassword);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCChangePassword";
            this.Size = new System.Drawing.Size(535, 223);
            this.Load += new System.EventHandler(this.UCChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_OldPassword;
        private System.Windows.Forms.Label Lb_NewPassword;
        private System.Windows.Forms.Label Lb_ConfirmPassword;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_ShwoOldPassword;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_ShowNewPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox Txtb_OldPassword;
        private System.Windows.Forms.TextBox Txtb_ConfirmPassword;
        private System.Windows.Forms.TextBox Txtb_NewPassword;
    }
}
