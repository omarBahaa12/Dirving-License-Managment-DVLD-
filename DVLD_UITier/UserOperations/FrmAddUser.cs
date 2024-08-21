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

namespace DVLD_UITier
{
    public partial class FrmAddUser : Form
    {
        public delegate void UpdateUsersList();
        public event UpdateUsersList _NewUser;

        public delegate void SavedNewUser(object sender,int ID);
        public event SavedNewUser _SavedNewUser;

        private bool IsFinished = false;
        public FrmAddUser()
        {
            InitializeComponent();
            ucFindByNationalNo1.FoundPerson_ += SetInfoInLabels;
            _SavedNewUser += ucLoginInformations1.SetUserID;
            
        }

        private void SetInfoInLabels(clsPerson person)
        {
            ucDetailedInfo1.GetPerson(person);
            IsFinished = true;
            Btn_Next.Enabled = true;
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (IsFinished)
                tabControl1.SelectedIndex=1;
            else
                MessageBox.Show("Please Add Person First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void ValidatingAllData(object sender)
        {
            if (IsFinished)
            {
                if (!clsUser.IsExistPersonIDInUser(0,ucDetailedInfo1.ID))
                {
                    if (VaildateLoginInformation())
                    {
                        clsUser NewUser = new clsUser(0, ucLoginInformations1.UserName,
                            ucLoginInformations1.Password, ucDetailedInfo1.ID, ucLoginInformations1.IsActive);
                        if (NewUser.Add())
                        {
                            _NewUser?.Invoke();
                            _SavedNewUser?.Invoke(sender, NewUser._UserID);
                        }
                    }
                    else
                        MessageBox.Show("Please Enter Login Information", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("This Person already User\n Enter Anthor Person","Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Connect User With Person", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {           
                ValidatingAllData(sender);
        }

        
    }
}
