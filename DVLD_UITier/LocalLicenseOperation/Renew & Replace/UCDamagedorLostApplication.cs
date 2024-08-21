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
    public partial class UCDamagedorLostApplication : UserControl
    {
        public UCDamagedorLostApplication()
        {
            InitializeComponent();
        }

        public void SetdataInLabels(int UserID, int LicenseID,int ApplicationType)
        {
            Lb_OldLicenseID.Text = LicenseID.ToString();
            Lb_CreatedBy.Text = clsUser.GetUserName(UserID);
            Lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            Lb_ApplicationFees.Text = clsApplicationType.GetApplicationTypeFees(ApplicationType).ToString();
        }
        public void SetRnewLicenseIDandApplicationID(int R_LicenseID, int R_ApplicationID)
        {
            Lb_R_ApplicationID.Text = R_ApplicationID.ToString();
            Lb_R_LicenseID.Text = R_LicenseID.ToString();
        }
    }
}
