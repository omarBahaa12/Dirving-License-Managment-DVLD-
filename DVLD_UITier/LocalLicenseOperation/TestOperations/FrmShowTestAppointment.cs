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
    public partial class FrmShowTestAppointment : Form
    {
        public delegate void UpdateMainTable();
        public event UpdateMainTable TestPassed_;
        private int L_LicenseApplicationID;
        private int TestTypeID;
        public FrmShowTestAppointment(int L_L_ApplicationID,int testTypeID)
        {
            InitializeComponent();
            ucDetailApplicationInfo1.SetData(clsL_LicenseApplication.GetApplicationID(L_L_ApplicationID));
            ucL_L_ApplicationDetail1.SetL_L_ApplicationData(L_L_ApplicationID);
            Lb_TestName.Text=clsTestsTypes.GetTestTypeName(testTypeID);
            L_LicenseApplicationID = L_L_ApplicationID;
            TestTypeID = testTypeID;
            SetTestAppointmentsInDataGridView();
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetTestAppointmentsInDataGridView()
        {
            DG_TestAppointment.DataSource = clsTestAppointment.GetTestAppointmentWithSameTestType
                (TestTypeID, L_LicenseApplicationID);
        }
        private bool IsFailedTestType()
        {
            if(!clsTests.IsFailedTestType(L_LicenseApplicationID, TestTypeID))
                return true;
            return false;
        }
        private bool IsPassedTestType()
        {
            if(!clsTests.IsPassedTestType(L_LicenseApplicationID,TestTypeID))
            {
                return true;
            }
            MessageBox.Show("This Person Already Passed This Test Type \n Can't Take Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private bool IsHasAppointmentSameTesttype()
        {
            if(!clsTestAppointment.IsHasAppointmentNotFinished(L_LicenseApplicationID,TestTypeID))
                return true;
            MessageBox.Show("This Person Has Test Appointment Not Finished", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private void AddNewAppontment()
        {
            if(IsPassedTestType()&&IsHasAppointmentSameTesttype())
            {         
                FrmSechduleNewTest newTest=new FrmSechduleNewTest(L_LicenseApplicationID,
                    TestTypeID,IsFailedTestType(),DG_TestAppointment.RowCount);
                newTest.NewTest += SetTestAppointmentsInDataGridView;
                newTest.ShowDialog();               
            }
        }
        private void Btn_AddAppointment_Click(object sender, EventArgs e)
        {
            AddNewAppontment();
        }
        private void EditAppointment()
        {
            if (!Convert.ToBoolean(DG_TestAppointment.CurrentRow.Cells[4].Value))
            {
                FrmSechduleNewTest newTest = new FrmSechduleNewTest(L_LicenseApplicationID,
                    TestTypeID, IsFailedTestType(), DG_TestAppointment.RowCount-1,
                    clsTestAppointment.GetTestAppointmentDate(L_LicenseApplicationID, TestTypeID),
                    Convert.ToInt32(DG_TestAppointment.CurrentRow.Cells[0].Value));
                newTest.NewTest += SetTestAppointmentsInDataGridView;
                newTest.ShowDialog();
            }
            else
                MessageBox.Show("Can't Edit Date Because Test Appointment is Locked","Locked",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAppointment();
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(DG_TestAppointment.CurrentRow.Cells[4].Value))
            {
                FrmTakeTest takeTest = new FrmTakeTest
                    (DG_TestAppointment.RowCount - 1, Convert.ToInt32(DG_TestAppointment.CurrentRow.Cells[0].Value));
                takeTest.UpdateIsLocked += SetTestAppointmentsInDataGridView;
                takeTest.ShowDialog();
                TestPassed_?.Invoke();
                ucL_L_ApplicationDetail1.SetL_L_ApplicationData(L_LicenseApplicationID);

            }
            else
                MessageBox.Show("Can't Take Test Because Test Appointment is Locked", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
