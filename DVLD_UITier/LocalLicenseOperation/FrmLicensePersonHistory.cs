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

namespace DVLD_UITier.LocalLicenseOperation
{
    public partial class FrmLicensePersonHistory : Form
    {
        public FrmLicensePersonHistory(int PersonID)
        {
            InitializeComponent();
            ucDetailedInfo1.GetPersonID(PersonID);
            ucLicenseHistory1.SetLicenseData(clsDrivers.GetDriverID(PersonID));
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
