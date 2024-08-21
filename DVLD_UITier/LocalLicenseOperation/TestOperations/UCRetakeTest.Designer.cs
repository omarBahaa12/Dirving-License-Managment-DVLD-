namespace DVLD_UITier.UserControls
{
    partial class UCRetakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRetakeTest));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_RTestFees = new System.Windows.Forms.Label();
            this.Lb_RL_L_applicationID = new System.Windows.Forms.Label();
            this.Lb_TotalFees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retake Test Fees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "coin.png");
            this.imageList1.Images.SetKeyName(1, "id.png");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "R_L_LAppication ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(3, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Fees";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lb_RTestFees
            // 
            this.Lb_RTestFees.AutoSize = true;
            this.Lb_RTestFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_RTestFees.Location = new System.Drawing.Point(226, 21);
            this.Lb_RTestFees.Name = "Lb_RTestFees";
            this.Lb_RTestFees.Size = new System.Drawing.Size(26, 18);
            this.Lb_RTestFees.TabIndex = 3;
            this.Lb_RTestFees.Text = "??";
            // 
            // Lb_RL_L_applicationID
            // 
            this.Lb_RL_L_applicationID.AutoSize = true;
            this.Lb_RL_L_applicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_RL_L_applicationID.Location = new System.Drawing.Point(239, 95);
            this.Lb_RL_L_applicationID.Name = "Lb_RL_L_applicationID";
            this.Lb_RL_L_applicationID.Size = new System.Drawing.Size(26, 18);
            this.Lb_RL_L_applicationID.TabIndex = 4;
            this.Lb_RL_L_applicationID.Text = "??";
            // 
            // Lb_TotalFees
            // 
            this.Lb_TotalFees.AutoSize = true;
            this.Lb_TotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TotalFees.Location = new System.Drawing.Point(179, 162);
            this.Lb_TotalFees.Name = "Lb_TotalFees";
            this.Lb_TotalFees.Size = new System.Drawing.Size(26, 18);
            this.Lb_TotalFees.TabIndex = 5;
            this.Lb_TotalFees.Text = "??";
            // 
            // UCRetakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lb_TotalFees);
            this.Controls.Add(this.Lb_RL_L_applicationID);
            this.Controls.Add(this.Lb_RTestFees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCRetakeTest";
            this.Size = new System.Drawing.Size(436, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Lb_RTestFees;
        private System.Windows.Forms.Label Lb_RL_L_applicationID;
        private System.Windows.Forms.Label Lb_TotalFees;
    }
}
