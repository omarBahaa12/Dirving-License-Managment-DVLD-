using BusinessTier;
using DVLD_UITier.LocalLicenseOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.International_License
{
    public partial class FrmAddInternationalLicense : Form
    {
        private int _UserID;
        private int _L_LicenseID;
        private int _ApplicationID;
        public FrmAddInternationalLicense(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            
        }
        private bool IsHasInternationalLicense(int L_LicenseID)
        {          
            if (!clsInternationalLicenses.IsHasInternationalLicense(L_LicenseID))
                return true;
            return false;             
        }
        private void GetL_LicenseID(int L_LicenseID)
        {
            if (IsHasInternationalLicense(L_LicenseID))
            {
                ucLicenseInfo1.SetLicenseInfo(L_LicenseID);
                ucDetailInternationalLicense1.SetDataInLables(L_LicenseID, _UserID);
                _L_LicenseID = L_LicenseID;
            }
            else
                MessageBox.Show("Person Has Same International License", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void FrmAddInternationalLicense_Load(object sender, EventArgs e)
        {
            ucFindByLocalLicense1.GetL_LicenseID += GetL_LicenseID;
        }
        private int CreateApplication()
        {
            clsApplication application = new clsApplication(0, "New", 6,
                clsDrivers.GetPersonID(clsLicenses.GetDriverID(_L_LicenseID)), DateTime.Now, _UserID);
            application.Add();
            return application._ApplicationID;

        }
        private int IssueInternationalLicense(int ApplicationID)
        {
            clsInternationalLicenses internationalLicenses=new clsInternationalLicenses(0,_L_LicenseID,
                clsLicenses.LicenseClassName(_L_LicenseID),ApplicationID,
                clsLicenses.GetDriverID(_L_LicenseID), DateTime.Now,DateTime.Now.AddDays(365),true);
            internationalLicenses.Add();
            return internationalLicenses._InternationalLicenseID;
        }
        private void Chip_Issue_Click(object sender, EventArgs e)
        {
            if (_L_LicenseID != 0)
            {
                _ApplicationID = CreateApplication();
                ucDetailInternationalLicense1.SetApplicationIDAndI_LicenseID(_ApplicationID, IssueInternationalLicense(_ApplicationID));
                Link_LicensePersonHistory.Enabled = true;
                ucFindByLocalLicense1.Enabled = false;
            }
            else
                MessageBox.Show("Enter License ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Link_LicensePersonHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLicensePersonHistory personHistory = new 
                FrmLicensePersonHistory(clsDrivers.GetPersonID(clsLicenses.GetDriverID(_L_LicenseID)));
            personHistory.ShowDialog();
        }
  
    }
}
