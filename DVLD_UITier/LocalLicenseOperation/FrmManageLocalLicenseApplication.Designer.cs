namespace DVLD_UITier.LicenseOperation
{
    partial class FrmManageLocalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageLocalLicenseApplication));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DG_LocalLicenseApplication = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cmb_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txtb_Filterby = new RJCodeAdvance.RJControls.RJTextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Cmb_FilterByStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Btn_AddL_L_Application = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_LocalLicenseApplication)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(468, 187);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(233, 29);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "L_License Application";
            // 
            // DG_LocalLicenseApplication
            // 
            this.DG_LocalLicenseApplication.AllowUserToAddRows = false;
            this.DG_LocalLicenseApplication.AllowUserToDeleteRows = false;
            this.DG_LocalLicenseApplication.AllowUserToResizeColumns = false;
            this.DG_LocalLicenseApplication.AllowUserToResizeRows = false;
            this.DG_LocalLicenseApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_LocalLicenseApplication.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_LocalLicenseApplication.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DG_LocalLicenseApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_LocalLicenseApplication.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.DG_LocalLicenseApplication.Location = new System.Drawing.Point(5, 282);
            this.DG_LocalLicenseApplication.Name = "DG_LocalLicenseApplication";
            this.DG_LocalLicenseApplication.RowHeadersWidth = 51;
            this.DG_LocalLicenseApplication.RowTemplate.Height = 24;
            this.DG_LocalLicenseApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_LocalLicenseApplication.Size = new System.Drawing.Size(1152, 321);
            this.DG_LocalLicenseApplication.TabIndex = 2;
            this.DG_LocalLicenseApplication.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.DG_LocalLicenseApplication_RowContextMenuStripNeeded);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.schudToolStripMenuItem,
            this.issueLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(325, 320);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.application;
            this.showApplicationDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.showApplicationDetailsToolStripMenuItem.Text = "   Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.edit_info;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.editApplicationToolStripMenuItem.Text = "   Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.delete_file;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.deleteApplicationToolStripMenuItem.Text = "   Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.cancelApplicationToolStripMenuItem.Text = "   Cancel Application";
            this.cancelApplicationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // schudToolStripMenuItem
            // 
            this.schudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sechduleVisionTestToolStripMenuItem,
            this.sechduleWrittenTestToolStripMenuItem,
            this.sechduleStreetTestToolStripMenuItem});
            this.schudToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.test;
            this.schudToolStripMenuItem.Name = "schudToolStripMenuItem";
            this.schudToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.schudToolStripMenuItem.Text = "   Sechdule Test";
            this.schudToolStripMenuItem.DropDownOpening += new System.EventHandler(this.schudToolStripMenuItem_DropDownOpening);
            // 
            // sechduleVisionTestToolStripMenuItem
            // 
            this.sechduleVisionTestToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.eye;
            this.sechduleVisionTestToolStripMenuItem.Name = "sechduleVisionTestToolStripMenuItem";
            this.sechduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.sechduleVisionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            this.sechduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleVisionTestToolStripMenuItem_Click);
            // 
            // sechduleWrittenTestToolStripMenuItem
            // 
            this.sechduleWrittenTestToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.test_1_;
            this.sechduleWrittenTestToolStripMenuItem.Name = "sechduleWrittenTestToolStripMenuItem";
            this.sechduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.sechduleWrittenTestToolStripMenuItem.Text = "Sechdule Written Test";
            this.sechduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleWrittenTestToolStripMenuItem_Click);
            // 
            // sechduleStreetTestToolStripMenuItem
            // 
            this.sechduleStreetTestToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.motorway;
            this.sechduleStreetTestToolStripMenuItem.Name = "sechduleStreetTestToolStripMenuItem";
            this.sechduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(269, 36);
            this.sechduleStreetTestToolStripMenuItem.Text = "Sechdule Street Test";
            this.sechduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.sechduleStreetTestToolStripMenuItem_Click);
            // 
            // issueLicenseToolStripMenuItem
            // 
            this.issueLicenseToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.driving_license;
            this.issueLicenseToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.issueLicenseToolStripMenuItem.Name = "issueLicenseToolStripMenuItem";
            this.issueLicenseToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.issueLicenseToolStripMenuItem.Text = "   Issue License (First Time)";
            this.issueLicenseToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issueLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueLicenseToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.driving_license;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.showLicenseToolStripMenuItem.Text = "   Show License Info";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(324, 36);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "   Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // Cmb_FilterBy
            // 
            this.Cmb_FilterBy.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_FilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_FilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_FilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_FilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_FilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cmb_FilterBy.ItemHeight = 30;
            this.Cmb_FilterBy.Items.AddRange(new object[] {
            "None",
            "L.L.Application",
            "NationalNo",
            "Full Name",
            "Status"});
            this.Cmb_FilterBy.Location = new System.Drawing.Point(102, 239);
            this.Cmb_FilterBy.Name = "Cmb_FilterBy";
            this.Cmb_FilterBy.Size = new System.Drawing.Size(140, 36);
            this.Cmb_FilterBy.TabIndex = 4;
            this.Cmb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cmb_FilterBy_SelectedIndexChanged);
            // 
            // Txtb_Filterby
            // 
            this.Txtb_Filterby.BackColor = System.Drawing.SystemColors.Window;
            this.Txtb_Filterby.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Txtb_Filterby.BorderFocusColor = System.Drawing.Color.HotPink;
            this.Txtb_Filterby.BorderRadius = 0;
            this.Txtb_Filterby.BorderSize = 2;
            this.Txtb_Filterby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Filterby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtb_Filterby.Location = new System.Drawing.Point(280, 240);
            this.Txtb_Filterby.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_Filterby.Multiline = false;
            this.Txtb_Filterby.Name = "Txtb_Filterby";
            this.Txtb_Filterby.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_Filterby.PasswordChar = false;
            this.Txtb_Filterby.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_Filterby.PlaceholderText = "";
            this.Txtb_Filterby.Size = new System.Drawing.Size(127, 35);
            this.Txtb_Filterby.TabIndex = 5;
            this.Txtb_Filterby.Texts = "";
            this.Txtb_Filterby.UnderlinedStyle = false;
            this.Txtb_Filterby.Visible = false;
            this.Txtb_Filterby._TextChanged += new System.EventHandler(this.Txtb_Filterby__TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(5, 239);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(91, 29);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Filter By";
            // 
            // Cmb_FilterByStatus
            // 
            this.Cmb_FilterByStatus.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_FilterByStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_FilterByStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_FilterByStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_FilterByStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_FilterByStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_FilterByStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cmb_FilterByStatus.ItemHeight = 30;
            this.Cmb_FilterByStatus.Items.AddRange(new object[] {
            "None",
            "New",
            "Cancel",
            "Completed"});
            this.Cmb_FilterByStatus.Location = new System.Drawing.Point(280, 240);
            this.Cmb_FilterByStatus.Name = "Cmb_FilterByStatus";
            this.Cmb_FilterByStatus.Size = new System.Drawing.Size(127, 36);
            this.Cmb_FilterByStatus.TabIndex = 7;
            this.Cmb_FilterByStatus.Visible = false;
            this.Cmb_FilterByStatus.SelectedIndexChanged += new System.EventHandler(this.Cmb_FilterByStatus_SelectedIndexChanged);
            // 
            // Btn_AddL_L_Application
            // 
            this.Btn_AddL_L_Application.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_AddL_L_Application.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_AddL_L_Application.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddL_L_Application.Image")));
            this.Btn_AddL_L_Application.ImageOffset = new System.Drawing.Point(0, 0);
            this.Btn_AddL_L_Application.ImageRotate = 0F;
            this.Btn_AddL_L_Application.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_AddL_L_Application.Location = new System.Drawing.Point(1093, 221);
            this.Btn_AddL_L_Application.Name = "Btn_AddL_L_Application";
            this.Btn_AddL_L_Application.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Btn_AddL_L_Application.Size = new System.Drawing.Size(64, 54);
            this.Btn_AddL_L_Application.TabIndex = 8;
            this.Btn_AddL_L_Application.Click += new System.EventHandler(this.Btn_AddL_L_Application_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(926, 625);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(142, 53);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_UITier.Properties.Resources.driving_license;
            this.pictureBox1.Location = new System.Drawing.Point(468, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManageLocalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 723);
            this.Controls.Add(this.Btn_AddL_L_Application);
            this.Controls.Add(this.Cmb_FilterByStatus);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.Txtb_Filterby);
            this.Controls.Add(this.Cmb_FilterBy);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.DG_LocalLicenseApplication);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageLocalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage L.License Application";
            this.Load += new System.EventHandler(this.FrmManageLocalLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_LocalLicenseApplication)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridView DG_LocalLicenseApplication;
        private Guna.UI2.WinForms.Guna2Button Btn_Close;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_FilterBy;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_Filterby;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_FilterByStatus;
        private Guna.UI2.WinForms.Guna2ImageButton Btn_AddL_L_Application;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}