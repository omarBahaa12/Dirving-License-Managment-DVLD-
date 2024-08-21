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
    public partial class FrmChangePassword : Form
    {
      
        clsUser User = null;
        public FrmChangePassword(int ID)
        {
            InitializeComponent();
            clsUser user=clsUser.GetUser(ID);
            ucDetailedInfo1.GetPersonID(user._PersonID);
            ucUserInfo1.GetUser(user);
            ucChangePassword1.OldPassword = user._Password;
            User = user;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ucChangePassword1.NewPassword) && ucChangePassword1.Done)
            {
                User._Password = ucChangePassword1.NewPassword;
                if (User.Update())
                {
                    MessageBox.Show("Password Saved", "DONE");
                }
            }
            else
                MessageBox.Show("Enter The New Password \n Wrong in Confirm Password","ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
