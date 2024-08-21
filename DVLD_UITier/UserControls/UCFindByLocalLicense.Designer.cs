namespace DVLD_UITier.UserControls
{
    partial class UCFindByLocalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFindByLocalLicense));
            this.Btn_Search = new RJCodeAdvance.RJControls.RJButton();
            this.Txtb_FindLicense = new RJCodeAdvance.RJControls.RJTextBox();
            this.Lb_Find = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_Search.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Search.BorderRadius = 0;
            this.Btn_Search.BorderSize = 0;
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.ImageIndex = 2;
            this.Btn_Search.ImageList = this.imageList1;
            this.Btn_Search.Location = new System.Drawing.Point(354, 4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(49, 41);
            this.Btn_Search.TabIndex = 15;
            this.Btn_Search.TextColor = System.Drawing.Color.White;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txtb_FindLicense
            // 
            this.Txtb_FindLicense.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_FindLicense.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_FindLicense.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_FindLicense.BorderRadius = 0;
            this.Txtb_FindLicense.BorderSize = 2;
            this.Txtb_FindLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_FindLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_FindLicense.Location = new System.Drawing.Point(172, 4);
            this.Txtb_FindLicense.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_FindLicense.Multiline = false;
            this.Txtb_FindLicense.Name = "Txtb_FindLicense";
            this.Txtb_FindLicense.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_FindLicense.PasswordChar = false;
            this.Txtb_FindLicense.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_FindLicense.PlaceholderText = "";
            this.Txtb_FindLicense.Size = new System.Drawing.Size(165, 35);
            this.Txtb_FindLicense.TabIndex = 14;
            this.Txtb_FindLicense.Texts = "";
            this.Txtb_FindLicense.UnderlinedStyle = false;
            // 
            // Lb_Find
            // 
            this.Lb_Find.AutoSize = true;
            this.Lb_Find.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Find.Location = new System.Drawing.Point(11, 10);
            this.Lb_Find.Name = "Lb_Find";
            this.Lb_Find.Size = new System.Drawing.Size(147, 24);
            this.Lb_Find.TabIndex = 13;
            this.Lb_Find.Text = "L_License ID";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete-user.png");
            this.imageList1.Images.SetKeyName(1, "add-user(1).png");
            this.imageList1.Images.SetKeyName(2, "search.png");
            // 
            // UCFindByLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Txtb_FindLicense);
            this.Controls.Add(this.Lb_Find);
            this.Name = "UCFindByLocalLicense";
            this.Size = new System.Drawing.Size(420, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton Btn_Search;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_FindLicense;
        private System.Windows.Forms.Label Lb_Find;
        private System.Windows.Forms.ImageList imageList1;
    }
}
