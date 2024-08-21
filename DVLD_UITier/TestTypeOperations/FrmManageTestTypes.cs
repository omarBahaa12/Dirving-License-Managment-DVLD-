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
    public partial class FrmManageTestTypes : Form
    {
        public FrmManageTestTypes()
        {
            InitializeComponent();
        }

        private void GetTestTypesList()
        {
            DG_TestTypes.DataSource = clsTestsTypes.TestTypesList();
        }
        private void FrmManageTestTypes_Load(object sender, EventArgs e)
        {
            GetTestTypesList();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditTestType testType = new FrmEditTestType(Convert.ToInt32(DG_TestTypes.CurrentRow.Cells[0].Value));
            testType.EditedTest += GetTestTypesList;
            testType.ShowDialog();

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
