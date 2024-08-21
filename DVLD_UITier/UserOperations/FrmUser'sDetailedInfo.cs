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
    public partial class FrmUser_sDetailedInfo : Form
    {
        public delegate void UpdateUserList();
        public event UpdateUserList Update_;
        public FrmUser_sDetailedInfo(clsUser User)
        {
            InitializeComponent();
            ucUserInfo1.GetUser(User);
            ucDetailedInfo1.GetPersonID(User._PersonID);
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
