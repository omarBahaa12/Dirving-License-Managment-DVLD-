using BusinessTier;
using DVLD_UITier.ApplicationOperations;
using DVLD_UITier.Cars.Forms;
using DVLD_UITier.Drivers_Operations;
using DVLD_UITier.International_License;
using DVLD_UITier.LicenseOperation;
using DVLD_UITier.LocalLicenseOperation;
using DVLD_UITier.LocalLicenseOperation.Detained___Release;
using DVLD_UITier.TestOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier
{
    public partial class MainInterface : Form
    {
        private int UserID;
        public MainInterface(int ID)
        {
            UserID = ID;
            InitializeComponent();
        }
        private void peoplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePeople frmManage=new FrmManagePeople();
            frmManage.ShowDialog();
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmManage = new FrmManageUsers();
            frmManage.ShowDialog();
        }        
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser_sDetailedInfo User = new FrmUser_sDetailedInfo(clsUser.GetUser(UserID));
            User.ShowDialog();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword changePassword = new FrmChangePassword(UserID);
            changePassword.ShowDialog();
        }
        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageApplicationTypes types = new FrmManageApplicationTypes();
            types.ShowDialog();
        }
        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageTestTypes testTypes = new FrmManageTestTypes();
            testTypes.ShowDialog();
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddLocalLicense localLicense = new FrmAddLocalLicense(UserID);
            localLicense.ShowDialog();
        }
        private void localLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageLocalLicenseApplication application= new FrmManageLocalLicenseApplication(UserID);
            application.ShowDialog();
        }
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageDrivers drivers = new FrmManageDrivers();
            drivers.ShowDialog();
        }
        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddInternationalLicense internationalLicense=new FrmAddInternationalLicense(UserID);
            internationalLicense.ShowDialog();
        }
        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageInternationalLicenses frmManage=new FrmManageInternationalLicenses();
            frmManage.ShowDialog();
        }
        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRenewLocalLicense renewLocalLicense=new FrmRenewLocalLicense(UserID);
            renewLocalLicense.ShowDialog();
        }
        private void replaceForLostOrDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReplaceForLostOrDamaged damaged=new FrmReplaceForLostOrDamaged(UserID);
            damaged.ShowDialog();
        }   
        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDetainedLicense detainedLicense=new AddDetainedLicense(UserID);
            detainedLicense.ShowDialog();
        }
        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReleaseDetainedLicense detainedLicense = new FrmReleaseDetainedLicense(UserID);
            detainedLicense.ShowDialog();
        }
        private void manageDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageDetainedAndRelease frmManageDetainedAndRelease = new FrmManageDetainedAndRelease(UserID);
            frmManageDetainedAndRelease.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmManageCars cars = new FrmManageCars();
            cars.ShowDialog();

        }

    }
}
