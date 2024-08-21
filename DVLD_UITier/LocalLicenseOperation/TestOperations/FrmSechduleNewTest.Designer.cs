namespace DVLD_UITier.LocalLicenseOperation.TestOperations
{
    partial class FrmSechduleNewTest
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
            this.Lb_TestName = new System.Windows.Forms.Label();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucRetakeTest1 = new DVLD_UITier.UserControls.UCRetakeTest();
            this.ucSechduleTestL_L_Application1 = new DVLD_UITier.UserControls.UCSechduleTestL_L_Application();
            this.SuspendLayout();
            // 
            // Lb_TestName
            // 
            this.Lb_TestName.AutoSize = true;
            this.Lb_TestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TestName.ForeColor = System.Drawing.Color.Red;
            this.Lb_TestName.Location = new System.Drawing.Point(163, 9);
            this.Lb_TestName.Name = "Lb_TestName";
            this.Lb_TestName.Size = new System.Drawing.Size(36, 25);
            this.Lb_TestName.TabIndex = 1;
            this.Lb_TestName.Text = "??";
            // 
            // Btn_Save
            // 
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.FillColor = System.Drawing.Color.White;
            this.Btn_Save.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::DVLD_UITier.Properties.Resources.diskette;
            this.Btn_Save.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Save.Location = new System.Drawing.Point(351, 668);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(147, 45);
            this.Btn_Save.TabIndex = 4;
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
            this.Btn_Close.FillColor = System.Drawing.Color.White;
            this.Btn_Close.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(52, 668);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(147, 45);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ucRetakeTest1
            // 
            this.ucRetakeTest1.Location = new System.Drawing.Point(3, 398);
            this.ucRetakeTest1.Name = "ucRetakeTest1";
            this.ucRetakeTest1.Size = new System.Drawing.Size(550, 199);
            this.ucRetakeTest1.TabIndex = 3;
            // 
            // ucSechduleTestL_L_Application1
            // 
            this.ucSechduleTestL_L_Application1.Location = new System.Drawing.Point(3, 47);
            this.ucSechduleTestL_L_Application1.Name = "ucSechduleTestL_L_Application1";
            this.ucSechduleTestL_L_Application1.Size = new System.Drawing.Size(548, 345);
            this.ucSechduleTestL_L_Application1.TabIndex = 2;
            // 
            // FrmSechduleNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 745);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.ucRetakeTest1);
            this.Controls.Add(this.ucSechduleTestL_L_Application1);
            this.Controls.Add(this.Lb_TestName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSechduleNewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sechdule Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lb_TestName;
        private UserControls.UCSechduleTestL_L_Application ucSechduleTestL_L_Application1;
        private UserControls.UCRetakeTest ucRetakeTest1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Save;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
    }
}