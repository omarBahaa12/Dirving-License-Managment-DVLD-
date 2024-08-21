namespace DVLD_UITier.LocalLicenseOperation.Detained___Release
{
    partial class FrmManageDetainedAndRelease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageDetainedAndRelease));
            this.DG_DetainedReleased = new System.Windows.Forms.DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComB_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Txtb_FilterBy = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Comb_IsReleased = new Guna.UI2.WinForms.Guna2ComboBox();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DetainedReleased)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_DetainedReleased
            // 
            this.DG_DetainedReleased.AllowUserToAddRows = false;
            this.DG_DetainedReleased.AllowUserToDeleteRows = false;
            this.DG_DetainedReleased.AllowUserToResizeColumns = false;
            this.DG_DetainedReleased.AllowUserToResizeRows = false;
            this.DG_DetainedReleased.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_DetainedReleased.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_DetainedReleased.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DG_DetainedReleased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_DetainedReleased.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.DG_DetainedReleased.Location = new System.Drawing.Point(12, 308);
            this.DG_DetainedReleased.Name = "DG_DetainedReleased";
            this.DG_DetainedReleased.RowHeadersWidth = 51;
            this.DG_DetainedReleased.RowTemplate.Height = 24;
            this.DG_DetainedReleased.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_DetainedReleased.Size = new System.Drawing.Size(1255, 380);
            this.DG_DetainedReleased.TabIndex = 3;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.personInfoToolStripMenuItem,
            this.licenseInfoToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(296, 116);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // personInfoToolStripMenuItem
            // 
            this.personInfoToolStripMenuItem.Name = "personInfoToolStripMenuItem";
            this.personInfoToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.personInfoToolStripMenuItem.Text = "Person Info";
            this.personInfoToolStripMenuItem.Click += new System.EventHandler(this.personInfoToolStripMenuItem_Click);
            // 
            // licenseInfoToolStripMenuItem
            // 
            this.licenseInfoToolStripMenuItem.Name = "licenseInfoToolStripMenuItem";
            this.licenseInfoToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.licenseInfoToolStripMenuItem.Text = "License Info";
            this.licenseInfoToolStripMenuItem.Click += new System.EventHandler(this.licenseInfoToolStripMenuItem_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DVLD_UITier.Properties.Resources.driving_license;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(490, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(256, 161);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(408, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detained & Released Licenses";
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.Silver;
            this.Btn_Close.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(796, 723);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(163, 59);
            this.Btn_Close.TabIndex = 6;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // ComB_FilterBy
            // 
            this.ComB_FilterBy.BackColor = System.Drawing.Color.Transparent;
            this.ComB_FilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComB_FilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComB_FilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComB_FilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComB_FilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComB_FilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComB_FilterBy.ItemHeight = 30;
            this.ComB_FilterBy.Items.AddRange(new object[] {
            "None",
            "DetainedID",
            "LicenseID",
            "FullName",
            "National No",
            "IsReleased"});
            this.ComB_FilterBy.Location = new System.Drawing.Point(104, 253);
            this.ComB_FilterBy.Name = "ComB_FilterBy";
            this.ComB_FilterBy.Size = new System.Drawing.Size(140, 36);
            this.ComB_FilterBy.TabIndex = 7;
            this.ComB_FilterBy.SelectedIndexChanged += new System.EventHandler(this.ComB_FilterBy_SelectedIndexChanged);
            // 
            // Txtb_FilterBy
            // 
            this.Txtb_FilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtb_FilterBy.DefaultText = "";
            this.Txtb_FilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txtb_FilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txtb_FilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtb_FilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txtb_FilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtb_FilterBy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_FilterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txtb_FilterBy.Location = new System.Drawing.Point(281, 253);
            this.Txtb_FilterBy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Txtb_FilterBy.Name = "Txtb_FilterBy";
            this.Txtb_FilterBy.PasswordChar = '\0';
            this.Txtb_FilterBy.PlaceholderText = "";
            this.Txtb_FilterBy.SelectedText = "";
            this.Txtb_FilterBy.Size = new System.Drawing.Size(165, 35);
            this.Txtb_FilterBy.TabIndex = 8;
            this.Txtb_FilterBy.Visible = false;
            this.Txtb_FilterBy.TextChanged += new System.EventHandler(this.Txtb_FilterBy_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter By";
            // 
            // Comb_IsReleased
            // 
            this.Comb_IsReleased.BackColor = System.Drawing.Color.Transparent;
            this.Comb_IsReleased.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Comb_IsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comb_IsReleased.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Comb_IsReleased.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Comb_IsReleased.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Comb_IsReleased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Comb_IsReleased.ItemHeight = 30;
            this.Comb_IsReleased.Items.AddRange(new object[] {
            "None",
            "true",
            "false"});
            this.Comb_IsReleased.Location = new System.Drawing.Point(281, 252);
            this.Comb_IsReleased.Name = "Comb_IsReleased";
            this.Comb_IsReleased.Size = new System.Drawing.Size(140, 36);
            this.Comb_IsReleased.TabIndex = 10;
            this.Comb_IsReleased.Visible = false;
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Enabled = false;
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(295, 28);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1187, 235);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 11;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // FrmManageDetainedAndRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 807);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.Comb_IsReleased);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtb_FilterBy);
            this.Controls.Add(this.ComB_FilterBy);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.DG_DetainedReleased);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageDetainedAndRelease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained And Release License";
            this.Load += new System.EventHandler(this.FrmManageDetainedAndRelease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_DetainedReleased)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_DetainedReleased;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_Close;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInfoToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ComboBox ComB_FilterBy;
        private Guna.UI2.WinForms.Guna2TextBox Txtb_FilterBy;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox Comb_IsReleased;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}