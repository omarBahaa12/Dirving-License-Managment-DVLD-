using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.UserControls
{
    public partial class UCDetailApplicationInfo : UserControl
    {
        private int PersonID;
        public UCDetailApplicationInfo()
        {
            InitializeComponent();
        }

        public void SetData(int ApplicationID)
        {
            clsApplication application = clsApplication.Find(ApplicationID);
            if (application != null)
            {
                PersonID = application._PersonID;
                Lb_ID.Text = ApplicationID.ToString();
                Lb_Status.Text = application._ApplicationStatus;
                Lb_Fees.Text=clsApplicationType.GetApplicationTypeFees(application._ApplicationTypeID).ToString();
                Lb_CreatedBy.Text = clsUser.GetUserName(application._UserID);
                Lb_ApplicationType.Text=clsApplicationType.GetApplicationTypeName(application._ApplicationTypeID);
                Lb_Date.Text=application._ApplicationDate.ToShortDateString();
                Lb_FullName.Text = clsPerson.GetFullName(application._PersonID);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowDetailedInformation frmShow=new FrmShowDetailedInformation(PersonID);
            frmShow.ShowDialog();
        }
    }
}
