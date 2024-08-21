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

namespace DVLD_UITier.LocalLicenseOperation.Detained___Release
{
    public partial class FrmManageDetainedAndRelease : Form
    {
        private DataTable DetainTable;
        private DataView DetainView;
        private int _UserID;
        public FrmManageDetainedAndRelease(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
           
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetDataDGView()
        {
            DG_DetainedReleased.DataSource = DetainTable = clsDetainedLicense.ReleasedAndDetainedLlicenseList();
            DetainView = DetainTable.DefaultView;
        }
        private void FrmManageDetainedAndRelease_Load(object sender, EventArgs e)
        {
            SetDataDGView();
            ComB_FilterBy.SelectedIndex = 0;
            Comb_IsReleased.SelectedIndex = 0;
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicensePersonHistory personHistory = new FrmLicensePersonHistory(
                clsDrivers.GetPersonID(clsLicenses.GetDriverID(
                    Convert.ToInt32(DG_DetainedReleased.CurrentRow.Cells[1].Value))));
            personHistory.Show();
        }
        private void personInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetailedInformation detailedInformation = new FrmShowDetailedInformation(
                clsDrivers.GetPersonID(clsLicenses.GetDriverID( 
                    Convert.ToInt32(DG_DetainedReleased.CurrentRow.Cells[1].Value))));
            detailedInformation.Show();
        }
        private void licenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenseInfo licenseInfo = new FrmLicenseInfo(Convert.ToInt32(DG_DetainedReleased.CurrentRow.Cells[1].Value));
            licenseInfo.Show();
        }
        private void Filter(string value)
        {
            DetainView.RowFilter = value;
            DG_DetainedReleased.DataSource = DetainView;
        }
        private void WhichFilter()
        {
            switch(ComB_FilterBy.SelectedIndex)
            {
                case 0:
                    DG_DetainedReleased.DataSource = DetainTable.AsDataView();
                    break;
                case 1:
                    if(int.TryParse( Txtb_FilterBy.Text,out int value) )                    
                        Filter($"DetainedID='{value}'");
                    else
                        DG_DetainedReleased.DataSource = DetainTable.AsDataView();
                    break;
                case 2:
                    if (int.TryParse(Txtb_FilterBy.Text, out value))
                        Filter($"L_ID='{value}'");
                    else
                        DG_DetainedReleased.DataSource = DetainTable.AsDataView();
                    break;
               case 3:
                    if (!string.IsNullOrWhiteSpace(Txtb_FilterBy.Text))
                        Filter($"FullName like '{Txtb_FilterBy.Text}%'");
                    else
                        DG_DetainedReleased.DataSource = DetainTable.AsDataView();
                    break;
               case 4:
                    if (!string.IsNullOrWhiteSpace(Txtb_FilterBy.Text))
                        Filter($"NationalNumber like '{Txtb_FilterBy.Text}%'");
                    else
                        DG_DetainedReleased.DataSource = DetainTable.AsDataView();
                    break;
                case 5:
                    if (bool.TryParse(Comb_IsReleased.SelectedItem.ToString(),out bool Value))
                        Filter($"IsReleased ='{Value}'");
                    else
                        DG_DetainedReleased.DataSource = DetainTable.AsDataView();
                    break;
            }
        }
        private void Txtb_FilterBy_TextChanged(object sender, EventArgs e)
        {
            WhichFilter();
        }
        private void ComB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhichFilter();
            if(ComB_FilterBy.SelectedIndex==0)
            {
                Comb_IsReleased.Visible = false;
                Txtb_FilterBy.Visible = false;
            }
            else if(ComB_FilterBy.SelectedIndex==5)
            { 
                Comb_IsReleased.Visible = true;
                Txtb_FilterBy.Visible = false;
            }
            else
            {
                Comb_IsReleased.Visible = false;
                Txtb_FilterBy.Visible = true;
            }
        }
        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (!Convert.ToBoolean(DG_DetainedReleased.CurrentRow.Cells[5].Value))
            {
                releaseLicenseToolStripMenuItem.Enabled = true;
            }
            else
                releaseLicenseToolStripMenuItem.Enabled=false;
        }
        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReleaseDetainedLicense detainedLicense = new FrmReleaseDetainedLicense
                (_UserID, Convert.ToInt32(DG_DetainedReleased.CurrentRow.Cells[1].Value));
            detainedLicense.Release += SetDataDGView;
            detainedLicense.ShowDialog();
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AddDetainedLicense detainedLicense = new AddDetainedLicense(_UserID);
            detainedLicense.Detained += SetDataDGView;
            detainedLicense.ShowDialog();
        }
    }
}
