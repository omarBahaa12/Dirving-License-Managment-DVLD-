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
    public partial class FrmRenewLocalLicense : Form
    {
        public delegate void IsReneworNot(bool isRenew);
        public event IsReneworNot IsReneworNotChanged;
        private int _UserID;
        private int _OldL_LicenseID;
        private int _ValidityLength;
        private int RenewLicenseID;
        private int _PersonID;
        public FrmRenewLocalLicense(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            ucRenewL_License1.ValidityLicense += GetValidityLength;
            this.IsReneworNotChanged += ucFindByLocalLicense1.IsRenew;
            IsReneworNotChanged?.Invoke(true);
        }

        private void GetValidityLength(int ValidityLength)
        {
            _ValidityLength = ValidityLength;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int CreateRenewApplication(int PersonID)
        {
            clsApplication RenewApplication=new clsApplication(0,"Completed",2,PersonID,DateTime.Now,_UserID);
            RenewApplication.Add();
            return RenewApplication._ApplicationID;
        }
        private int CreateRenewLicense(int RenewApplicationID)
        {
            clsLicenses RenewLicense = new clsLicenses(0,RenewApplicationID, 
                clsLicenses.GetDriverID(_OldL_LicenseID),DateTime.Now,
                DateTime.Now.AddYears(_ValidityLength),"Renewed",ucRenewL_License1._Notes,true,
                clsLicenses.LicenseClassName(_OldL_LicenseID));
            RenewLicense.Add();
            clsLicenses.DeActived(_OldL_LicenseID);
            MessageBox.Show($"Renewed Successfully License ID={RenewLicense._LicenseID}",
                $"Expire Date= {RenewLicense._ExpireDate.ToShortDateString()}");
            return RenewLicense._LicenseID;
        }
        private void RenewLocalLicense()
        {
            int RenewApplicationID=CreateRenewApplication(_PersonID);
            RenewLicenseID= CreateRenewLicense(RenewApplicationID);
            ucRenewL_License1.SetRnewLicenseIDandApplicationID(RenewLicenseID, RenewApplicationID);

        }
        private void Chip_Issue_Click(object sender, EventArgs e)
        {
            RenewLocalLicense();
            Link_ShowNewLicense.Enabled = true;
        }
        private void FrmRenewLocalLicense_Load(object sender, EventArgs e)
        {
            ucFindByLocalLicense1.GetL_LicenseID += PrepareData;
        }
        private void PrepareData(int L_LicenseID)
        {
            ucLicenseInfo1.SetLicenseInfo(L_LicenseID);
            ucRenewL_License1.SetdataInLabels(_UserID, L_LicenseID);
            _OldL_LicenseID = L_LicenseID;
            _PersonID=clsDrivers.GetPersonID(clsLicenses.GetDriverID(L_LicenseID));
        }

        private void Link_PersonLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_OldL_LicenseID != 0)
            {
                FrmLicensePersonHistory personHistory = new FrmLicensePersonHistory(_PersonID);
                personHistory.ShowDialog();
            }
            else
                MessageBox.Show("Enter License ID","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Link_ShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLicenseInfo licenseInfo = new FrmLicenseInfo(RenewLicenseID);
            licenseInfo.ShowDialog();
        }
    }
}
