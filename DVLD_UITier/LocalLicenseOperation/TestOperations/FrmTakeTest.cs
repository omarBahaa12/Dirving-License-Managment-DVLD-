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
    public partial class FrmTakeTest : Form
    {
        public delegate void UpdateTable();
        public event UpdateTable UpdateIsLocked;

        private int _TestAppointmentID;
        public FrmTakeTest(int Trail,int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;
            InitializeComponent();
            clsTestAppointment testAppointment=GetTestAppointment(TestAppointmentID);
            SetDataInucSechduleTestL_L_Application(testAppointment, Trail);
            Lb_TestTypeName.Text = clsTestsTypes.GetTestTypeName(testAppointment._TestTypeID);
        }
        private clsTestAppointment GetTestAppointment(int TestAppointment)
        {
            return  clsTestAppointment.Find(TestAppointment);
        }
        private void SetDataInucSechduleTestL_L_Application(clsTestAppointment testAppointment,int Trail)
        {
            ucSechduleTestL_L_Application1.SetL_L_ApplicationData
                (testAppointment._L_LicenseApplicationID, testAppointment._TestTypeID, Trail);
            ucSechduleTestL_L_Application1.SetAppointmentDateToUpdate(testAppointment._AppointmentDate);
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateTestAppointmentIsLocked(bool Result)
        {
            clsTestAppointment testAppointment = clsTestAppointment.Find(_TestAppointmentID);
            if (testAppointment != null)
            {
                testAppointment._Islocked = true;

                if (testAppointment.Update()&&Result)
                {
                    clsL_LicenseApplication L_L_A = clsL_LicenseApplication.Find(testAppointment._L_LicenseApplicationID);
                    L_L_A._TestPassed++;
                    L_L_A.Update();
                }
            }
        }
        private bool IsSetResult()
        {
            if (ucTakeTest1.IsSetResult)
                return true;
            return false;
        }
        private void Save()
        {
            if (IsSetResult())
            {
                clsTests NewTest = new clsTests(0, _TestAppointmentID, ucTakeTest1.Result, ucTakeTest1.Notes);
                NewTest.Add();
                UpdateTestAppointmentIsLocked(ucTakeTest1.Result);
                this.Close();
            }
            else
                MessageBox.Show("Please Set Test Result", "???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
            UpdateIsLocked?.Invoke();
        }
    }
}
