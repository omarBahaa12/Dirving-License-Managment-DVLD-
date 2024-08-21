using BusinessTier;
using DVLD_UITier.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_UITier.UserControls.UCRenewL_License;

namespace DVLD_UITier.LocalLicenseOperation
{
    public partial class FrmReplaceForLostOrDamaged : Form
    {
        private int _UserID;
        private int _L_LicenseID;
        private short _Reason;

        private int ReplaceLicenseID;
        private int _PersonID;
        public FrmReplaceForLostOrDamaged(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetReasonAndSendDatatoUcDamageLostApplication(short Reason)
        {
            _Reason = Reason;
            if(_L_LicenseID!=0)
                ucDamagedorLostApplication1.SetdataInLabels(_UserID,_L_LicenseID, Reason);
            else
                MessageBox.Show("Enter Local License ID","ERROR??",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private int CreateDamagedorLostApplication(int PersonID)
        {
            clsApplication RenewApplication = new clsApplication(0, "Completed", _Reason, PersonID, DateTime.Now, _UserID);
            RenewApplication.Add();
            return RenewApplication._ApplicationID;
        }
        private int CreateReplaceLicense(int DamagedLostApplicationID)
        {
            int ValidityLength = clsLicenseClass.ValidityLength(
                clsLicenseClass.LicenseClassID(clsLicenses.LicenseClassName(_L_LicenseID)));
            clsLicenses RenewLicense = new clsLicenses(0, DamagedLostApplicationID,clsLicenses.GetDriverID(_L_LicenseID),
                DateTime.Now,DateTime.Now.AddYears(ValidityLength),clsApplicationType.GetApplicationTypeName(_Reason),
                "", true,clsLicenses.LicenseClassName(_L_LicenseID));
            RenewLicense.Add();
            clsLicenses.DeActived(_L_LicenseID);
            MessageBox.Show($"Replaced Successfully License ID={RenewLicense._LicenseID}",
                $"Expire Date= {RenewLicense._ExpireDate.ToShortDateString()}");
            return RenewLicense._LicenseID;
        }
        private void ReplaceLocalLicense()
        {
            int RenewApplicationID = CreateDamagedorLostApplication(_PersonID);
            ReplaceLicenseID = CreateReplaceLicense(RenewApplicationID);
            ucDamagedorLostApplication1.SetRnewLicenseIDandApplicationID(ReplaceLicenseID, RenewApplicationID);

        }
        private void Chip_Issue_Click(object sender, EventArgs e)
        {
            ReplaceLocalLicense();
            Link_ShowNewLicense.Enabled = true;
        }
        private void FrmReplaceForLostOrDamaged_Load(object sender, EventArgs e)
        {
            ucFindByLocalLicense1.GetL_LicenseID += GetLocalLicenseID;
            ucLostOrDamaged1.OnFinishCheck += GetReasonAndSendDatatoUcDamageLostApplication;

        }
        private void GetLocalLicenseID(int L_LicenseID)
        {
            ucLicenseInfo1.SetLicenseInfo(L_LicenseID);
            _L_LicenseID = L_LicenseID;
            _PersonID=clsDrivers.GetPersonID(clsLicenses.GetDriverID(L_LicenseID));
        }
        private void Link_ShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLicenseInfo licenseInfo = new FrmLicenseInfo(ReplaceLicenseID);
            licenseInfo.ShowDialog();
        }
        private void Link_PersonLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_L_LicenseID != 0)
            {               
                FrmLicensePersonHistory personHistory = new FrmLicensePersonHistory(_PersonID);
                personHistory.ShowDialog();                              
            }
            else
                MessageBox.Show("Enter License ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
