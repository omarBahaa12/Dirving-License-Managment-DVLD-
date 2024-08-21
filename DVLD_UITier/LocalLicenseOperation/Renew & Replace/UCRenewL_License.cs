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

namespace DVLD_UITier.UserControls
{
    public partial class UCRenewL_License : UserControl
    {
        public delegate void RenewLicense(int ValidityLength);
        public event RenewLicense ValidityLicense;
        public string _Notes {  get; private set; }
        public UCRenewL_License()
        {
            InitializeComponent();
        }

        public void SetdataInLabels(int UserID,int LicenseID)
        {
            int LicenseClassID=clsLicenseClass.LicenseClassID(clsLicenses.LicenseClassName(LicenseID));
            int ValiditLength= clsLicenseClass.ValidityLength(LicenseClassID);
            Lb_OldLicenseID.Text = LicenseID.ToString();
            Lb_CreatedBy.Text = clsUser.GetUserName(UserID);
            Lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            Lb_IssueDate.Text = DateTime.Now.ToShortDateString();
            Lb_ExpireDate.Text= DateTime.Now.AddYears(ValiditLength).ToString();
            Lb_ApplicationFees.Text = clsApplicationType.GetApplicationTypeFees(2).ToString();
            Lb_LicenseFees.Text = clsLicenseClass.GetFeesLicenseClass(LicenseClassID).ToString();
            Lb_TotalFees.Text=(Convert.ToInt32(Lb_ApplicationFees.Text)+Convert.ToInt32(Lb_LicenseFees.Text)).ToString();
            ValidityLicense?.Invoke(ValiditLength);
        }

        private void Txtb_Notes_TextChanged(object sender, EventArgs e)
        {
            _Notes=Txtb_Notes.Text;
        }

        public void SetRnewLicenseIDandApplicationID(int R_LicenseID,int R_ApplicationID)
        {
            Lb_R_ApplicationID.Text=R_ApplicationID.ToString();
            Lb_R_LicenseID.Text=R_LicenseID.ToString();
        }

       
    }
}
