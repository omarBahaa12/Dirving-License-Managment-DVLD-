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
    public partial class UCDetainedLicenseInfo : UserControl
    {
        public double _Fees { get; private set; } = 100;
        public UCDetainedLicenseInfo()
        {
            InitializeComponent();
        }
        private void Txtb_Fees__TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Txtb_Fees.Texts, out double Fees))
                _Fees = Fees;
            else
                Txtb_Fees.Texts = "";
        }
        public void SetDataInLables(int UserID,int LicenseID)
        {
            Lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            Lb_CreatedBy.Text = clsUser.GetUserName(UserID);
            Lb_LicenseID.Text=LicenseID.ToString();
        }
        public void SetDetainedID(int DetainedID)
        {
            Lb_DetainedID.Text = DetainedID.ToString();
        }
       
    }
}
