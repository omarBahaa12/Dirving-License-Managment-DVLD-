using BusinessTier;
using DVLD_UITier.LocalLicenseOperation;
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
    public partial class UCLicenseHistory : UserControl
    {
        public UCLicenseHistory()
        {
            InitializeComponent();

        }
        public void SetLicenseData(int DriverID)
        {
            DG_LocalLicense.DataSource = clsLicenses.LicenseList(DriverID);
            DG_InternationalLicense.DataSource = clsInternationalLicenses.InternationalLicenseList(DriverID);
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenseInfo licenseInfo = new FrmLicenseInfo(Convert.ToInt32(DG_LocalLicense.CurrentRow.Cells[0].Value));
            licenseInfo.Show();
        }
    }
}
