using BusinessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.LocalLicenseOperation
{
    public partial class FrmIssueLocalLicense : Form
    {
        public delegate void IssueLicenseDone();
        public event IssueLicenseDone UpdateStatus;
        private string Notes;
        private int _L_LicenseApplicationID;
        public FrmIssueLocalLicense(int L_L_ApplicationID)
        {
            InitializeComponent();
            _L_LicenseApplicationID = L_L_ApplicationID;
            ucL_L_ApplicationDetail1.SetL_L_ApplicationData(L_L_ApplicationID);
            ucDetailApplicationInfo1.SetData(clsL_LicenseApplication.GetApplicationID(L_L_ApplicationID));

        }
        private void Txtb_Notes_TextChanged(object sender, EventArgs e)
        {
            Notes=Txtb_Notes.Text;
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int CreateDriver()
        {
            if (!clsDrivers.IsExist(clsL_LicenseApplication.GetPersonID(_L_LicenseApplicationID)))
            {
                clsDrivers NewDriver = new clsDrivers(0, clsL_LicenseApplication.GetPersonID(_L_LicenseApplicationID));
                NewDriver.Add();
                return NewDriver._DriverID;
            }
            return clsDrivers.GetDriverID(clsL_LicenseApplication.GetPersonID(_L_LicenseApplicationID));
        }
        private void CreateLicense()
        {
            short ValidityLength = clsLicenseClass.ValidityLength
                (clsL_LicenseApplication.GetLicenseClassID(_L_LicenseApplicationID));
            TimeSpan ExpireDate = new TimeSpan(ValidityLength*365*24,0,0);

            clsLicenses NewLicense=new clsLicenses(0,clsL_LicenseApplication.GetApplicationID
                (_L_LicenseApplicationID),CreateDriver(),DateTime.Now,DateTime.Now.Add(ExpireDate),
                "FirstTime",Notes,true,clsLicenseClass.LicenseClassName
                (clsL_LicenseApplication.GetLicenseClassID(_L_LicenseApplicationID)));

            NewLicense.Add();
            if (NewLicense._LicenseID != 0)
            {
                MessageBox.Show("Added Successfully", "DONE");
                clsL_LicenseApplication.UpdateApplicationStatus(_L_LicenseApplicationID, "Completed");
            }
            else
                MessageBox.Show("Failed To Added", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            
        }
        private void Btn_Issue_Click(object sender, EventArgs e)
        {
            CreateLicense();
            UpdateStatus?.Invoke();
        }
    }
}
