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

namespace DVLD_UITier.UserControls
{
    public partial class UCLicenseInfo : UserControl
    {
        public UCLicenseInfo()
        {
            InitializeComponent();
        }

        private void SetPersonData(int PersonID)
        {
            clsPerson person = clsPerson.GetPerson(PersonID);
            if (person != null )
            {
                Lb_FullName.Text = person._FirstName + " " + person._SecondName + " " + person._ThirdName + " " + person._LastName;
                Lb_DateOfBirth.Text=person._BirthDate.ToShortDateString();
                Gender.Text = person._Gender;
                Lb_NationalNumber.Text = person._NationalNo;
                if(!string.IsNullOrWhiteSpace(person._ImagePath))
                {
                    pictureBox1.ImageLocation = person._ImagePath;
                }
                else
                {
                    if (person._Gender.Trim() == "Male")
                        pictureBox1.Image = Resources.unknown;
                    else
                        pictureBox1.Image = Resources.anonymous_woman;
                }
            }
        }
        public void SetLicenseInfo(int LicenseID)
        {
            clsLicenses license=clsLicenses.Find(LicenseID);
            if (license != null)
            {
                SetPersonData( clsDrivers.GetPersonID(license._DriverID));
                Lb_LicenseClass.Text = license._LicenseName;
                Lb_IssueReason.Text = license._IssueReason;
                Lb_ExpireDate.Text = license._ExpireDate.ToShortDateString();
                Lb_IssueDate.Text = license._IssueDate.ToShortDateString();
                Lb_DriverID.Text = license._DriverID.ToString();
                Lb_LicenseID.Text= license._LicenseID.ToString();
                if (!string.IsNullOrWhiteSpace(license._Notes))
                    Lb_Notes.Text = license._Notes;
                else
                    Lb_Notes.Text = "No Notes";
                if (license._IsActive)
                    Lb_IsActive.Text = "Yes";
                else
                    Lb_IsActive.Text = "No";
                if (!clsDetainedLicense.IsExist(LicenseID))
                {
                    Lb_IsDetained.Text = "No";
                }
                else
                    Lb_IsDetained.Text = "Yes";
                
            }
        }

        
    }
}
