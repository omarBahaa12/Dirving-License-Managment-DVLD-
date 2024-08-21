namespace DVLD_UITier
{
    partial class FrmUpdatePerson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdatePerson));
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Save = new System.Windows.Forms.Button();
            this.ucAddPerson1 = new DVLD_UITier.UCAddPerson();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancel.ImageIndex = 2;
            this.Btn_Cancel.ImageList = this.imageList1;
            this.Btn_Cancel.Location = new System.Drawing.Point(569, 586);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(130, 51);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "diskette.png");
            this.imageList1.Images.SetKeyName(1, "circle-xmark.png");
            this.imageList1.Images.SetKeyName(2, "cross.png");
            this.imageList1.Images.SetKeyName(3, "happy-birthday.png");
            this.imageList1.Images.SetKeyName(4, "location.png");
            this.imageList1.Images.SetKeyName(5, "telephone.png");
            this.imageList1.Images.SetKeyName(6, "email.png");
            this.imageList1.Images.SetKeyName(7, "id-card(1).png");
            this.imageList1.Images.SetKeyName(8, "id-card.png");
            this.imageList1.Images.SetKeyName(9, "location.png");
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Save.ImageIndex = 0;
            this.Btn_Save.ImageList = this.imageList1;
            this.Btn_Save.Location = new System.Drawing.Point(856, 586);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(126, 51);
            this.Btn_Save.TabIndex = 7;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // ucAddPerson1
            // 
            this.ucAddPerson1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucAddPerson1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAddPerson1.Location = new System.Drawing.Point(0, 1);
            this.ucAddPerson1.Margin = new System.Windows.Forms.Padding(4);
            this.ucAddPerson1.Name = "ucAddPerson1";
            this.ucAddPerson1.Size = new System.Drawing.Size(1215, 544);
            this.ucAddPerson1.TabIndex = 9;
            // 
            // FrmUpdatePerson
            // 
            this.AcceptButton = this.Btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(1216, 649);
            this.Controls.Add(this.ucAddPerson1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Person";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ImageList imageList1;
        private UCAddPerson ucAddPerson1;
    }
}