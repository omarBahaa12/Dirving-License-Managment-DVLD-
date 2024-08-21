namespace DVLD_UITier.LocalLicenseOperation
{
    partial class FrmShowL_L_ApplicationDetailed
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
            this.ucDetailedInfo1 = new DVLD_UITier.UCDetailedInfo();
            this.ucL_L_ApplicationDetail1 = new DVLD_UITier.UserControls.UCL_L_ApplicationDetail();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // ucDetailedInfo1
            // 
            this.ucDetailedInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDetailedInfo1.ID = 0;
            this.ucDetailedInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucDetailedInfo1.Name = "ucDetailedInfo1";
            this.ucDetailedInfo1.Size = new System.Drawing.Size(919, 405);
            this.ucDetailedInfo1.TabIndex = 0;
            // 
            // ucL_L_ApplicationDetail1
            // 
            this.ucL_L_ApplicationDetail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucL_L_ApplicationDetail1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucL_L_ApplicationDetail1.Location = new System.Drawing.Point(0, 405);
            this.ucL_L_ApplicationDetail1.Name = "ucL_L_ApplicationDetail1";
            this.ucL_L_ApplicationDetail1.Size = new System.Drawing.Size(919, 125);
            this.ucL_L_ApplicationDetail1.TabIndex = 1;
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.Teal;
            this.Btn_Close.FillColor2 = System.Drawing.Color.MediumAquamarine;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(702, 563);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(136, 45);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // FrmShowL_L_ApplicationDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 624);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.ucL_L_ApplicationDetail1);
            this.Controls.Add(this.ucDetailedInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowL_L_ApplicationDetailed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local License Application";
            this.ResumeLayout(false);

        }

        #endregion

        private UCDetailedInfo ucDetailedInfo1;
        private UserControls.UCL_L_ApplicationDetail ucL_L_ApplicationDetail1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
    }
}