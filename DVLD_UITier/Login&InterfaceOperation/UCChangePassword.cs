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
    public partial class UCChangePassword : UserControl
    {
        public string OldPassword { set; get; }
        public string NewPassword { set; get; }

        public bool Done { set; get; } = false;
        
        public UCChangePassword()
        {
            InitializeComponent();
        }

        private void Btn_ShwoOldPassword_MouseEnter(object sender, EventArgs e)
        {
            Txtb_OldPassword.UseSystemPasswordChar = false;
        }

        private void Btn_ShwoOldPassword_MouseLeave(object sender, EventArgs e)
        {
            Txtb_OldPassword.UseSystemPasswordChar = true;
        }

        private void Btn_ShowNewPassword_MouseEnter(object sender, EventArgs e)
        {
            Txtb_NewPassword.UseSystemPasswordChar = false;
        }

        private void Btn_ShowNewPassword_MouseLeave(object sender, EventArgs e)
        {
            Txtb_NewPassword.UseSystemPasswordChar = true;
        }     

        private void Txtb_OldPassword_Validating(object sender, CancelEventArgs e)
        {
            if(OldPassword!=Txtb_OldPassword.Text)
            {
                e.Cancel = true;
                Txtb_OldPassword.Focus();
                errorProvider1.SetError(Txtb_OldPassword, "Enter The Right Password");
            }
        }

        

        private void Txtb_NewPassword_TextChanged(object sender, EventArgs e)
        {
            NewPassword=Txtb_NewPassword.Text;
        }

        private void UCChangePassword_Load(object sender, EventArgs e)
        {
            Txtb_OldPassword.Text = OldPassword;

        }

        private void Txtb_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(Txtb_ConfirmPassword.Text!=Txtb_NewPassword.Text)
            {
                e.Cancel=true;
                Txtb_ConfirmPassword.Focus();
                errorProvider1.SetError(Txtb_ConfirmPassword, "Enter The Right Confirm");
            }
            Done = true;
        }
    }
}
