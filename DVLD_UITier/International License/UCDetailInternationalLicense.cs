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
    public partial class UCDetailInternationalLicense : UserControl
    {
        public UCDetailInternationalLicense()
        {
            InitializeComponent();
        }

        public void SetDataInLables(int L_LicenseID,int UserID)
        {
            Lb_ApplicationDate.Text=DateTime.Now.ToShortDateString();
            Lb_IssueDate.Text=DateTime.Now.ToShortDateString();
            Lb_ExpireDate.Text=DateTime.Now.AddDays(365).ToShortDateString();
            Lb_Fees.Text=clsApplicationType.GetApplicationTypeFees(6).ToString();
            Lb_CreatedBy.Text=clsUser.GetUserName(UserID);
            Lb_LicenseID.Text=L_LicenseID.ToString();
        }
        public void SetApplicationIDAndI_LicenseID(int ApplicationID,int I_LicenseID)
        {
            Lb_I_LicenseApplicationID.Text=ApplicationID.ToString();
            Lb_I_LicenseID.Text=I_LicenseID.ToString();
        }
        
    }
}
