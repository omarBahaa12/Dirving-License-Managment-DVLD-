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

namespace DVLD_UITier.LocalLicenseOperation.Detained___Release
{
    public partial class AddDetainedLicense : Form
    {
        public delegate void UpdateDetainedLicense();
        public event UpdateDetainedLicense Detained;
        private int _UserID;
        private int _LicenseID;
        public AddDetainedLicense(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }      
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Link_PersonLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseID != 0)
            {
                FrmLicensePersonHistory personHistory = new FrmLicensePersonHistory(
                    clsDrivers.GetPersonID(clsLicenses.GetDriverID(_LicenseID)));
                personHistory.ShowDialog();
            }
        }
        private void Link_ShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LicenseID != 0)
            {
                FrmLicenseInfo licenseInfo = new FrmLicenseInfo(_LicenseID);
                licenseInfo.ShowDialog();
            }
        }
        private void AddDetainedLicense_Load(object sender, EventArgs e)
        {
            ucFindByLocalLicense1.GetL_LicenseID += GetLicenseID;
        }
        private void GetLicenseID(int L_LicenseID)
        {
            if (!clsDetainedLicense.IsExist(L_LicenseID))
            {
                ucLicenseInfo1.SetLicenseInfo(L_LicenseID);
                ucDetainedLicenseInfo1.SetDataInLables(_UserID, L_LicenseID);
                _LicenseID = L_LicenseID;
            }
            else
            {
                MessageBox.Show("This License ID Is already Detained.","Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int CreateDetainedLlicense()
        {
            clsDetainedLicense detainedLicense = new clsDetainedLicense(0, _LicenseID,
                DateTime.Now, _UserID, ucDetainedLicenseInfo1._Fees);
            detainedLicense.Add();
            return detainedLicense._DetainedLicenseID;
        }
        private void Chip_Detained_Click(object sender, EventArgs e)
        {
            ucDetainedLicenseInfo1.SetDetainedID(CreateDetainedLlicense());
            Link_ShowNewLicense.Enabled = true;
            Detained?.Invoke();
        }
    }
}
