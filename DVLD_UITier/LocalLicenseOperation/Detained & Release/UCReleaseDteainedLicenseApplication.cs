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
    public partial class UCReleaseDteainedLicenseApplication : UserControl
    {
        public UCReleaseDteainedLicenseApplication()
        {
            InitializeComponent();
        }
        public void SetDataInLabels(int UserID,int LicenseID)
        {
            Lb_DetainedID.Text=clsDetainedLicense.GetDetainedID(LicenseID).ToString();
            Lb_LicenseID.Text = LicenseID.ToString();
            Lb_CreatedBy.Text = clsUser.GetUserName(UserID);
            Lb_ApplicationDate.Text=DateTime.Now.ToShortDateString();
            Lb_ApplicationFees.Text = clsApplicationType.GetApplicationTypeFees(5).ToString();
            Lb_FineFees.Text=clsDetainedLicense.GetFineFees(LicenseID).ToString();
            Lb_TotalFees.Text=(Convert.ToInt32(Lb_ApplicationFees.Text)+Convert.ToDouble(Lb_FineFees.Text)).ToString();

        }
        public void SetApplicationID(int ApplicationID)
        {
            Lb_ApplicationID.Text=ApplicationID.ToString();
        }
    }
}
