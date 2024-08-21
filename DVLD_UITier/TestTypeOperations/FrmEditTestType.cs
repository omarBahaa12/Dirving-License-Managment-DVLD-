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

namespace DVLD_UITier.TestOperations
{
    public partial class FrmEditTestType : Form
    {
        public delegate void EditTestType();
        public event EditTestType EditedTest;
        private int TestID;
        public FrmEditTestType(int ID)
        {
            InitializeComponent();
            ucEditTestType1.SetTestType(ID);
            TestID = ID;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsDataCorrect()
        {
            return !string.IsNullOrWhiteSpace(ucEditTestType1.TestName) ?
                (!string.IsNullOrWhiteSpace(ucEditTestType1.TestDescription)) ?
                (ucEditTestType1.Fees != 0) ? true : false : false : false;
        }
        private void Save()
        {
            if (IsDataCorrect())
            {
                clsTestsTypes Test = new clsTestsTypes(TestID, ucEditTestType1.TestName,
                    ucEditTestType1.TestDescription, ucEditTestType1.Fees);
                if (Test.Update())
                {
                    MessageBox.Show("Updated Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EditedTest?.Invoke();
                }
            }
            else
                MessageBox.Show("Enter Right Data", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
