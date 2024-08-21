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
    public partial class UCUserInfo : UserControl
    {
        public UCUserInfo()
        {
            InitializeComponent();
        }

        public void GetUser(clsUser User)
        { 
            SetUserInfo(User);                    
        }

        private void SetUserInfo(clsUser User)
        {
            Lb_ShowUserID.Text=User._UserID.ToString();
            Lb_ShowUserName.Text = User._UserName;
            if (User._IsActive)           
                Lb_ShowActive.Text = "Active";            
            else
                Lb_ShowActive.Text = "Not Active";
        }

        
    }
}
