using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.LocalLicenseOperation
{
    public partial class FrmUpdateL_LicenseApplication : Form
    {
        public delegate void UpdatedDone();
        public event UpdatedDone UpdatedApplication;
        private int L_L_ApplicationID;
        public FrmUpdateL_LicenseApplication(int userID,int l_L_ApplicationID)
        {
            InitializeComponent();
            L_L_ApplicationID = l_L_ApplicationID;
            ucFindByNationalNo1.FoundPerson_ += ucDetailedInfo1.GetPerson;
            ucFindByNationalNo1.SetPersonIDToUpdate(clsL_LicenseApplication.GetPersonID(l_L_ApplicationID));
            ucAddLocalLicense1.SetDataToUpdate(l_L_ApplicationID);
            ucAddLocalLicense1.SetL_L_ApplicationID(l_L_ApplicationID);
            ucAddLocalLicense1.GetUserID(userID);
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckLicenseClassID()
        {
            if (ucAddLocalLicense1.LicenseClassID != 0)
                return true;
            return false;
        }
        private bool CheckPersonID()
        {
            if(ucDetailedInfo1.ID != 0)
                return true;
            return false;
        }
        private void UpdatingElement(clsL_LicenseApplication _LicenseApplication)
        {
            _LicenseApplication._LicenseClassID = ucAddLocalLicense1.LicenseClassID;
            _LicenseApplication._PersonID = ucDetailedInfo1.ID;
        }
        private void CheckAndUpdate()
        {
            if (CheckLicenseClassID())
            {
                if (CheckPersonID())
                {
                    clsL_LicenseApplication licenseApplication= clsL_LicenseApplication.Find(L_L_ApplicationID);
                    UpdatingElement(licenseApplication);
                    if(licenseApplication.Update())
                        MessageBox.Show("Updated Successfully","DONE",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Please Enter PersonID right","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Enter LicenseClass right", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            CheckAndUpdate();
            UpdatedApplication?.Invoke();
        }
    }
}
