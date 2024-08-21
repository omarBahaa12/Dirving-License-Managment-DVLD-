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
    public partial class UCFindByLocalLicense : UserControl
    {
        public delegate void ReturnL_LicenseID(int L_LicenseID);
        public event ReturnL_LicenseID GetL_LicenseID;
        private bool _IsRenew=false;
        public UCFindByLocalLicense()
        {
            InitializeComponent();
        }
        public void IsRenew(bool Isrenew)
        {
            _IsRenew = Isrenew;
        }       
        private bool IsExist(int LicenseID)
        {
            if(clsLicenses.IsExist(LicenseID))
                return true; 
            return false;
        }
        private bool IsActive(int licenseID)
        {
            if(clsLicenses.IsActive(licenseID))
                return true;
            return false;
        }
        private bool IsExpired(int licenseID) 
        {
            if (!_IsRenew)
            {
                if (clsLicenses.IsLicenseExpired(licenseID))
                    return true;
                return false;
            }
            if (!clsLicenses.IsLicenseExpired(licenseID))
                return true;
            return false;

        }
        private void SearchLocalLicense()
        {
            if(!string.IsNullOrWhiteSpace(Txtb_FindLicense.Texts)&&int.TryParse(Txtb_FindLicense.Texts,out int LicenseID))
            {
                if(IsExist(LicenseID))
                {                    
                    if (IsActive(LicenseID))
                    {
                        if (IsExpired(LicenseID))
                        {
                            GetL_LicenseID?.Invoke(LicenseID);
                        }
                        else
                        {
                            if(!_IsRenew)
                                MessageBox.Show("This Local License Is Expired Please Renew It", "Renew",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("This Local License Is not Expired", "Not Expired",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("This Local License Is not Active", "Activation",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);                                      
                }
                else
                    MessageBox.Show("Not Found...", "??",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            SearchLocalLicense();
        }
    }
}
