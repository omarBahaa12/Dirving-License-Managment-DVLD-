namespace DVLD_UITier.UserControls
{
    partial class UCEditTestType
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
            this.Lb_TestName = new System.Windows.Forms.Label();
            this.Lb_Description = new System.Windows.Forms.Label();
            this.Lb_Fees = new System.Windows.Forms.Label();
            this.Txtb_TestName = new RJCodeAdvance.RJControls.RJTextBox();
            this.Txtb_Description = new RJCodeAdvance.RJControls.RJTextBox();
            this.Textb_Fees = new RJCodeAdvance.RJControls.RJTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_TestName
            // 
            this.Lb_TestName.AutoSize = true;
            this.Lb_TestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TestName.Location = new System.Drawing.Point(13, 11);
            this.Lb_TestName.Name = "Lb_TestName";
            this.Lb_TestName.Size = new System.Drawing.Size(108, 25);
            this.Lb_TestName.TabIndex = 0;
            this.Lb_TestName.Text = "Test Name";
            // 
            // Lb_Description
            // 
            this.Lb_Description.AutoSize = true;
            this.Lb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Description.Location = new System.Drawing.Point(12, 87);
            this.Lb_Description.Name = "Lb_Description";
            this.Lb_Description.Size = new System.Drawing.Size(109, 25);
            this.Lb_Description.TabIndex = 1;
            this.Lb_Description.Text = "Description";
            // 
            // Lb_Fees
            // 
            this.Lb_Fees.AutoSize = true;
            this.Lb_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fees.Location = new System.Drawing.Point(41, 162);
            this.Lb_Fees.Name = "Lb_Fees";
            this.Lb_Fees.Size = new System.Drawing.Size(56, 25);
            this.Lb_Fees.TabIndex = 2;
            this.Lb_Fees.Text = "Fees";
            // 
            // Txtb_TestName
            // 
            this.Txtb_TestName.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_TestName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_TestName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_TestName.BorderRadius = 0;
            this.Txtb_TestName.BorderSize = 2;
            this.Txtb_TestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_TestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_TestName.Location = new System.Drawing.Point(128, 11);
            this.Txtb_TestName.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_TestName.Multiline = false;
            this.Txtb_TestName.Name = "Txtb_TestName";
            this.Txtb_TestName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_TestName.PasswordChar = false;
            this.Txtb_TestName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_TestName.PlaceholderText = "";
            this.Txtb_TestName.Size = new System.Drawing.Size(224, 35);
            this.Txtb_TestName.TabIndex = 3;
            this.Txtb_TestName.Texts = "";
            this.Txtb_TestName.UnderlinedStyle = false;
            this.Txtb_TestName._TextChanged += new System.EventHandler(this.Txtb_TestName__TextChanged);
            // 
            // Txtb_Description
            // 
            this.Txtb_Description.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_Description.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_Description.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_Description.BorderRadius = 0;
            this.Txtb_Description.BorderSize = 2;
            this.Txtb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_Description.Location = new System.Drawing.Point(128, 65);
            this.Txtb_Description.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_Description.Multiline = true;
            this.Txtb_Description.Name = "Txtb_Description";
            this.Txtb_Description.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_Description.PasswordChar = false;
            this.Txtb_Description.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_Description.PlaceholderText = "";
            this.Txtb_Description.Size = new System.Drawing.Size(412, 75);
            this.Txtb_Description.TabIndex = 4;
            this.Txtb_Description.Texts = "";
            this.Txtb_Description.UnderlinedStyle = false;
            this.Txtb_Description._TextChanged += new System.EventHandler(this.Txtb_Description__TextChanged);
            // 
            // Textb_Fees
            // 
            this.Textb_Fees.BackColor = System.Drawing.SystemColors.Window;
            this.Textb_Fees.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Textb_Fees.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Textb_Fees.BorderRadius = 0;
            this.Textb_Fees.BorderSize = 2;
            this.Textb_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textb_Fees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textb_Fees.Location = new System.Drawing.Point(149, 160);
            this.Textb_Fees.Margin = new System.Windows.Forms.Padding(4);
            this.Textb_Fees.Multiline = true;
            this.Textb_Fees.Name = "Textb_Fees";
            this.Textb_Fees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Textb_Fees.PasswordChar = false;
            this.Textb_Fees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Textb_Fees.PlaceholderText = "";
            this.Textb_Fees.Size = new System.Drawing.Size(224, 35);
            this.Textb_Fees.TabIndex = 5;
            this.Textb_Fees.Texts = "";
            this.Textb_Fees.UnderlinedStyle = false;
            this.Textb_Fees._TextChanged += new System.EventHandler(this.Textb_Fees__TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCEditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Textb_Fees);
            this.Controls.Add(this.Txtb_Description);
            this.Controls.Add(this.Txtb_TestName);
            this.Controls.Add(this.Lb_Fees);
            this.Controls.Add(this.Lb_Description);
            this.Controls.Add(this.Lb_TestName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCEditTestType";
            this.Size = new System.Drawing.Size(695, 226);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_TestName;
        private System.Windows.Forms.Label Lb_Description;
        private System.Windows.Forms.Label Lb_Fees;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_TestName;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_Description;
        private RJCodeAdvance.RJControls.RJTextBox Textb_Fees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
