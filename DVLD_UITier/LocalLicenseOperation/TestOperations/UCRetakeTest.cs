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
    public partial class UCRetakeTest : UserControl
    {
        public UCRetakeTest()
        {
            InitializeComponent();
        }
        public void SetRetakeData(int TestTypeID)
        {
            Lb_RTestFees.Text = "5";
            Lb_TotalFees.Text = (clsTestsTypes.GetFees(TestTypeID)+5).ToString();
        }
        public void SetRetakeL_L_ApplicationID(int RetakeApplicationID)
        {
            Lb_RL_L_applicationID.Text = RetakeApplicationID.ToString();
        }
   
    }
}
