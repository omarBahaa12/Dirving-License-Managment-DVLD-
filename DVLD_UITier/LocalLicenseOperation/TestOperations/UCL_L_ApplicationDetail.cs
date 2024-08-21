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
    public partial class UCL_L_ApplicationDetail : UserControl
    {
        public delegate void ReturnPersonID(int PersonID);
        public event ReturnPersonID PersonID;
        public UCL_L_ApplicationDetail()
        {
            InitializeComponent();
        }
        public void SetL_L_ApplicationData(int L_L_ApplicationID)
        {
            clsL_LicenseApplication application = clsL_LicenseApplication.Find(L_L_ApplicationID);
            if (application != null)
            {
                Lb_ShowTestPassed.Text = application._TestPassed.ToString() + "/" + "3";
                Lb_Show_L_L_ApplicationID.Text = application._L_LicenseApplicationID.ToString();
                Lb_SowApplicationStatus.Text=application._ApplicationStatus;
                Lb_ShowClassName.Text = clsLicenseClass.LicenseClassName(application._LicenseClassID);
                Lb_ShowApplicationDate.Text=application._ApplicationDate.ToShortDateString();
                PersonID?.Invoke(application._PersonID);
            }
        }
        
    }
}
