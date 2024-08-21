namespace DVLD_UITier.ApplicationOperations
{
    partial class FrmEditApplicationType
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucEditApplicationType1 = new DVLD_UITier.UCEditApplicationType();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_UITier.Properties.Resources.application;
            this.pictureBox1.Location = new System.Drawing.Point(192, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucEditApplicationType1
            // 
            this.ucEditApplicationType1.Fees = 0D;
            this.ucEditApplicationType1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEditApplicationType1.Location = new System.Drawing.Point(12, 253);
            this.ucEditApplicationType1.Name = "ucEditApplicationType1";
            this.ucEditApplicationType1.Size = new System.Drawing.Size(550, 214);
            this.ucEditApplicationType1.TabIndex = 1;
            this.ucEditApplicationType1.Title = null;
            // 
            // Btn_Save
            // 
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.FillColor = System.Drawing.Color.Ivory;
            this.Btn_Save.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Image = global::DVLD_UITier.Properties.Resources.diskette;
            this.Btn_Save.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Save.Location = new System.Drawing.Point(360, 499);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(142, 53);
            this.Btn_Save.TabIndex = 2;
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
            this.Btn_Close.FillColor = System.Drawing.Color.Ivory;
            this.Btn_Close.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(46, 499);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(142, 53);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // FrmEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 564);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.ucEditApplicationType1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Application Type";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private UCEditApplicationType ucEditApplicationType1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Save;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
    }
}