namespace DVLD_UITier
{
    partial class UCAddPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddPerson));
            this.RdBtn_Female = new System.Windows.Forms.RadioButton();
            this.RdBtn_Male = new System.Windows.Forms.RadioButton();
            this.Lb_Gender = new System.Windows.Forms.Label();
            this.DateTime_DateBirth = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Cmbox_Country = new System.Windows.Forms.ComboBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Link_SetImage = new System.Windows.Forms.LinkLabel();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_NAtionaNo = new System.Windows.Forms.TextBox();
            this.Txtb_Last = new System.Windows.Forms.TextBox();
            this.Txt_Third = new System.Windows.Forms.TextBox();
            this.Txt_SecondName = new System.Windows.Forms.TextBox();
            this.Txt_FirstName = new System.Windows.Forms.TextBox();
            this.Lb_Last = new System.Windows.Forms.Label();
            this.Lb_Third = new System.Windows.Forms.Label();
            this.Lb_Second = new System.Windows.Forms.Label();
            this.Lb_First = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Pan_GenderType = new System.Windows.Forms.Panel();
            this.Lb_PersonID = new System.Windows.Forms.Label();
            this.Lb_ShowPersonID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Address = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Lb_DateBirth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_NationNo = new System.Windows.Forms.Label();
            this.Lb_Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Pan_GenderType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RdBtn_Female
            // 
            this.RdBtn_Female.AutoSize = true;
            this.RdBtn_Female.Location = new System.Drawing.Point(114, 18);
            this.RdBtn_Female.Name = "RdBtn_Female";
            this.RdBtn_Female.Size = new System.Drawing.Size(85, 24);
            this.RdBtn_Female.TabIndex = 9;
            this.RdBtn_Female.TabStop = true;
            this.RdBtn_Female.Text = "Female";
            this.RdBtn_Female.UseVisualStyleBackColor = true;
            this.RdBtn_Female.CheckedChanged += new System.EventHandler(this.RdBtn_Female_CheckedChanged);
            // 
            // RdBtn_Male
            // 
            this.RdBtn_Male.AutoSize = true;
            this.RdBtn_Male.Location = new System.Drawing.Point(11, 18);
            this.RdBtn_Male.Name = "RdBtn_Male";
            this.RdBtn_Male.Size = new System.Drawing.Size(68, 24);
            this.RdBtn_Male.TabIndex = 8;
            this.RdBtn_Male.TabStop = true;
            this.RdBtn_Male.Text = "Male";
            this.RdBtn_Male.UseVisualStyleBackColor = true;
            this.RdBtn_Male.CheckedChanged += new System.EventHandler(this.RdBtn_Male_CheckedChanged);
            // 
            // Lb_Gender
            // 
            this.Lb_Gender.AutoSize = true;
            this.Lb_Gender.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Gender.Location = new System.Drawing.Point(17, 254);
            this.Lb_Gender.Name = "Lb_Gender";
            this.Lb_Gender.Size = new System.Drawing.Size(76, 24);
            this.Lb_Gender.TabIndex = 25;
            this.Lb_Gender.Text = "Gender";
            // 
            // DateTime_DateBirth
            // 
            this.DateTime_DateBirth.Location = new System.Drawing.Point(561, 262);
            this.DateTime_DateBirth.Name = "DateTime_DateBirth";
            this.DateTime_DateBirth.Size = new System.Drawing.Size(156, 27);
            this.DateTime_DateBirth.TabIndex = 10;
            this.DateTime_DateBirth.ValueChanged += new System.EventHandler(this.DateTime_DateBirth_ValueChanged);
            this.DateTime_DateBirth.Validating += new System.ComponentModel.CancelEventHandler(this.DateTime_DateBirth_Validating);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "diskette.png");
            this.imageList1.Images.SetKeyName(1, "circle-xmark.png");
            this.imageList1.Images.SetKeyName(2, "cross.png");
            this.imageList1.Images.SetKeyName(3, "happy-birthday.png");
            this.imageList1.Images.SetKeyName(4, "location.png");
            this.imageList1.Images.SetKeyName(5, "telephone.png");
            this.imageList1.Images.SetKeyName(6, "email.png");
            this.imageList1.Images.SetKeyName(7, "id-card(1).png");
            this.imageList1.Images.SetKeyName(8, "id-card.png");
            this.imageList1.Images.SetKeyName(9, "location.png");
            // 
            // Cmbox_Country
            // 
            this.Cmbox_Country.FormattingEnabled = true;
            this.Cmbox_Country.Location = new System.Drawing.Point(561, 211);
            this.Cmbox_Country.Name = "Cmbox_Country";
            this.Cmbox_Country.Size = new System.Drawing.Size(156, 28);
            this.Cmbox_Country.TabIndex = 7;
            this.Cmbox_Country.SelectedIndexChanged += new System.EventHandler(this.Cmbox_Country_SelectedIndexChanged);
            this.Cmbox_Country.Validating += new System.ComponentModel.CancelEventHandler(this.Cmbox_Country_Validating);
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(158, 328);
            this.Txt_Address.Multiline = true;
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(737, 115);
            this.Txt_Address.TabIndex = 11;
            this.Txt_Address.TextChanged += new System.EventHandler(this.Txt_Address_TextChanged);
            this.Txt_Address.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Address_Validating);
            // 
            // Link_SetImage
            // 
            this.Link_SetImage.AutoSize = true;
            this.Link_SetImage.DisabledLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.Link_SetImage.LinkColor = System.Drawing.Color.Black;
            this.Link_SetImage.Location = new System.Drawing.Point(766, 291);
            this.Link_SetImage.Name = "Link_SetImage";
            this.Link_SetImage.Size = new System.Drawing.Size(85, 20);
            this.Link_SetImage.TabIndex = 18;
            this.Link_SetImage.TabStop = true;
            this.Link_SetImage.Text = "Set Image";
            this.Link_SetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_SetImage_LinkClicked);
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(561, 153);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(156, 27);
            this.Txt_Phone.TabIndex = 5;
            this.Txt_Phone.TextChanged += new System.EventHandler(this.Txt_Phone_TextChanged);
            this.Txt_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Phone_Validating);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(205, 208);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(207, 27);
            this.Txt_Email.TabIndex = 6;
            this.Txt_Email.TextChanged += new System.EventHandler(this.Txt_Email_TextChanged);
            this.Txt_Email.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Email_Validating);
            // 
            // Txt_NAtionaNo
            // 
            this.Txt_NAtionaNo.Location = new System.Drawing.Point(205, 156);
            this.Txt_NAtionaNo.Name = "Txt_NAtionaNo";
            this.Txt_NAtionaNo.Size = new System.Drawing.Size(206, 27);
            this.Txt_NAtionaNo.TabIndex = 4;
            this.Txt_NAtionaNo.TextChanged += new System.EventHandler(this.Txt_NAtionaNo_TextChanged);
            this.Txt_NAtionaNo.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_NAtionaNo_Validating);
            // 
            // Txtb_Last
            // 
            this.Txtb_Last.Location = new System.Drawing.Point(770, 80);
            this.Txtb_Last.Name = "Txtb_Last";
            this.Txtb_Last.Size = new System.Drawing.Size(118, 27);
            this.Txtb_Last.TabIndex = 3;
            this.Txtb_Last.TextChanged += new System.EventHandler(this.Txtb_Last_TextChanged);
            this.Txtb_Last.Validating += new System.ComponentModel.CancelEventHandler(this.Txtb_Last_Validating);
            // 
            // Txt_Third
            // 
            this.Txt_Third.Location = new System.Drawing.Point(587, 80);
            this.Txt_Third.Name = "Txt_Third";
            this.Txt_Third.Size = new System.Drawing.Size(118, 27);
            this.Txt_Third.TabIndex = 2;
            this.Txt_Third.TextChanged += new System.EventHandler(this.Txt_Third_TextChanged);
            this.Txt_Third.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Third_Validating);
            // 
            // Txt_SecondName
            // 
            this.Txt_SecondName.Location = new System.Drawing.Point(400, 81);
            this.Txt_SecondName.Name = "Txt_SecondName";
            this.Txt_SecondName.Size = new System.Drawing.Size(118, 27);
            this.Txt_SecondName.TabIndex = 1;
            this.Txt_SecondName.TextChanged += new System.EventHandler(this.Txt_SecondName_TextChanged);
            this.Txt_SecondName.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_SecondName_Validating);
            // 
            // Txt_FirstName
            // 
            this.Txt_FirstName.Location = new System.Drawing.Point(205, 84);
            this.Txt_FirstName.Name = "Txt_FirstName";
            this.Txt_FirstName.Size = new System.Drawing.Size(118, 27);
            this.Txt_FirstName.TabIndex = 0;
            this.Txt_FirstName.TextChanged += new System.EventHandler(this.Txt_FirstName_TextChanged);
            this.Txt_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_FirstName_Validating);
            // 
            // Lb_Last
            // 
            this.Lb_Last.AutoSize = true;
            this.Lb_Last.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Last.Location = new System.Drawing.Point(724, 86);
            this.Lb_Last.Name = "Lb_Last";
            this.Lb_Last.Size = new System.Drawing.Size(44, 21);
            this.Lb_Last.TabIndex = 6;
            this.Lb_Last.Text = "Last";
            // 
            // Lb_Third
            // 
            this.Lb_Third.AutoSize = true;
            this.Lb_Third.Location = new System.Drawing.Point(529, 88);
            this.Lb_Third.Name = "Lb_Third";
            this.Lb_Third.Size = new System.Drawing.Size(52, 20);
            this.Lb_Third.TabIndex = 5;
            this.Lb_Third.Text = "Third";
            // 
            // Lb_Second
            // 
            this.Lb_Second.AutoSize = true;
            this.Lb_Second.Location = new System.Drawing.Point(330, 88);
            this.Lb_Second.Name = "Lb_Second";
            this.Lb_Second.Size = new System.Drawing.Size(64, 20);
            this.Lb_Second.TabIndex = 4;
            this.Lb_Second.Text = "Second";
            // 
            // Lb_First
            // 
            this.Lb_First.AutoSize = true;
            this.Lb_First.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_First.Location = new System.Drawing.Point(139, 87);
            this.Lb_First.Name = "Lb_First";
            this.Lb_First.Size = new System.Drawing.Size(47, 21);
            this.Lb_First.TabIndex = 3;
            this.Lb_First.Text = "First";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Pan_GenderType
            // 
            this.Pan_GenderType.Controls.Add(this.RdBtn_Female);
            this.Pan_GenderType.Controls.Add(this.RdBtn_Male);
            this.Pan_GenderType.Location = new System.Drawing.Point(107, 243);
            this.Pan_GenderType.Name = "Pan_GenderType";
            this.Pan_GenderType.Size = new System.Drawing.Size(208, 55);
            this.Pan_GenderType.TabIndex = 26;
            this.Pan_GenderType.Validating += new System.ComponentModel.CancelEventHandler(this.Pan_GenderType_Validating);
            // 
            // Lb_PersonID
            // 
            this.Lb_PersonID.AutoSize = true;
            this.Lb_PersonID.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_PersonID.Location = new System.Drawing.Point(335, 16);
            this.Lb_PersonID.Name = "Lb_PersonID";
            this.Lb_PersonID.Size = new System.Drawing.Size(127, 27);
            this.Lb_PersonID.TabIndex = 27;
            this.Lb_PersonID.Text = "Person ID: ";
            // 
            // Lb_ShowPersonID
            // 
            this.Lb_ShowPersonID.AutoSize = true;
            this.Lb_ShowPersonID.Location = new System.Drawing.Point(459, 21);
            this.Lb_ShowPersonID.Name = "Lb_ShowPersonID";
            this.Lb_ShowPersonID.Size = new System.Drawing.Size(41, 20);
            this.Lb_ShowPersonID.TabIndex = 28;
            this.Lb_ShowPersonID.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(744, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Lb_Address
            // 
            this.Lb_Address.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Address.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Address.ImageIndex = 9;
            this.Lb_Address.ImageList = this.imageList1;
            this.Lb_Address.Location = new System.Drawing.Point(10, 339);
            this.Lb_Address.Name = "Lb_Address";
            this.Lb_Address.Size = new System.Drawing.Size(133, 47);
            this.Lb_Address.TabIndex = 19;
            this.Lb_Address.Text = "Address";
            this.Lb_Address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_Name
            // 
            this.Lb_Name.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Name.ImageIndex = 8;
            this.Lb_Name.ImageList = this.imageList1;
            this.Lb_Name.Location = new System.Drawing.Point(18, 76);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(99, 47);
            this.Lb_Name.TabIndex = 2;
            this.Lb_Name.Text = "Name";
            this.Lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_DateBirth
            // 
            this.Lb_DateBirth.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_DateBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_DateBirth.ImageIndex = 3;
            this.Lb_DateBirth.ImageList = this.imageList1;
            this.Lb_DateBirth.Location = new System.Drawing.Point(410, 251);
            this.Lb_DateBirth.Name = "Lb_DateBirth";
            this.Lb_DateBirth.Size = new System.Drawing.Size(145, 42);
            this.Lb_DateBirth.TabIndex = 23;
            this.Lb_DateBirth.Text = "DateBirth";
            this.Lb_DateBirth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageIndex = 4;
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(427, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Country";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_NationNo
            // 
            this.Lb_NationNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NationNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_NationNo.ImageIndex = 7;
            this.Lb_NationNo.ImageList = this.imageList1;
            this.Lb_NationNo.Location = new System.Drawing.Point(15, 147);
            this.Lb_NationNo.Name = "Lb_NationNo";
            this.Lb_NationNo.Size = new System.Drawing.Size(168, 42);
            this.Lb_NationNo.TabIndex = 11;
            this.Lb_NationNo.Text = "National No.";
            this.Lb_NationNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lb_Email
            // 
            this.Lb_Email.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lb_Email.ImageIndex = 6;
            this.Lb_Email.ImageList = this.imageList1;
            this.Lb_Email.Location = new System.Drawing.Point(37, 196);
            this.Lb_Email.Name = "Lb_Email";
            this.Lb_Email.Size = new System.Drawing.Size(106, 43);
            this.Lb_Email.TabIndex = 13;
            this.Lb_Email.Text = "Email";
            this.Lb_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageIndex = 5;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(438, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Phone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Lb_ShowPersonID);
            this.Controls.Add(this.Lb_PersonID);
            this.Controls.Add(this.Pan_GenderType);
            this.Controls.Add(this.Link_SetImage);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txtb_Last);
            this.Controls.Add(this.Lb_Address);
            this.Controls.Add(this.Lb_Last);
            this.Controls.Add(this.Txt_SecondName);
            this.Controls.Add(this.Lb_Gender);
            this.Controls.Add(this.Lb_Name);
            this.Controls.Add(this.DateTime_DateBirth);
            this.Controls.Add(this.Lb_First);
            this.Controls.Add(this.Lb_DateBirth);
            this.Controls.Add(this.Lb_Second);
            this.Controls.Add(this.Cmbox_Country);
            this.Controls.Add(this.Lb_Third);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_FirstName);
            this.Controls.Add(this.Txt_Third);
            this.Controls.Add(this.Lb_NationNo);
            this.Controls.Add(this.Txt_NAtionaNo);
            this.Controls.Add(this.Txt_Phone);
            this.Controls.Add(this.Lb_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Email);
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCAddPerson";
            this.Size = new System.Drawing.Size(911, 454);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Pan_GenderType.ResumeLayout(false);
            this.Pan_GenderType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lb_Second;
        private System.Windows.Forms.Label Lb_First;
        private System.Windows.Forms.Label Lb_Last;
        private System.Windows.Forms.Label Lb_Third;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Txtb_Last;
        private System.Windows.Forms.TextBox Txt_Third;
        private System.Windows.Forms.TextBox Txt_SecondName;
        private System.Windows.Forms.TextBox Txt_FirstName;
        private System.Windows.Forms.TextBox Txt_NAtionaNo;
        private System.Windows.Forms.Label Lb_NationNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lb_Email;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Address;
        private System.Windows.Forms.LinkLabel Link_SetImage;
        private System.Windows.Forms.DateTimePicker DateTime_DateBirth;
        private System.Windows.Forms.Label Lb_DateBirth;
        private System.Windows.Forms.ComboBox Cmbox_Country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label Lb_Gender;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton RdBtn_Female;
        private System.Windows.Forms.RadioButton RdBtn_Male;
        private System.Windows.Forms.Panel Pan_GenderType;
        private System.Windows.Forms.Label Lb_PersonID;
        private System.Windows.Forms.Label Lb_ShowPersonID;
    }
}
