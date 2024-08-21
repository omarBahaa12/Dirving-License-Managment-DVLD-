namespace DVLD_UITier.UserControls
{
    partial class UCDetailApplicationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDetailApplicationInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lb_ID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lb_Status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lb_Fees = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lb_CreatedBy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lb_FullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lb_ApplicationType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Lb_Date = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 2;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coin.png");
            this.imageList1.Images.SetKeyName(1, "title.png");
            this.imageList1.Images.SetKeyName(2, "id.png");
            this.imageList1.Images.SetKeyName(3, "id-card.png");
            this.imageList1.Images.SetKeyName(4, "edit-info.png");
            this.imageList1.Images.SetKeyName(5, "type.png");
            this.imageList1.Images.SetKeyName(6, "schedule.png");
            // 
            // label2
            // 
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(346, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(395, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fees";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.ImageIndex = 4;
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(330, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Created By";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.ImageIndex = 5;
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(3, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.ImageIndex = 3;
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(3, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Full Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_ID
            // 
            this.Lb_ID.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ID.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.Location = new System.Drawing.Point(124, 22);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(17, 20);
            this.Lb_ID.TabIndex = 6;
            this.Lb_ID.Text = "??";
            // 
            // Lb_Status
            // 
            this.Lb_Status.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Status.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Status.Location = new System.Drawing.Point(474, 22);
            this.Lb_Status.Name = "Lb_Status";
            this.Lb_Status.Size = new System.Drawing.Size(17, 20);
            this.Lb_Status.TabIndex = 7;
            this.Lb_Status.Text = "??";
            // 
            // Lb_Fees
            // 
            this.Lb_Fees.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Fees.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fees.Location = new System.Drawing.Point(507, 147);
            this.Lb_Fees.Name = "Lb_Fees";
            this.Lb_Fees.Size = new System.Drawing.Size(17, 20);
            this.Lb_Fees.TabIndex = 8;
            this.Lb_Fees.Text = "??";
            // 
            // Lb_CreatedBy
            // 
            this.Lb_CreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.Lb_CreatedBy.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CreatedBy.Location = new System.Drawing.Point(479, 75);
            this.Lb_CreatedBy.Name = "Lb_CreatedBy";
            this.Lb_CreatedBy.Size = new System.Drawing.Size(17, 20);
            this.Lb_CreatedBy.TabIndex = 9;
            this.Lb_CreatedBy.Text = "??";
            // 
            // Lb_FullName
            // 
            this.Lb_FullName.BackColor = System.Drawing.Color.Transparent;
            this.Lb_FullName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FullName.Location = new System.Drawing.Point(136, 147);
            this.Lb_FullName.Name = "Lb_FullName";
            this.Lb_FullName.Size = new System.Drawing.Size(17, 20);
            this.Lb_FullName.TabIndex = 10;
            this.Lb_FullName.Text = "??";
            // 
            // Lb_ApplicationType
            // 
            this.Lb_ApplicationType.BackColor = System.Drawing.Color.Transparent;
            this.Lb_ApplicationType.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ApplicationType.Location = new System.Drawing.Point(124, 228);
            this.Lb_ApplicationType.Name = "Lb_ApplicationType";
            this.Lb_ApplicationType.Size = new System.Drawing.Size(17, 20);
            this.Lb_ApplicationType.TabIndex = 11;
            this.Lb_ApplicationType.Text = "??";
            // 
            // Lb_Date
            // 
            this.Lb_Date.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Date.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Date.Location = new System.Drawing.Point(105, 90);
            this.Lb_Date.Name = "Lb_Date";
            this.Lb_Date.Size = new System.Drawing.Size(17, 20);
            this.Lb_Date.TabIndex = 13;
            this.Lb_Date.Text = "??";
            // 
            // label7
            // 
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.ImageIndex = 6;
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(400, 218);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Person Info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UCDetailApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Lb_Date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lb_ApplicationType);
            this.Controls.Add(this.Lb_FullName);
            this.Controls.Add(this.Lb_CreatedBy);
            this.Controls.Add(this.Lb_Fees);
            this.Controls.Add(this.Lb_Status);
            this.Controls.Add(this.Lb_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCDetailApplicationInfo";
            this.Size = new System.Drawing.Size(625, 280);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lb_ID;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lb_Status;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lb_Fees;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lb_CreatedBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lb_FullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lb_ApplicationType;
        private Guna.UI2.WinForms.Guna2HtmlLabel Lb_Date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
