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
    public partial class FrmEditApplicationType : Form
    {
        public delegate void EditApplication();
        public event EditApplication UpdateApplicationTypes_;
        private int ID;
        public FrmEditApplicationType(int ApplicationID)
        {
            InitializeComponent();
            ucEditApplicationType1.SetApplicationData(ApplicationID);
            ID=ApplicationID;
        }      
        private void Save()
        {
            if (!string.IsNullOrWhiteSpace(ucEditApplicationType1.Title) && ucEditApplicationType1.Fees != 0)
            {
                clsApplicationType Application = new clsApplicationType(
                    ucEditApplicationType1.Title, ucEditApplicationType1.Fees, ID);
                if (Application.Update())
                {
                    MessageBox.Show("Update Successfully", "DONE");
                    UpdateApplicationTypes_?.Invoke();
                }
            }
            else
                MessageBox.Show("Please Enter The Title & Fees Right", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);   
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
