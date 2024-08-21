using BusinessTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace DVLD_UITier
{
    public partial class FrmLogin : Form
    {
        //private StreamReader Reader = new StreamReader("Login.txt");
        public FrmLogin()
        {
            InitializeComponent();
            using (StreamReader Reader = new StreamReader("Login.txt"))
            {
                string Line= Reader.ReadLine();
                var LoginInfo = Line.Split(' ');
                if (LoginInfo[2]=="Checked")
                {
                    Txtb_UserName.Texts = LoginInfo[0];
                    Txtb_Password.Texts = LoginInfo[1];
                    Chb_Remember.Checked = true;
                }
                
            }
        }
        private bool IsActive(bool Activing)
        {
            return Activing ? true:false;
        }
        private bool IsUserNameMatching(string UserName)
        {
            return UserName==Txtb_UserName.Texts?true:false;
        }
        private bool IsRemembered()
        {
            return Chb_Remember.Checked?true:false;
        }
        private void WriteInFile(string UserName,string Password,string Status)
        {
            using (StreamWriter Writer = new StreamWriter("Login.txt"))
            {
                Writer.WriteLine(UserName + " " + Password + " " + Status);
            }
        }
        private void CheckingBeforeLogin()
        {
            clsUser User = clsUser.IsUserFound(Txtb_Password.Texts, Txtb_UserName.Texts);
            if (User != null)
            {
                if (IsActive(User._IsActive))
                {
                    if (IsUserNameMatching(User._UserName))
                    {
                        MainInterface mainInterface = new MainInterface(User._UserID);
                        mainInterface.Show();
                        if (IsRemembered())
                            WriteInFile(User._UserName, User._Password, "Checked");

                        else
                        {
                            WriteInFile(User._UserName, User._Password, "Unchecked");
                            Txtb_Password.Texts = "";
                            Txtb_UserName.Texts = "";
                        }

                    }
                    else
                        MessageBox.Show("Enter The Right UserName", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("This User not Active","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please,Enter Right UserName Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            CheckingBeforeLogin();
        }
        private void Btn_ShowPassword_MouseEnter(object sender, EventArgs e)
        {
            Txtb_Password.PasswordChar = false;
        }
        private void Btn_ShowPassword_MouseLeave(object sender, EventArgs e)
        {
            Txtb_Password.PasswordChar=true;
        }

        
    }
}
