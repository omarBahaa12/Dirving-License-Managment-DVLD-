namespace DVLD_UITier.UserControls
{
    partial class UCAddLocalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddLocalLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_LicenseClass = new System.Windows.Forms.Label();
            this.Lb_CreatedBy = new System.Windows.Forms.Label();
            this.Lb_ShowL_L_ApplicationID = new System.Windows.Forms.Label();
            this.Lb_ShowApplicationDate = new System.Windows.Forms.Label();
            this.Lb_Creator = new System.Windows.Forms.Label();
            this.Cmb_LicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Lb_Fees = new System.Windows.Forms.Label();
            this.Lb_ShowFees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "L.L.Application ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "id.png");
            this.imageList1.Images.SetKeyName(1, "coin.png");
            this.imageList1.Images.SetKeyName(2, "active-user.png");
            this.imageList1.Images.SetKeyName(3, "schedule.png");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.ImageIndex = 3;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(3, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_LicenseClass
            // 
            this.Lb_LicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_LicenseClass.Location = new System.Drawing.Point(3, 248);
            this.Lb_LicenseClass.Name = "Lb_LicenseClass";
            this.Lb_LicenseClass.Size = new System.Drawing.Size(184, 48);
            this.Lb_LicenseClass.TabIndex = 2;
            this.Lb_LicenseClass.Text = "License Class";
            this.Lb_LicenseClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_CreatedBy
            // 
            this.Lb_CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CreatedBy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_CreatedBy.ImageIndex = 2;
            this.Lb_CreatedBy.ImageList = this.imageList1;
            this.Lb_CreatedBy.Location = new System.Drawing.Point(3, 393);
            this.Lb_CreatedBy.Name = "Lb_CreatedBy";
            this.Lb_CreatedBy.Size = new System.Drawing.Size(167, 53);
            this.Lb_CreatedBy.TabIndex = 3;
            this.Lb_CreatedBy.Text = "Created By";
            this.Lb_CreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ShowL_L_ApplicationID
            // 
            this.Lb_ShowL_L_ApplicationID.AutoSize = true;
            this.Lb_ShowL_L_ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowL_L_ApplicationID.Location = new System.Drawing.Point(228, 45);
            this.Lb_ShowL_L_ApplicationID.Name = "Lb_ShowL_L_ApplicationID";
            this.Lb_ShowL_L_ApplicationID.Size = new System.Drawing.Size(46, 25);
            this.Lb_ShowL_L_ApplicationID.TabIndex = 4;
            this.Lb_ShowL_L_ApplicationID.Text = "N/A";
            this.Lb_ShowL_L_ApplicationID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ShowApplicationDate
            // 
            this.Lb_ShowApplicationDate.AutoSize = true;
            this.Lb_ShowApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowApplicationDate.Location = new System.Drawing.Point(228, 159);
            this.Lb_ShowApplicationDate.Name = "Lb_ShowApplicationDate";
            this.Lb_ShowApplicationDate.Size = new System.Drawing.Size(0, 25);
            this.Lb_ShowApplicationDate.TabIndex = 5;
            this.Lb_ShowApplicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Creator
            // 
            this.Lb_Creator.AutoSize = true;
            this.Lb_Creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Creator.Location = new System.Drawing.Point(218, 408);
            this.Lb_Creator.Name = "Lb_Creator";
            this.Lb_Creator.Size = new System.Drawing.Size(0, 25);
            this.Lb_Creator.TabIndex = 6;
            this.Lb_Creator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cmb_LicenseClass
            // 
            this.Cmb_LicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_LicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_LicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_LicenseClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_LicenseClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_LicenseClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_LicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cmb_LicenseClass.ItemHeight = 30;
            this.Cmb_LicenseClass.Location = new System.Drawing.Point(222, 248);
            this.Cmb_LicenseClass.Name = "Cmb_LicenseClass";
            this.Cmb_LicenseClass.Size = new System.Drawing.Size(330, 36);
            this.Cmb_LicenseClass.TabIndex = 7;
            this.Cmb_LicenseClass.SelectedIndexChanged += new System.EventHandler(this.Cmb_LicenseClass_SelectedIndexChanged);
            // 
            // Lb_Fees
            // 
            this.Lb_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Fees.ImageIndex = 1;
            this.Lb_Fees.ImageList = this.imageList1;
            this.Lb_Fees.Location = new System.Drawing.Point(3, 331);
            this.Lb_Fees.Name = "Lb_Fees";
            this.Lb_Fees.Size = new System.Drawing.Size(122, 53);
            this.Lb_Fees.TabIndex = 8;
            this.Lb_Fees.Text = "Fees";
            this.Lb_Fees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ShowFees
            // 
            this.Lb_ShowFees.AutoSize = true;
            this.Lb_ShowFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ShowFees.Location = new System.Drawing.Point(187, 344);
            this.Lb_ShowFees.Name = "Lb_ShowFees";
            this.Lb_ShowFees.Size = new System.Drawing.Size(0, 25);
            this.Lb_ShowFees.TabIndex = 9;
            this.Lb_ShowFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCAddLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lb_ShowFees);
            this.Controls.Add(this.Lb_Fees);
            this.Controls.Add(this.Cmb_LicenseClass);
            this.Controls.Add(this.Lb_Creator);
            this.Controls.Add(this.Lb_ShowApplicationDate);
            this.Controls.Add(this.Lb_ShowL_L_ApplicationID);
            this.Controls.Add(this.Lb_CreatedBy);
            this.Controls.Add(this.Lb_LicenseClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCAddLocalLicense";
            this.Size = new System.Drawing.Size(652, 456);
            this.Load += new System.EventHandler(this.UCAddLocalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_LicenseClass;
        private System.Windows.Forms.Label Lb_CreatedBy;
        private System.Windows.Forms.Label Lb_ShowL_L_ApplicationID;
        private System.Windows.Forms.Label Lb_ShowApplicationDate;
        private System.Windows.Forms.Label Lb_Creator;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_LicenseClass;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Lb_Fees;
        private System.Windows.Forms.Label Lb_ShowFees;
    }
}
