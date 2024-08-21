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

namespace DVLD_UITier.LocalLicenseOperation.TestOperations
{
    public partial class FrmSechduleNewTest : Form
    {
        public delegate void AddNewSechduleTest();
        public event AddNewSechduleTest NewTest;
        public delegate void ReturnRetakeApplicationID(int RetakeL_L_ApplicationID);
        public event ReturnRetakeApplicationID ApplicationID;
        private int _L_LApplicationID;
        private int _TestTypeID;
        private bool _IsItRetake;
        private int _TestAppointmentID;
        public FrmSechduleNewTest(int L_L_ApplicationID,int TestTypeID,bool IsItRetake,
            int Trail,DateTime AppointmentDate= new DateTime(), int TestAppointmentID = 0)
        {
            InitializeComponent();
            ucRetakeTest1.SetRetakeData(TestTypeID);
            ForEditDate(AppointmentDate);
            IsFirstTimeOrRetake(IsItRetake,L_L_ApplicationID,TestTypeID,Trail);
            _L_LApplicationID = L_L_ApplicationID;
            _TestTypeID = TestTypeID;
            _IsItRetake = IsItRetake;
            _TestAppointmentID = TestAppointmentID;
            ApplicationID+=ucRetakeTest1.SetRetakeL_L_ApplicationID;
        }
        private void ForEditDate(DateTime AppointmentDate)
        {
            if(AppointmentDate!=new DateTime())
                ucSechduleTestL_L_Application1.SetAppointmentDateToUpdate(AppointmentDate);            
        }
        private void IsFirstTimeOrRetake(bool IsItRetake,int L_L_ApplicationID,int TestTypeID,int Trail)
        {
            if (IsItRetake)
            {
                ucRetakeTest1.Enabled = false;
                ucSechduleTestL_L_Application1.SetL_L_ApplicationData(L_L_ApplicationID, TestTypeID,Trail);
                Lb_TestName.Text = clsTestsTypes.GetTestTypeName(TestTypeID);
            }
            else
            {
                ucRetakeTest1.Enabled = true;
                ucSechduleTestL_L_Application1.SetL_L_ApplicationData(L_L_ApplicationID, TestTypeID, Trail);
                Lb_TestName.Text = "Retake Test";
            }
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsExist()
        {
            if (clsTestAppointment.IsHasAppointmentNotFinished(_L_LApplicationID, _TestTypeID))
                return false;
            return true;
        }
        private void AddTestAppointment()
        {
            if (IsExist())
            {
                clsTestAppointment NewtestAppointment = new clsTestAppointment(0, _L_LApplicationID,
                        _TestTypeID, ucSechduleTestL_L_Application1._DateAppointment, false);
                NewtestAppointment.Add();
                if (_IsItRetake == false)
                {
                    ApplicationID?.Invoke(NewtestAppointment._TestAppointmentID);
                }
                else
                    this.Close();
                MessageBox.Show("Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("This Person Already Has TestAppointment in "+ 
                    clsTestAppointment.GetTestAppointmentDate(_L_LApplicationID, _TestTypeID).ToShortDateString(),"Error");


        }
        private DateTime SetNewDateToUpdate()
        {
            return ucSechduleTestL_L_Application1._DateAppointment;
        }
        private void UpdateTestAppointment()
        {
            clsTestAppointment UpdateAppointment = clsTestAppointment.Find(_TestAppointmentID);
            UpdateAppointment._AppointmentDate=SetNewDateToUpdate();
            if (UpdateAppointment.Update())
                MessageBox.Show("Updated Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to Update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(_TestAppointmentID==0)
                AddTestAppointment();
            else
                UpdateTestAppointment();
            NewTest?.Invoke();
        }
       
    }
}
