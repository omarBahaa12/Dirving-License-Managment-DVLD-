using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessTier;

namespace DVLD_UITier.LocalLicenseOperation.Detained___Release
{
    public partial class FrmReleaseDetainedLicense : Form
    {
        public delegate void UpdateLicense();
        public event UpdateLicense Release;
        private int _UserID;
        private int _LicenseID;
        private int _PersonID;
        public FrmReleaseDetainedLicense(int UserID,int LicenseID=0)
        {
            InitializeComponent();
            _UserID = UserID;
            if(LicenseID!=0)
            {
                _LicenseID = LicenseID;
                ucFindByLocalLicense1.Enabled = false;
                GetLicenseID(_LicenseID);
            }
        }
        private void FrmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            ucFindByLocalLicense1.GetL_LicenseID += GetLicenseID;
        }
        private void GetLicenseID(int L_LicenseID)
        {
            if (clsDetainedLicense.IsExist(L_LicenseID))
            {
                ucLicenseInfo1.SetLicenseInfo(L_LicenseID);
                ucReleaseDteainedLicenseApplication1.SetDataInLabels(_UserID, L_LicenseID);
                _LicenseID = L_LicenseID;
            }
            else
                MessageBox.Show($"There is no License Detained ID={L_LicenseID}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int CreateReleaseApplication()
        {
            _PersonID = clsDrivers.GetPersonID(clsLicenses.GetDriverID(_LicenseID));
            clsApplication application = new clsApplication(0, "Completed", 5, _PersonID, DateTime.Now, _UserID);
            application.Add();
            return application._ApplicationID;
        }
        private bool ReleaseDetainedLicense(int ReleasedApplicationID)
        {           
            if(clsDetainedLicense.Update(clsDetainedLicense.GetDetainedID(_LicenseID),DateTime.Now,ReleasedApplicationID))
                return true;
            return false;
        }
        private void Chip_Release_Click(object sender, EventArgs e)
        {
            if (_LicenseID != 0)
            {
                int ReleasedApplicationID=CreateReleaseApplication();
                ucReleaseDteainedLicenseApplication1.SetApplicationID(ReleasedApplicationID);
                if (ReleaseDetainedLicense(ReleasedApplicationID))
                {
                    MessageBox.Show("Release Successfully","Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Link_ShowNewLicense.Enabled = true;
                    Release?.Invoke();
                }
            }
        }
        private void Link_ShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_LicenseID!=0)
            {
                FrmLicenseInfo licenseInfo = new FrmLicenseInfo(_LicenseID);
                licenseInfo.Show();
            }
        }
        private void Link_PersonLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_LicenseID!= 0)
            {
                FrmLicensePersonHistory personHistory = new FrmLicensePersonHistory(_PersonID);
                personHistory.Show();
            }
        }
    }
}
