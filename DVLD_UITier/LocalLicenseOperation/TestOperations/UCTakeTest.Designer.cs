namespace DVLD_UITier.UserControls
{
    partial class UCTakeTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.Rdbtn_Success = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Rdbtn_Failed = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TXtb_Notes = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result";
            // 
            // Rdbtn_Success
            // 
            this.Rdbtn_Success.AutoSize = true;
            this.Rdbtn_Success.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rdbtn_Success.CheckedState.BorderThickness = 0;
            this.Rdbtn_Success.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rdbtn_Success.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rdbtn_Success.CheckedState.InnerOffset = -4;
            this.Rdbtn_Success.Location = new System.Drawing.Point(110, 18);
            this.Rdbtn_Success.Name = "Rdbtn_Success";
            this.Rdbtn_Success.Size = new System.Drawing.Size(110, 24);
            this.Rdbtn_Success.TabIndex = 1;
            this.Rdbtn_Success.Text = "Succeeded";
            this.Rdbtn_Success.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rdbtn_Success.UncheckedState.BorderThickness = 2;
            this.Rdbtn_Success.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rdbtn_Success.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Rdbtn_Success.CheckedChanged += new System.EventHandler(this.Rdbtn_Success_CheckedChanged);
            // 
            // Rdbtn_Failed
            // 
            this.Rdbtn_Failed.AutoSize = true;
            this.Rdbtn_Failed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rdbtn_Failed.CheckedState.BorderThickness = 0;
            this.Rdbtn_Failed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rdbtn_Failed.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rdbtn_Failed.CheckedState.InnerOffset = -4;
            this.Rdbtn_Failed.Location = new System.Drawing.Point(241, 18);
            this.Rdbtn_Failed.Name = "Rdbtn_Failed";
            this.Rdbtn_Failed.Size = new System.Drawing.Size(77, 24);
            this.Rdbtn_Failed.TabIndex = 2;
            this.Rdbtn_Failed.Text = "Failed";
            this.Rdbtn_Failed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rdbtn_Failed.UncheckedState.BorderThickness = 2;
            this.Rdbtn_Failed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Rdbtn_Failed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Rdbtn_Failed.CheckedChanged += new System.EventHandler(this.Rdbtn_Failed_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notes";
            // 
            // TXtb_Notes
            // 
            this.TXtb_Notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXtb_Notes.DefaultText = "";
            this.TXtb_Notes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXtb_Notes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXtb_Notes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXtb_Notes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXtb_Notes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXtb_Notes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXtb_Notes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXtb_Notes.Location = new System.Drawing.Point(79, 65);
            this.TXtb_Notes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TXtb_Notes.Multiline = true;
            this.TXtb_Notes.Name = "TXtb_Notes";
            this.TXtb_Notes.PasswordChar = '\0';
            this.TXtb_Notes.PlaceholderText = "";
            this.TXtb_Notes.SelectedText = "";
            this.TXtb_Notes.Size = new System.Drawing.Size(368, 100);
            this.TXtb_Notes.TabIndex = 4;
            this.TXtb_Notes.TextChanged += new System.EventHandler(this.TXtb_Notes_TextChanged);
            // 
            // UCTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TXtb_Notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rdbtn_Failed);
            this.Controls.Add(this.Rdbtn_Success);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTakeTest";
            this.Size = new System.Drawing.Size(501, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton Rdbtn_Success;
        private Guna.UI2.WinForms.Guna2RadioButton Rdbtn_Failed;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TXtb_Notes;
    }
}
