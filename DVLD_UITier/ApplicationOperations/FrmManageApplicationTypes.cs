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

namespace DVLD_UITier.ApplicationOperations
{
    public partial class FrmManageApplicationTypes : Form
    {
        public FrmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void GetApplicationTypesList()
        {
            DG_ApplicationTypes.DataSource = clsApplicationType.GetApplicationList();

        }
        private void FrmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            GetApplicationTypesList();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditApplicationType frm = new 
                FrmEditApplicationType(Convert.ToInt32(DG_ApplicationTypes.CurrentRow.Cells[0].Value));
            frm.UpdateApplicationTypes_+= GetApplicationTypesList;
            frm.ShowDialog();
        }
    }
}
