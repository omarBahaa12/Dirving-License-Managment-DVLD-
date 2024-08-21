using BusinessTier;
using DVLD_UITier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier
{
    public partial class UCDetailedInfo : UserControl
    {
        public UCDetailedInfo()
        {
            InitializeComponent();
            
        }
        public int ID {  get; set; }

        public void GetPerson(clsPerson person)
        {
            ID = person._PersonID;
            GetDataInForm(person);
        }
        public void GetPersonID(int PersonID)
        {
            clsPerson GetPerson = clsPerson.GetPerson(PersonID);
            if (GetPerson != null)
            {
                ID = GetPerson._PersonID;
                GetDataInForm(GetPerson);
            }
        }

        private void GetDataInForm(clsPerson person)
        {
            Lb_ShowAddress.Text = person._Address;
            Lb_ShowCountry.Text = person._Country;
            Lb_ShowDateBirth.Text = person._BirthDate.ToShortDateString();
            Lb_ShowEmail.Text = person._Email;
            Lb_ShowNationalNo.Text = person._NationalNo;
            Lb_ShowPersonID.Text = person._PersonID.ToString();
            Lb_ShowPhone.Text = person._Phone;
            Lb_ShowGender.Text = person._Gender;
            Lb_FullName.Text = person._FirstName + " " + person._SecondName + " " + person._ThirdName + " " + person._LastName;
            if (!string.IsNullOrWhiteSpace(person._ImagePath))
                pictureBox1.ImageLocation = person._ImagePath;
            else
                pictureBox1.Image = Resources.unknown;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ID != 0)
            {
                FrmUpdatePerson updatePerson = new FrmUpdatePerson(ID);
                updatePerson.UpdatePerson += UpdateInfo;
                updatePerson.ShowDialog();
            }
            else
                MessageBox.Show("Can't Update Enter PersonID","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateInfo(object sender)
        {
            GetPersonID(ID);
        }

        
    }
}
