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
    public partial class UCAddLocalLicense : UserControl
    {
        public int LicenseClassID {  get; set; }
        public UCAddLocalLicense()
        {
            InitializeComponent();
            
        }
        public void SetDataToUpdate(int L_L_ApplicationID)
        {
            clsL_LicenseApplication licenseApplication=clsL_LicenseApplication.Find(L_L_ApplicationID);
            if (licenseApplication != null)
            {
                Lb_ShowFees.Text = clsApplicationType.GetApplicationTypeFees(licenseApplication._ApplicationID).ToString();
                Lb_ShowApplicationDate.Text=licenseApplication._ApplicationDate.ToShortDateString();
                LicenseClassID = licenseApplication._LicenseClassID-1;
            }
        }
        private void UCAddLocalLicense_Load(object sender, EventArgs e)
        {
            Lb_ShowApplicationDate.Text = DateTime.Today.ToShortDateString();
            foreach (DataRow row in clsLicenseClass.LicenseClassListName().Rows)
            {
                Cmb_LicenseClass.Items.Add(row[0].ToString());
            }
            Lb_ShowFees.Text = clsApplicationType.GetApplicationTypeFees(3).ToString();
            Cmb_LicenseClass.SelectedIndex = LicenseClassID;
        }
        public void GetUserID(int UserID)
        {
            clsUser user=clsUser.GetUser(UserID);
            Lb_Creator.Text = user._UserName;
        }
        private void Cmb_LicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LicenseClassID=clsLicenseClass.LicenseClassID(Cmb_LicenseClass.SelectedItem.ToString());
        }
        public void SetL_L_ApplicationID(int L_ApplicationID)
        {
            Lb_ShowL_L_ApplicationID.Text= L_ApplicationID.ToString();
        }
    }
}
