namespace DVLD_UITier.LocalLicenseOperation
{
    partial class FrmIssueLocalLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtb_Notes = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_Issue = new Guna.UI2.WinForms.Guna2Chip();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Chip();
            this.ucDetailApplicationInfo1 = new DVLD_UITier.UserControls.UCDetailApplicationInfo();
            this.ucL_L_ApplicationDetail1 = new DVLD_UITier.UserControls.UCL_L_ApplicationDetail();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local License Application Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Application Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txtb_Notes
            // 
            this.Txtb_Notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtb_Notes.DefaultText = "";
            this.Txtb_Notes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtb_Notes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtb_Notes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtb_Notes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtb_Notes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtb_Notes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Notes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtb_Notes.Location = new System.Drawing.Point(101, 609);
            this.Txtb_Notes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtb_Notes.Multiline = true;
            this.Txtb_Notes.Name = "Txtb_Notes";
            this.Txtb_Notes.PasswordChar = '\0';
            this.Txtb_Notes.PlaceholderText = "";
            this.Txtb_Notes.SelectedText = "";
            this.Txtb_Notes.Size = new System.Drawing.Size(640, 97);
            this.Txtb_Notes.TabIndex = 5;
            this.Txtb_Notes.TextChanged += new System.EventHandler(this.Txtb_Notes_TextChanged);
            // 
            // Btn_Issue
            // 
            this.Btn_Issue.AutoRoundedCorners = true;
            this.Btn_Issue.BorderColor = System.Drawing.Color.SkyBlue;
            this.Btn_Issue.BorderRadius = 19;
            this.Btn_Issue.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Issue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Issue.ForeColor = System.Drawing.Color.White;
            this.Btn_Issue.Location = new System.Drawing.Point(541, 740);
            this.Btn_Issue.Name = "Btn_Issue";
            this.Btn_Issue.Size = new System.Drawing.Size(130, 40);
            this.Btn_Issue.TabIndex = 6;
            this.Btn_Issue.Text = "Issue";
            this.Btn_Issue.Click += new System.EventHandler(this.Btn_Issue_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.AutoRoundedCorners = true;
            this.Btn_Close.BorderColor = System.Drawing.Color.SkyBlue;
            this.Btn_Close.BorderRadius = 19;
            this.Btn_Close.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(119, 740);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(130, 40);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ucDetailApplicationInfo1
            // 
            this.ucDetailApplicationInfo1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDetailApplicationInfo1.Location = new System.Drawing.Point(1, 267);
            this.ucDetailApplicationInfo1.Name = "ucDetailApplicationInfo1";
            this.ucDetailApplicationInfo1.Size = new System.Drawing.Size(777, 320);
            this.ucDetailApplicationInfo1.TabIndex = 1;
            // 
            // ucL_L_ApplicationDetail1
            // 
            this.ucL_L_ApplicationDetail1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucL_L_ApplicationDetail1.Location = new System.Drawing.Point(1, 19);
            this.ucL_L_ApplicationDetail1.Name = "ucL_L_ApplicationDetail1";
            this.ucL_L_ApplicationDetail1.Size = new System.Drawing.Size(777, 201);
            this.ucL_L_ApplicationDetail1.TabIndex = 0;
            // 
            // FrmIssueLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 806);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Issue);
            this.Controls.Add(this.Txtb_Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucDetailApplicationInfo1);
            this.Controls.Add(this.ucL_L_ApplicationDetail1);
            this.Name = "FrmIssueLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Local License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UCL_L_ApplicationDetail ucL_L_ApplicationDetail1;
        private UserControls.UCDetailApplicationInfo ucDetailApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Txtb_Notes;
        private Guna.UI2.WinForms.Guna2Chip Btn_Issue;
        private Guna.UI2.WinForms.Guna2Chip Btn_Close;
    }
}