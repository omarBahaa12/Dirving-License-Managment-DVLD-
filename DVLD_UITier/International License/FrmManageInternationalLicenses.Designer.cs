namespace DVLD_UITier.International_License
{
    partial class FrmManageInternationalLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DG_InternationalLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Txtb_Filterby = new RJCodeAdvance.RJControls.RJTextBox();
            this.Cmb_FilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_InternationalLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::DVLD_UITier.Properties.Resources.countries;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(337, 32);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(136, 94);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::DVLD_UITier.Properties.Resources.driving_license;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(489, 12);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(228, 134);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 1;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(354, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "International Licenses";
            // 
            // DG_InternationalLicenses
            // 
            this.DG_InternationalLicenses.AllowUserToAddRows = false;
            this.DG_InternationalLicenses.AllowUserToDeleteRows = false;
            this.DG_InternationalLicenses.AllowUserToResizeColumns = false;
            this.DG_InternationalLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_InternationalLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_InternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_InternationalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_InternationalLicenses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_InternationalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_InternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_InternationalLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.DG_InternationalLicenses.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DG_InternationalLicenses.Location = new System.Drawing.Point(40, 293);
            this.DG_InternationalLicenses.Name = "DG_InternationalLicenses";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_InternationalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_InternationalLicenses.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_InternationalLicenses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_InternationalLicenses.RowTemplate.Height = 24;
            this.DG_InternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_InternationalLicenses.Size = new System.Drawing.Size(985, 286);
            this.DG_InternationalLicenses.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 60);
            // 
            // showPersonDetailToolStripMenuItem
            // 
            this.showPersonDetailToolStripMenuItem.Name = "showPersonDetailToolStripMenuItem";
            this.showPersonDetailToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.showPersonDetailToolStripMenuItem.Text = "Show Person Detail";
            this.showPersonDetailToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailToolStripMenuItem_Click);
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Image = global::DVLD_UITier.Properties.Resources.cross;
            this.Btn_Close.ImageSize = new System.Drawing.Size(35, 35);
            this.Btn_Close.Location = new System.Drawing.Point(736, 585);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(155, 58);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 244);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(91, 29);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Filter By";
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
            this.Txtb_Filterby.Location = new System.Drawing.Point(288, 245);
            this.Txtb_Filterby.Margin = new System.Windows.Forms.Padding(4);
            this.Txtb_Filterby.Multiline = false;
            this.Txtb_Filterby.Name = "Txtb_Filterby";
            this.Txtb_Filterby.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Txtb_Filterby.PasswordChar = false;
            this.Txtb_Filterby.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Txtb_Filterby.PlaceholderText = "";
            this.Txtb_Filterby.Size = new System.Drawing.Size(127, 35);
            this.Txtb_Filterby.TabIndex = 9;
            this.Txtb_Filterby.Texts = "";
            this.Txtb_Filterby.UnderlinedStyle = false;
            this.Txtb_Filterby.Visible = false;
            this.Txtb_Filterby._TextChanged += new System.EventHandler(this.Txtb_Filterby__TextChanged);
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
            "I.License ID",
            "Driver ID",
            "L.License ID"});
            this.Cmb_FilterBy.Location = new System.Drawing.Point(122, 244);
            this.Cmb_FilterBy.Name = "Cmb_FilterBy";
            this.Cmb_FilterBy.Size = new System.Drawing.Size(140, 36);
            this.Cmb_FilterBy.TabIndex = 8;
            this.Cmb_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cmb_FilterBy_SelectedIndexChanged);
            // 
            // FrmManageInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 655);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.Txtb_Filterby);
            this.Controls.Add(this.Cmb_FilterBy);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.DG_InternationalLicenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManageInternationalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage International Licenses";
            this.Load += new System.EventHandler(this.FrmManageInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_InternationalLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DG_InternationalLicenses;
        private Guna.UI2.WinForms.Guna2Button Btn_Close;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private RJCodeAdvance.RJControls.RJTextBox Txtb_Filterby;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_FilterBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
    }
}