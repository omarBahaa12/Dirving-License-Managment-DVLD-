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
    public partial class UCSechduleTestL_L_Application : UserControl
    {
        public DateTime _DateAppointment { get; private set; }
        public UCSechduleTestL_L_Application()
        {
            InitializeComponent();
            Datetime.MinDate = DateTime.Now;
            _DateAppointment = Datetime.MinDate;
        }

        public void SetL_L_ApplicationData(int L_L_ApplicationID,int TestTypeID,int Trial)
        {
            clsL_LicenseApplication L_Application=clsL_LicenseApplication.Find(L_L_ApplicationID);
            if(L_Application != null)
            {
                Lb_ClassName.Text = clsLicenseClass.LicenseClassName(L_Application._LicenseClassID);
                Lb_Fees.Text = clsTestsTypes.GetFees(TestTypeID).ToString();
                Lb_L_L_AppicationID.Text=L_L_ApplicationID.ToString();
                Lb_FullName.Text = clsPerson.GetFullName(L_Application._PersonID);
                Lb_Trial.Text = Trial.ToString();
            }

        }

        private void Datetime_ValueChanged(object sender, EventArgs e)
        {
            _DateAppointment = Datetime.Value;
        }

        public void SetAppointmentDateToUpdate(DateTime DateAppointment)
        {
            _DateAppointment = Datetime.Value = DateAppointment;
        }
    }
}
