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
    public partial class FrmShowL_L_ApplicationDetailed : Form
    {
        public FrmShowL_L_ApplicationDetailed(int L_L_ApplicationID)
        {
            InitializeComponent();
            ucL_L_ApplicationDetail1.PersonID += ucDetailedInfo1.GetPersonID;
            ucL_L_ApplicationDetail1.SetL_L_ApplicationData(L_L_ApplicationID);

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }           
    }
}
