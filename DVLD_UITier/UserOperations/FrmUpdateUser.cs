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
using static DVLD_UITier.FrmAddUser;

namespace DVLD_UITier
{
    public partial class FrmUpdateUser : Form
    {
        private int iD;
        private int PersonID;
        
        public FrmUpdateUser(int UserID)
        {
            InitializeComponent();
            iD = UserID;
            LoadingData();
        }
        private void LoadingData()
        {
            clsUser User = clsUser.GetUser(iD);
            ucLoginInformations1.SetDataForUpdate(User);
            ucFindByNationalNo1.FoundPerson_ += ucDetailedInfo1.GetPerson;
            ucFindByNationalNo1.SetPersonIDToUpdate(PersonID = User._PersonID);
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool VaildateLoginInformation()
        {
            if (!string.IsNullOrWhiteSpace(ucLoginInformations1.UserName) && !
                string.IsNullOrWhiteSpace(ucLoginInformations1.Password))
                return true;
            return false;
        }
        private void ValidatingAllData()
        {
            if (!clsUser.IsExistPersonIDInUser(iD,ucDetailedInfo1.ID))
            {
                if (VaildateLoginInformation())
                {
                    clsUser NewUser = new clsUser(iD, ucLoginInformations1.UserName,
                        ucLoginInformations1.Password, ucDetailedInfo1.ID, ucLoginInformations1.IsActive);
                    if (NewUser.Update())
                    {
                        MessageBox.Show("Updated Successfully", "DONE",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Please Enter Login Information", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Connect User With Person", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            ValidatingAllData();
        }

    }
}
