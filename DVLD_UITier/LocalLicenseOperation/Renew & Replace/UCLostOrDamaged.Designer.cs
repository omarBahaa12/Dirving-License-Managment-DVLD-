namespace DVLD_UITier.UserControls
{
    partial class UCLostOrDamaged
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
            this.RdBtn_Damaged = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RdBtn_Lost = new Guna.UI2.WinForms.Guna2RadioButton();
            this.SuspendLayout();
            // 
            // RdBtn_Damaged
            // 
            this.RdBtn_Damaged.AutoSize = true;
            this.RdBtn_Damaged.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RdBtn_Damaged.CheckedState.BorderThickness = 0;
            this.RdBtn_Damaged.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RdBtn_Damaged.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RdBtn_Damaged.CheckedState.InnerOffset = -4;
            this.RdBtn_Damaged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdBtn_Damaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn_Damaged.Location = new System.Drawing.Point(3, 3);
            this.RdBtn_Damaged.Name = "RdBtn_Damaged";
            this.RdBtn_Damaged.Size = new System.Drawing.Size(172, 22);
            this.RdBtn_Damaged.TabIndex = 0;
            this.RdBtn_Damaged.Text = "Replace for Damaged";
            this.RdBtn_Damaged.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RdBtn_Damaged.UncheckedState.BorderThickness = 2;
            this.RdBtn_Damaged.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RdBtn_Damaged.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RdBtn_Damaged.CheckedChanged += new System.EventHandler(this.RdBtn_Damaged_CheckedChanged);
            // 
            // RdBtn_Lost
            // 
            this.RdBtn_Lost.AutoSize = true;
            this.RdBtn_Lost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RdBtn_Lost.CheckedState.BorderThickness = 0;
            this.RdBtn_Lost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RdBtn_Lost.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RdBtn_Lost.CheckedState.InnerOffset = -4;
            this.RdBtn_Lost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdBtn_Lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdBtn_Lost.Location = new System.Drawing.Point(3, 61);
            this.RdBtn_Lost.Name = "RdBtn_Lost";
            this.RdBtn_Lost.Size = new System.Drawing.Size(137, 22);
            this.RdBtn_Lost.TabIndex = 1;
            this.RdBtn_Lost.Text = "Replace for Lost";
            this.RdBtn_Lost.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RdBtn_Lost.UncheckedState.BorderThickness = 2;
            this.RdBtn_Lost.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RdBtn_Lost.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RdBtn_Lost.CheckedChanged += new System.EventHandler(this.RdBtn_Lost_CheckedChanged);
            // 
            // UCLostOrDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RdBtn_Lost);
            this.Controls.Add(this.RdBtn_Damaged);
            this.Name = "UCLostOrDamaged";
            this.Size = new System.Drawing.Size(226, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton RdBtn_Damaged;
        private Guna.UI2.WinForms.Guna2RadioButton RdBtn_Lost;
    }
}
