using BusinessTier;
using DVLD_UITier.LocalLicenseOperation;
using DVLD_UITier.LocalLicenseOperation.TestOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.LicenseOperation
{
    public partial class FrmManageLocalLicenseApplication : Form
    {
        private int userID;
        private DataTable DataTable;
        private DataView FilterDVL_L_Applications;

        public FrmManageLocalLicenseApplication(int UserID)
        {
            InitializeComponent();
            userID = UserID;
        }
        private void SetListInDataGrid()
        {
            DG_LocalLicenseApplication.DataSource=DataTable=clsL_LicenseApplication.L_LicenseApplicationList();
            FilterDVL_L_Applications = DataTable.DefaultView;
        }
        private void FrmManageLocalLicenseApplication_Load(object sender, EventArgs e)
        {
            SetListInDataGrid();
        }
        private void Btn_AddL_L_Application_Click(object sender, EventArgs e)
        {
            FrmAddLocalLicense NewL_L=new FrmAddLocalLicense(userID);
            NewL_L.UpdateAndAdd += SetListInDataGrid;
            NewL_L.ShowDialog();
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FilterByL_L_ApplicationID()
        {
            if (int.TryParse(Txtb_Filterby.Texts, out int L_L_ID))
            {
                FilterDVL_L_Applications = DataTable.DefaultView;
                FilterDVL_L_Applications.RowFilter = $"LocalLicenseApplicationID='{L_L_ID}'";
                DG_LocalLicenseApplication.DataSource = FilterDVL_L_Applications;
            }
            else
                DG_LocalLicenseApplication.DataSource = DataTable.AsDataView();
        }
        private void FilterByNationalNumber()
        {
            if (!string.IsNullOrWhiteSpace(Txtb_Filterby.Texts))
            {
                 FilterDVL_L_Applications.RowFilter =$"NationalNumber like '{Txtb_Filterby.Texts}%'";
                DG_LocalLicenseApplication.DataSource = FilterDVL_L_Applications;
            }
            else
                DG_LocalLicenseApplication.DataSource = DataTable.AsDataView();
        }
        private void FilterByFullName()
        {
            if(!string.IsNullOrWhiteSpace (Txtb_Filterby.Texts))
            {
                FilterDVL_L_Applications=DataTable.DefaultView;
                FilterDVL_L_Applications.RowFilter = $"FullName like '{Txtb_Filterby.Texts}%'";
                DG_LocalLicenseApplication.DataSource = FilterDVL_L_Applications;
            }
            else
                DG_LocalLicenseApplication.DataSource= DataTable.AsDataView();
        }
        private void FilterByStatus()
        {
            if (Cmb_FilterByStatus.SelectedIndex == 1)
            {
                FilterDVL_L_Applications = DataTable.DefaultView;
                FilterDVL_L_Applications.RowFilter = $"ApplicationStatus='New'";
                DG_LocalLicenseApplication.DataSource = FilterDVL_L_Applications;
            }
            else if (Cmb_FilterByStatus.SelectedIndex == 2)
            {
                FilterDVL_L_Applications = DataTable.DefaultView;
                FilterDVL_L_Applications.RowFilter = $"ApplicationStatus='Cancel'";
                DG_LocalLicenseApplication.DataSource = FilterDVL_L_Applications;
            }
            else if (Cmb_FilterByStatus.SelectedIndex == 3)
            {
                FilterDVL_L_Applications = DataTable.DefaultView;
                FilterDVL_L_Applications.RowFilter = $"ApplicationStatus='Completed'";
                DG_LocalLicenseApplication.DataSource = FilterDVL_L_Applications;
            }
            else
                DG_LocalLicenseApplication.DataSource = DataTable.AsDataView();
        }
        private void ShowTextOrCombo(bool Txtb,bool cmb)
        {
            if(cmb)
            {
                Cmb_FilterByStatus.Visible = true;
                Txtb_Filterby.Visible = false;
            }
            else if(Txtb)
            {
                Txtb_Filterby.Visible = true;
                Cmb_FilterByStatus.Visible=false;
            }
            else
            {
                Txtb_Filterby.Visible=false;
                Cmb_FilterByStatus.Visible=false;
            }

        }
        private void WhichFilterSelected()
        {
            switch(Cmb_FilterBy.SelectedIndex)
            {
                case 0:
                    SetListInDataGrid();
                    ShowTextOrCombo(false, false);
                    break;
                case 1:
                    FilterByL_L_ApplicationID();
                    ShowTextOrCombo(true, false);
                    break;
                case 2:
                    FilterByNationalNumber();
                    ShowTextOrCombo(true, false);
                    break;
                case 3:
                    FilterByFullName();
                    ShowTextOrCombo(true, false);
                    break;
                case 4:
                    FilterByStatus();
                    ShowTextOrCombo(false, true);
                    break;
            }

        }
        private void Cmb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhichFilterSelected();
        }
        private void Cmb_FilterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhichFilterSelected();
        }
        private void Txtb_Filterby__TextChanged(object sender, EventArgs e)
        {
            WhichFilterSelected();
        }
        private bool Confirming()
        {
            if(MessageBox.Show("Are you Sure to Delete this Application??","Confirm"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        private bool Deleting(int L_L_ApplicationID)
        {
            if(Confirming())
            {
                if(clsL_LicenseApplication.Delete(L_L_ApplicationID))
                    return true;
            }
            return false;
        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Deleting(Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("Deleted Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetListInDataGrid();
            }
            else
                MessageBox.Show("Failed To Delete", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowL_L_ApplicationDetailed frmShowL_L = new FrmShowL_L_ApplicationDetailed(
                Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value));
            frmShowL_L.ShowDialog();
        }
        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateL_LicenseApplication frmUpdate = new FrmUpdateL_LicenseApplication
                (userID, Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value));
            frmUpdate.UpdatedApplication += SetListInDataGrid;
            frmUpdate.ShowDialog();
        }
        private bool UpdateApplicationStatus()
        {
            if(MessageBox.Show("Are You Sure Cancel This Application??","Warning"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                if (clsL_LicenseApplication.UpdateApplicationStatus(
                    Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value),"Cancel"))
                    return true;
            return false;
        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UpdateApplicationStatus())
            {
                MessageBox.Show("Updated Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetListInDataGrid();
            }
            else
                MessageBox.Show("Failed to Updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void CheckingTestPassed()
        {
            byte TestPassed = clsL_LicenseApplication.GetTestPassed(Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value));
            if(TestPassed == 0)
            {
                sechduleVisionTestToolStripMenuItem.Enabled = true;
                sechduleStreetTestToolStripMenuItem.Enabled = false;
                sechduleWrittenTestToolStripMenuItem.Enabled = false;
            }
            else if(TestPassed == 1)
            {
                sechduleVisionTestToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = false;
                sechduleWrittenTestToolStripMenuItem.Enabled = true;
            }
            else
            {
                sechduleVisionTestToolStripMenuItem.Enabled = false;
                sechduleStreetTestToolStripMenuItem.Enabled = true;
                sechduleWrittenTestToolStripMenuItem.Enabled = false;
            }
        }      
        private void schudToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            CheckingTestPassed();

        }
        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTestAppointment test = new FrmShowTestAppointment(
                Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value),1);
            test.TestPassed_ += SetListInDataGrid;
            test.ShowDialog();
        }
        private bool CheckIsCancel()
        {
            if(DG_LocalLicenseApplication.CurrentRow.Cells[6].Value.ToString()=="Cancel")
            {
                editApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                schudToolStripMenuItem.Enabled = false;
                issueLicenseToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                return false;
            }
            return true;
        }
        private bool CheckIsPassed3Tests()
        {
            if (Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[5].Value) == 3)
                return true;
            return false;
        }
        private void CheckIsStatusNew()
        {
            if (DG_LocalLicenseApplication.CurrentRow.Cells[6].Value.ToString() == "New" &&
                CheckIsPassed3Tests())
            {
                schudToolStripMenuItem.Enabled = false;
                issueLicenseToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                schudToolStripMenuItem.Enabled = true;
                issueLicenseToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
            }
        }
        private bool CheckIsComplete()
        {
            if (DG_LocalLicenseApplication.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                issueLicenseToolStripMenuItem.Enabled = false;
                schudToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
                return false;
            }
            return true;
        }
        private void DG_LocalLicenseApplication_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (CheckIsCancel())
            {
                if (CheckIsComplete())
                {
                    CheckIsStatusNew();
                }
            }
        }
        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTestAppointment test = new FrmShowTestAppointment(
                Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value), 2);
            test.TestPassed_ += SetListInDataGrid;
            test.ShowDialog();
        }
        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTestAppointment test = new FrmShowTestAppointment(
                Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value), 3);
            test.TestPassed_ += SetListInDataGrid;
            test.ShowDialog();
        }
        private void issueLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIssueLocalLicense localLicense = new FrmIssueLocalLicense
                (Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value));
            localLicense.UpdateStatus += SetListInDataGrid;
            localLicense.ShowDialog();
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenseInfo licenseInfo=new FrmLicenseInfo(clsLicenses.GetLicenseID
                (clsL_LicenseApplication.GetApplicationID(
                    Convert.ToInt32(DG_LocalLicenseApplication.CurrentRow.Cells[0].Value))));
            licenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicensePersonHistory frmLicensePersonHistory = new FrmLicensePersonHistory
                (clsL_LicenseApplication.GetPersonID(Convert.ToInt32(
                    DG_LocalLicenseApplication.CurrentRow.Cells[0].Value)));
            frmLicensePersonHistory.ShowDialog();
        }
    }
}
