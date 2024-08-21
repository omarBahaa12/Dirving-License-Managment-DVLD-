using BusinessTier;
using DVLD_UITier.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_UITier
{
    public partial class UCAddPerson : UserControl
    {
        public string Image;
        public short number = 0;
        public string First;
        public string Last;
        public string Second;
        public string Third;
        public string Email;
        public string Phone;
        public string Country;
        public string Address;
        public DateTime DateBirth;
        public string NationalNo;
        public string Gender;
        public int PersonID;
        public UCAddPerson()
        {
            InitializeComponent();
            MaxDate();
            GetCountries();
            RdBtn_Male.Checked = true;
        }

        public void GetPersonID(int ID)
        {
            PersonID = ID;
            clsPerson FoundPerson = clsPerson.GetPerson(ID);
            Image = FoundPerson._ImagePath;
            SetDataInTextBox(FoundPerson);
            
        }
        private void SetDataInTextBox(clsPerson FoundPerson)
        {
            Txtb_Last.Text = FoundPerson._LastName;
            Txt_Address.Text = FoundPerson._Address;
            Txt_Email.Text = FoundPerson._Email;
            Txt_FirstName.Text = FoundPerson._FirstName;
            Txt_NAtionaNo.Text = FoundPerson._NationalNo;
            Txt_Phone.Text = FoundPerson._Phone;
            Txt_SecondName.Text = FoundPerson._SecondName;
            Txt_Third.Text = FoundPerson._ThirdName;
            DateTime_DateBirth.Text = FoundPerson._BirthDate.ToString();
            Cmbox_Country.Text = FoundPerson._Country;
            Lb_ShowPersonID.Text = FoundPerson._PersonID.ToString();
            if (!string.IsNullOrWhiteSpace(FoundPerson._ImagePath)) 
            {
                pictureBox1.ImageLocation = FoundPerson._ImagePath;
            }

            else
            {
                pictureBox1.Image = Resources.unknown;
            }

            if (FoundPerson._Gender[0] =='M'|| FoundPerson._Gender[0] == 'm')
            {
                RdBtn_Male.Checked = true;
            }

            else
            {
                RdBtn_Female.Checked = true;
            }
        }

        private void GetCountries()
        {
            foreach (DataRow row in clsCountries.GetCountries().Rows)
            {
                Cmbox_Country.Items.Add(row[0].ToString());
            }
        }
        private void MaxDate()
        {
            TimeSpan timeSpan = new TimeSpan((6570*24),0,0);
            DateTime_DateBirth.MaxDate = DateTime.Now - timeSpan;
        }

        private bool ValidatingControls(TextBox sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(sender.Text))
            {
                e.Cancel = true;
                sender.Focus();
                errorProvider1.SetError(sender, "This Textbox should have value");
                return false;
            }
            number++;
            return true;
        }

        private void Txt_NAtionaNo_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_NAtionaNo.Text))
            {
                if (clsPerson.IsExist(Txt_NAtionaNo.Text))
                {
                    e.Cancel = true;
                    Txt_NAtionaNo.Focus();
                    errorProvider1.SetError(Txt_NAtionaNo, "The NationalNo is reserved");
                }
                else
                 if (ValidatingControls((TextBox)sender, e))
                    NationalNo = Txt_NAtionaNo.Text;
            }
            else
                 if (ValidatingControls((TextBox)sender, e))
                    NationalNo = Txt_NAtionaNo.Text;

        }

        private void Txt_FirstName_Validating(object sender, CancelEventArgs e)
        {

            if (ValidatingControls((TextBox)sender, e))
                First = Txt_FirstName.Text;

        }

        private void Txt_SecondName_Validating(object sender, CancelEventArgs e)
        {

            if (ValidatingControls((TextBox)sender, e))
                Second = Txt_SecondName.Text;

        }

        private void Txt_Third_Validating(object sender, CancelEventArgs e)
        {

            if (ValidatingControls((TextBox)sender, e))
                Third = Txt_Third.Text;

        }

        private void Txtb_Last_Validating(object sender, CancelEventArgs e)
        {

            if (ValidatingControls((TextBox)sender, e))
                Last = Txtb_Last.Text;

        }

        private void Txt_Email_Validating(object sender, CancelEventArgs e)
        {

            if (ValidatingControls((TextBox)sender, e))
                Email = Txt_Email.Text;

        }

        private void Txt_Phone_Validating(object sender, CancelEventArgs e)
        {

            if (ValidatingControls((TextBox)sender, e))
                Phone = Txt_Phone.Text;

        }

        private void Cmbox_Country_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cmbox_Country.Text))
            {
                e.Cancel = true;
                Cmbox_Country.Focus();
                errorProvider1.SetError(Cmbox_Country, "Please Enter The Country");
                return;
            }
            number++;
            Country = Cmbox_Country.SelectedItem.ToString();
        }

        private void DateTime_DateBirth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DateTime_DateBirth.Text))
            {
                e.Cancel = true;
                DateTime_DateBirth.Focus();
                errorProvider1.SetError(DateTime_DateBirth, "Please Enter Date Birth");
                return;
            }
            number++;
            DateBirth = DateTime_DateBirth.Value;
        }

        private void Txt_Address_Validating(object sender, CancelEventArgs e)
        {
            if (ValidatingControls((TextBox)sender, e))
                Address = Txt_Address.Text;

        }

        private void Link_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";

            openFileDialog1.DefaultExt = "png,jpeg";

            openFileDialog1.Filter = "png files (*.png)|*.png|jpeg files (*.jpeg) |*.jpeg| JPG files (*.JPG)|*.JPG";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                Image = openFileDialog1.FileName;
            }
        }

        private void Pan_GenderType_Validating(object sender, CancelEventArgs e)
        {
            if (!RdBtn_Male.Checked && !RdBtn_Female.Checked)
            {
                e.Cancel = true;
                RdBtn_Female.Focus();
                errorProvider1.SetError(RdBtn_Female, "Please Enter Gender");
                return;
            }
            number++;
        }

        private void RdBtn_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = RdBtn_Female.Text;
            pictureBox1.Image = Resources.anonymous_woman;
        }

        private void RdBtn_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = RdBtn_Male.Text;
            pictureBox1.Image = Resources.unknown;
        }

        private void Txt_FirstName_TextChanged(object sender, EventArgs e)
        {
            First=Txt_FirstName.Text;
        }

        private void Txt_SecondName_TextChanged(object sender, EventArgs e)
        {
            Second=Txt_SecondName.Text;
        }

        private void Txt_Third_TextChanged(object sender, EventArgs e)
        {
            Third=Txt_Third.Text;
        }

        private void Txtb_Last_TextChanged(object sender, EventArgs e)
        {
            Last=Txtb_Last.Text;
        }

        private void Txt_NAtionaNo_TextChanged(object sender, EventArgs e)
        {
            NationalNo=Txt_NAtionaNo.Text;
        }

        private void Txt_Phone_TextChanged(object sender, EventArgs e)
        {
            Phone=Txt_Phone.Text;
        }

        private void Txt_Email_TextChanged(object sender, EventArgs e)
        {
            Email=Txt_Email.Text;
        }

        private void Cmbox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country=Cmbox_Country.SelectedItem.ToString();
        }

        private void DateTime_DateBirth_ValueChanged(object sender, EventArgs e)
        {
            DateBirth=DateTime_DateBirth.Value;
        }

        private void Txt_Address_TextChanged(object sender, EventArgs e)
        {
            Address=Txt_Address.Text;
        }

        internal void SetPersonID(object sender,clsPerson person)
        {
            Lb_ShowPersonID.Text=person._PersonID.ToString();
        }

        
    }
}
