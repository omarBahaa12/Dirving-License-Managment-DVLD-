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
    public partial class FrmLicenseInfo : Form
    {
        public FrmLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            ucLicenseInfo1.SetLicenseInfo(LicenseID);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
