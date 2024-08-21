namespace DVLD_UITier.LocalLicenseOperation.TestOperations
{
    partial class FrmShowTestAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowTestAppointment));
            this.DG_TestAppointment = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lb_TestName = new System.Windows.Forms.Label();
            this.Btn_AddAppointment = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ucDetailApplicationInfo1 = new DVLD_UITier.UserControls.UCDetailApplicationInfo();
            this.ucL_L_ApplicationDetail1 = new DVLD_UITier.UserControls.UCL_L_ApplicationDetail();
            ((System.ComponentModel.ISupportInitialize)(this.DG_TestAppointment)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_TestAppointment
            // 
            this.DG_TestAppointment.AllowUserToAddRows = false;
            this.DG_TestAppointment.AllowUserToDeleteRows = false;
            this.DG_TestAppointment.AllowUserToResizeColumns = false;
            this.DG_TestAppointment.AllowUserToResizeRows = false;
            this.DG_TestAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_TestAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_TestAppointment.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DG_TestAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_TestAppointment.ContextMenuStrip = this.ContextMenuStrip1;
            this.DG_TestAppointment.GridColor = System.Drawing.SystemColors.Highlight;
            this.DG_TestAppointment.Location = new System.Drawing.Point(12, 657);
            this.DG_TestAppointment.Name = "DG_TestAppointment";
            this.DG_TestAppointment.RowHeadersWidth = 51;
            this.DG_TestAppointment.RowTemplate.Height = 24;
            this.DG_TestAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_TestAppointment.Size = new System.Drawing.Size(795, 126);
            this.DG_TestAppointment.TabIndex = 4;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStrip1.Size = new System.Drawing.Size(158, 64);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.contract;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.test;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Local Driving L.Application info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Basic Application info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Appointment";
            // 
            // Lb_TestName
            // 
            this.Lb_TestName.AutoSize = true;
            this.Lb_TestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TestName.ForeColor = System.Drawing.Color.Red;
            this.Lb_TestName.Location = new System.Drawing.Point(335, 9);
            this.Lb_TestName.Name = "Lb_TestName";
            this.Lb_TestName.Size = new System.Drawing.Size(34, 25);
            this.Lb_TestName.TabIndex = 16;
            this.Lb_TestName.Text = "??";
            // 
            // Btn_AddAppointment
            // 
            this.Btn_AddAppointment.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_AddAppointment.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_AddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddAppointment.Image")));
            this.Btn_AddAppointment.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_AddAppointment.ImageRotate = 0F;
            this.Btn_AddAppointment.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_AddAppointment.Location = new System.Drawing.Point(755, 607);
            this.Btn_AddAppointment.Name = "Btn_AddAppointment";
            this.Btn_AddAppointment.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_AddAppointment.Size = new System.Drawing.Size(40, 44);
            this.Btn_AddAppointment.TabIndex = 10;
            this.Btn_AddAppointment.Click += new System.EventHandler(this.Btn_AddAppointment_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.White;
            this.Btn_Close.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_Close.Location = new System.Drawing.Point(624, 789);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(146, 45);
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ucDetailApplicationInfo1
            // 
            this.ucDetailApplicationInfo1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDetailApplicationInfo1.Location = new System.Drawing.Point(12, 287);
            this.ucDetailApplicationInfo1.Name = "ucDetailApplicationInfo1";
            this.ucDetailApplicationInfo1.Size = new System.Drawing.Size(804, 314);
            this.ucDetailApplicationInfo1.TabIndex = 12;
            // 
            // ucL_L_ApplicationDetail1
            // 
            this.ucL_L_ApplicationDetail1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucL_L_ApplicationDetail1.Location = new System.Drawing.Point(12, 48);
            this.ucL_L_ApplicationDetail1.Name = "ucL_L_ApplicationDetail1";
            this.ucL_L_ApplicationDetail1.Size = new System.Drawing.Size(804, 194);
            this.ucL_L_ApplicationDetail1.TabIndex = 11;
            // 
            // FrmShowTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 868);
            this.Controls.Add(this.Lb_TestName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucDetailApplicationInfo1);
            this.Controls.Add(this.ucL_L_ApplicationDetail1);
            this.Controls.Add(this.Btn_AddAppointment);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.DG_TestAppointment);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowTestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sechdule Test";
            ((System.ComponentModel.ISupportInitialize)(this.DG_TestAppointment)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_TestAppointment;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_AddAppointment;
        private UserControls.UCL_L_ApplicationDetail ucL_L_ApplicationDetail1;
        private UserControls.UCDetailApplicationInfo ucDetailApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lb_TestName;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}