namespace DVLD_UITier
{
    partial class FrmShowDetailedInformation
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
            this.Btn_Cancel1 = new RJCodeAdvance.RJControls.RJButton();
            this.ucDetailedInfo2 = new DVLD_UITier.UCDetailedInfo();
            this.SuspendLayout();
            // 
            // Btn_Cancel1
            // 
            this.Btn_Cancel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Cancel1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Cancel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Cancel1.BorderRadius = 0;
            this.Btn_Cancel1.BorderSize = 0;
            this.Btn_Cancel1.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel1.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel1.Location = new System.Drawing.Point(572, 353);
            this.Btn_Cancel1.Name = "Btn_Cancel1";
            this.Btn_Cancel1.Size = new System.Drawing.Size(150, 40);
            this.Btn_Cancel1.TabIndex = 1;
            this.Btn_Cancel1.Text = "Cancel";
            this.Btn_Cancel1.TextColor = System.Drawing.Color.White;
            this.Btn_Cancel1.UseVisualStyleBackColor = false;
            this.Btn_Cancel1.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // ucDetailedInfo2
            // 
            this.ucDetailedInfo2.ID = 0;
            this.ucDetailedInfo2.Location = new System.Drawing.Point(-2, 1);
            this.ucDetailedInfo2.Name = "ucDetailedInfo2";
            this.ucDetailedInfo2.Size = new System.Drawing.Size(869, 424);
            this.ucDetailedInfo2.TabIndex = 0;
            // 
            // FrmShowDetailedInformation
            // 
            this.ClientSize = new System.Drawing.Size(879, 430);
            this.Controls.Add(this.Btn_Cancel1);
            this.Controls.Add(this.ucDetailedInfo2);
            this.Name = "FrmShowDetailedInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Informations";
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton Btn_Cancel;
        private System.Windows.Forms.ImageList imageList1;
        private UCDetailedInfo ucDetailedInfo2;
        private RJCodeAdvance.RJControls.RJButton Btn_Cancel1;
    }
}