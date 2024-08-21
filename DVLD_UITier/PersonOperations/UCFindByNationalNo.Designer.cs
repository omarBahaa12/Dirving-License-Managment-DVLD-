namespace DVLD_UITier
{
    partial class UCFindByNationalNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFindByNationalNo));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Txtb_FindPerson = new RJCodeAdvance.RJControls.RJTextBox();
            this.Lb_Find = new System.Windows.Forms.Label();
            this.Btn_Search = new RJCodeAdvance.RJControls.RJButton();
            this.Btn_AddPerson = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete-user.png");
            this.imageList1.Images.SetKeyName(1, "add-user(1).png");
            this.imageList1.Images.SetKeyName(2, "search.png");
            // 
            // Txtb_FindPerson
            // 
            this.Txtb_FindPerson.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_FindPerson.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_FindPerson.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_FindPerson.BorderRadius = 0;
            this.Txtb_FindPerson.BorderSize = 2;
            this.Txtb_FindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_FindPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_FindPerson.Location = new System.Drawing.Point(172, 4);
            this.Txtb_FindPerson.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_FindPerson.Multiline = false;
            this.Txtb_FindPerson.Name = "Txtb_FindPerson";
            this.Txtb_FindPerson.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_FindPerson.PasswordChar = false;
            this.Txtb_FindPerson.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_FindPerson.PlaceholderText = "";
            this.Txtb_FindPerson.Size = new System.Drawing.Size(165, 35);
            this.Txtb_FindPerson.TabIndex = 10;
            this.Txtb_FindPerson.Texts = "";
            this.Txtb_FindPerson.UnderlinedStyle = false;
            // 
            // Lb_Find
            // 
            this.Lb_Find.AutoSize = true;
            this.Lb_Find.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Find.Location = new System.Drawing.Point(11, 10);
            this.Lb_Find.Name = "Lb_Find";
            this.Lb_Find.Size = new System.Drawing.Size(142, 24);
            this.Lb_Find.TabIndex = 9;
            this.Lb_Find.Text = "National No.";
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
            this.Btn_Search.TabIndex = 11;
            this.Btn_Search.TextColor = System.Drawing.Color.White;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_AddPerson
            // 
            this.Btn_AddPerson.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_AddPerson.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_AddPerson.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_AddPerson.BorderRadius = 0;
            this.Btn_AddPerson.BorderSize = 0;
            this.Btn_AddPerson.FlatAppearance.BorderSize = 0;
            this.Btn_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddPerson.ForeColor = System.Drawing.Color.White;
            this.Btn_AddPerson.ImageIndex = 1;
            this.Btn_AddPerson.ImageList = this.imageList1;
            this.Btn_AddPerson.Location = new System.Drawing.Point(430, 4);
            this.Btn_AddPerson.Name = "Btn_AddPerson";
            this.Btn_AddPerson.Size = new System.Drawing.Size(52, 41);
            this.Btn_AddPerson.TabIndex = 12;
            this.Btn_AddPerson.TextColor = System.Drawing.Color.White;
            this.Btn_AddPerson.UseVisualStyleBackColor = false;
            this.Btn_AddPerson.Click += new System.EventHandler(this.Btn_AddPerson_Click);
            // 
            // UCFindByNationalNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_AddPerson);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Txtb_FindPerson);
            this.Controls.Add(this.Lb_Find);
            this.Name = "UCFindByNationalNo";
            this.Size = new System.Drawing.Size(509, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton Btn_Search;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_FindPerson;
        private System.Windows.Forms.Label Lb_Find;
        private System.Windows.Forms.ImageList imageList1;
        private RJCodeAdvance.RJControls.RJButton Btn_AddPerson;
    }
}
