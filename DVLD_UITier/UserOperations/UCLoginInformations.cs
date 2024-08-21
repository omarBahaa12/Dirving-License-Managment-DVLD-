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
    public partial class UCLoginInformations : UserControl
    {
        public string UserName {  get; set; }
        public string Password { get; set; }

        public bool IsActive {  get; set; }
        public UCLoginInformations()
        {
            InitializeComponent();
        }

        public void SetDataForUpdate(clsUser user)
        {
            Txtb_UserName.Texts = user._UserName;
            Txtb_Password.Texts = user._Password;
            Lb_ShowUserID.Text = user._UserID.ToString();
            Tbtn_Activing.Checked = user._IsActive;
        }
        private void Txtb_UserName__TextChanged(object sender, EventArgs e)
        {
            UserName=Txtb_UserName.Texts;
        }

        private void Txtb_Password__TextChanged(object sender, EventArgs e)
        {
            Password=Txtb_Password.Texts;
        }

        private void Tbtn_Activing_CheckedChanged(object sender, EventArgs e)
        {
            IsActive=Tbtn_Activing.Checked;
        }

        internal void SetUserID(object sender, int ID)
        {
            Lb_ShowUserID.Text=ID.ToString();
        }

        private void Btn_ShowPassword_MouseEnter(object sender, EventArgs e)
        {
            Btn_ShowPassword.Checked=true;
            Txtb_Password.PasswordChar = false;
        }

        private void Btn_ShowPassword_MouseLeave(object sender, EventArgs e)
        {
            Btn_ShowPassword.Checked = false;
            Txtb_Password.PasswordChar = true;
        }
    }
}
