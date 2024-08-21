namespace DVLD_UITier
{
    partial class UCEditApplicationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEditApplicationType));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lb_Fees = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Txtb_Title = new RJCodeAdvance.RJControls.RJTextBox();
            this.TXtb_Fees = new RJCodeAdvance.RJControls.RJTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coin.png");
            this.imageList1.Images.SetKeyName(1, "title.png");
            // 
            // Lb_Fees
            // 
            this.Lb_Fees.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Fees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Fees.ImageIndex = 0;
            this.Lb_Fees.ImageList = this.imageList1;
            this.Lb_Fees.Location = new System.Drawing.Point(19, 119);
            this.Lb_Fees.Name = "Lb_Fees";
            this.Lb_Fees.Size = new System.Drawing.Size(100, 42);
            this.Lb_Fees.TabIndex = 1;
            this.Lb_Fees.Text = "Fees";
            this.Lb_Fees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_Title
            // 
            this.Lb_Title.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lb_Title.ImageIndex = 1;
            this.Lb_Title.ImageList = this.imageList1;
            this.Lb_Title.Location = new System.Drawing.Point(19, 31);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(100, 31);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "Title";
            this.Lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Txtb_Title
            // 
            this.Txtb_Title.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_Title.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_Title.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_Title.BorderRadius = 0;
            this.Txtb_Title.BorderSize = 2;
            this.Txtb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_Title.Location = new System.Drawing.Point(202, 27);
            this.Txtb_Title.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_Title.Multiline = false;
            this.Txtb_Title.Name = "Txtb_Title";
            this.Txtb_Title.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_Title.PasswordChar = false;
            this.Txtb_Title.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_Title.PlaceholderText = "";
            this.Txtb_Title.Size = new System.Drawing.Size(157, 35);
            this.Txtb_Title.TabIndex = 2;
            this.Txtb_Title.Texts = "";
            this.Txtb_Title.UnderlinedStyle = false;
            this.Txtb_Title._TextChanged += new System.EventHandler(this.Txtb_Title__TextChanged);
            // 
            // TXtb_Fees
            // 
            this.TXtb_Fees.BackColor = System.Drawing.SystemColors.Window;
            this.TXtb_Fees.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TXtb_Fees.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TXtb_Fees.BorderRadius = 0;
            this.TXtb_Fees.BorderSize = 2;
            this.TXtb_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXtb_Fees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TXtb_Fees.Location = new System.Drawing.Point(207, 119);
            this.TXtb_Fees.Margin = new System.Windows.Forms.Padding(4);
            this.TXtb_Fees.Multiline = false;
            this.TXtb_Fees.Name = "TXtb_Fees";
            this.TXtb_Fees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TXtb_Fees.PasswordChar = false;
            this.TXtb_Fees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TXtb_Fees.PlaceholderText = "";
            this.TXtb_Fees.Size = new System.Drawing.Size(152, 35);
            this.TXtb_Fees.TabIndex = 3;
            this.TXtb_Fees.Texts = "";
            this.TXtb_Fees.UnderlinedStyle = false;
            this.TXtb_Fees._TextChanged += new System.EventHandler(this.TXtb_Fees__TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TXtb_Fees);
            this.Controls.Add(this.Txtb_Title);
            this.Controls.Add(this.Lb_Fees);
            this.Controls.Add(this.Lb_Title);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCEditApplicationType";
            this.Size = new System.Drawing.Size(460, 183);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label Lb_Fees;
        private System.Windows.Forms.ImageList imageList1;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_Title;
        private RJCodeAdvance.RJControls.RJTextBox TXtb_Fees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
