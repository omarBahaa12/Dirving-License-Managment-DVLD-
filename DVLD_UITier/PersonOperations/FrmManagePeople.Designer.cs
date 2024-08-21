namespace DVLD_UITier
{
    partial class FrmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagePeople));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ManagePeople = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DG_People = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lb_FilterBy = new System.Windows.Forms.Label();
            this.Cmbox_FilterBy = new System.Windows.Forms.ComboBox();
            this.Txtb_Filter = new System.Windows.Forms.TextBox();
            this.Cmbox_GenderType = new System.Windows.Forms.ComboBox();
            this.Btn_AddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_People)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagePeople
            // 
            this.ManagePeople.AutoSize = true;
            this.ManagePeople.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePeople.ForeColor = System.Drawing.Color.Peru;
            this.ManagePeople.Location = new System.Drawing.Point(466, 158);
            this.ManagePeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManagePeople.Name = "ManagePeople";
            this.ManagePeople.Size = new System.Drawing.Size(249, 35);
            this.ManagePeople.TabIndex = 1;
            this.ManagePeople.Text = "Manage People";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "follow.png");
            // 
            // DG_People
            // 
            this.DG_People.AllowUserToAddRows = false;
            this.DG_People.AllowUserToDeleteRows = false;
            this.DG_People.AllowUserToResizeColumns = false;
            this.DG_People.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_People.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_People.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_People.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_People.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_People.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_People.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_People.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_People.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DG_People.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DG_People.Location = new System.Drawing.Point(0, 281);
            this.DG_People.Name = "DG_People";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_People.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_People.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DG_People.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DG_People.RowTemplate.Height = 24;
            this.DG_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_People.Size = new System.Drawing.Size(1141, 363);
            this.DG_People.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailProfileToolStripMenuItem,
            this.updateInformationToolStripMenuItem,
            this.deleteInformationToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 124);
            // 
            // showDetailProfileToolStripMenuItem
            // 
            this.showDetailProfileToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.requirement;
            this.showDetailProfileToolStripMenuItem.Name = "showDetailProfileToolStripMenuItem";
            this.showDetailProfileToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.showDetailProfileToolStripMenuItem.Text = "Show Detail Profile";
            this.showDetailProfileToolStripMenuItem.Click += new System.EventHandler(this.showDetailProfileToolStripMenuItem_Click);
            // 
            // updateInformationToolStripMenuItem
            // 
            this.updateInformationToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.profile;
            this.updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
            this.updateInformationToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.updateInformationToolStripMenuItem.Text = "Update Information";
            this.updateInformationToolStripMenuItem.Click += new System.EventHandler(this.updateInformationToolStripMenuItem_Click);
            // 
            // deleteInformationToolStripMenuItem
            // 
            this.deleteInformationToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.unfollow_1_;
            this.deleteInformationToolStripMenuItem.Name = "deleteInformationToolStripMenuItem";
            this.deleteInformationToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.deleteInformationToolStripMenuItem.Text = "Delete Information";
            this.deleteInformationToolStripMenuItem.Click += new System.EventHandler(this.deleteInformationToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD_UITier.Properties.Resources.email_1_;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // Lb_FilterBy
            // 
            this.Lb_FilterBy.AutoSize = true;
            this.Lb_FilterBy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_FilterBy.ForeColor = System.Drawing.Color.Peru;
            this.Lb_FilterBy.Location = new System.Drawing.Point(13, 240);
            this.Lb_FilterBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_FilterBy.Name = "Lb_FilterBy";
            this.Lb_FilterBy.Size = new System.Drawing.Size(97, 24);
            this.Lb_FilterBy.TabIndex = 4;
            this.Lb_FilterBy.Text = "Filter By";
            // 
            // Cmbox_FilterBy
            // 
            this.Cmbox_FilterBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmbox_FilterBy.FormattingEnabled = true;
            this.Cmbox_FilterBy.Items.AddRange(new object[] {
            "Full Name",
            "Gender",
            "National No",
            "None",
            "PersonID"});
            this.Cmbox_FilterBy.Location = new System.Drawing.Point(137, 236);
            this.Cmbox_FilterBy.Name = "Cmbox_FilterBy";
            this.Cmbox_FilterBy.Size = new System.Drawing.Size(121, 28);
            this.Cmbox_FilterBy.Sorted = true;
            this.Cmbox_FilterBy.TabIndex = 5;
            this.Cmbox_FilterBy.SelectedIndexChanged += new System.EventHandler(this.Cmbox_FilterBy_SelectedIndexChanged);
            // 
            // Txtb_Filter
            // 
            this.Txtb_Filter.Location = new System.Drawing.Point(300, 237);
            this.Txtb_Filter.Name = "Txtb_Filter";
            this.Txtb_Filter.Size = new System.Drawing.Size(106, 27);
            this.Txtb_Filter.TabIndex = 6;
            this.Txtb_Filter.Visible = false;
            this.Txtb_Filter.TextChanged += new System.EventHandler(this.Txtb_Filter_TextChanged);
            // 
            // Cmbox_GenderType
            // 
            this.Cmbox_GenderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmbox_GenderType.FormattingEnabled = true;
            this.Cmbox_GenderType.Items.AddRange(new object[] {
            "Female",
            "Male",
            "None"});
            this.Cmbox_GenderType.Location = new System.Drawing.Point(300, 237);
            this.Cmbox_GenderType.Name = "Cmbox_GenderType";
            this.Cmbox_GenderType.Size = new System.Drawing.Size(106, 28);
            this.Cmbox_GenderType.Sorted = true;
            this.Cmbox_GenderType.TabIndex = 7;
            this.Cmbox_GenderType.Visible = false;
            this.Cmbox_GenderType.SelectedIndexChanged += new System.EventHandler(this.Cmbox_GenderType_SelectedIndexChanged);
            // 
            // Btn_AddPerson
            // 
            this.Btn_AddPerson.BackColor = System.Drawing.Color.Peru;
            this.Btn_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddPerson.ImageIndex = 0;
            this.Btn_AddPerson.ImageList = this.imageList1;
            this.Btn_AddPerson.Location = new System.Drawing.Point(1054, 215);
            this.Btn_AddPerson.Name = "Btn_AddPerson";
            this.Btn_AddPerson.Size = new System.Drawing.Size(56, 49);
            this.Btn_AddPerson.TabIndex = 2;
            this.Btn_AddPerson.UseVisualStyleBackColor = false;
            this.Btn_AddPerson.Click += new System.EventHandler(this.Btn_AddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_UITier.Properties.Resources.teamwork_1_1;
            this.pictureBox1.Location = new System.Drawing.Point(481, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(38)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1141, 644);
            this.Controls.Add(this.Cmbox_GenderType);
            this.Controls.Add(this.Txtb_Filter);
            this.Controls.Add(this.Cmbox_FilterBy);
            this.Controls.Add(this.Lb_FilterBy);
            this.Controls.Add(this.DG_People);
            this.Controls.Add(this.Btn_AddPerson);
            this.Controls.Add(this.ManagePeople);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People";
            ((System.ComponentModel.ISupportInitialize)(this.DG_People)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ManagePeople;
        private System.Windows.Forms.Button Btn_AddPerson;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView DG_People;
        private System.Windows.Forms.Label Lb_FilterBy;
        private System.Windows.Forms.ComboBox Cmbox_FilterBy;
        private System.Windows.Forms.TextBox Txtb_Filter;
        private System.Windows.Forms.ComboBox Cmbox_GenderType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
    }
}