using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier
{
    public partial class FrmManageUsers : Form
    {
        private DataTable UsersTable;
        private DataView UsersDataView;
        public FrmManageUsers()
        {
            InitializeComponent();
            GetUsersData();
            Cmbox_FilterBy.SelectedIndex = 3;
            ShowTxtboxCmbox();
        }

        private void GetUsersData()
        {
            UsersTable=clsUser.GetUserList();
            DG_People.DataSource = UsersTable;
            UsersDataView = UsersTable.DefaultView;
        }

        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm._NewUser += UpdateUsersList;
            frm.ShowDialog();
        }

        private void UpdateUsersList()
        {
            DG_People.DataSource=UsersTable.AsDataView();
        }

        private void ShowTxtboxCmbox()
        {
            if (Cmbox_FilterBy.SelectedIndex == 0)
            {
                Txtb_Filter.Visible = false;
                Cmbox_Activing.Visible = true;
            } 
            else if(Cmbox_FilterBy.SelectedIndex==3)
            {
                Txtb_Filter.Visible = false;
                Cmbox_Activing.Visible = false;
            }
            else
            {
                Cmbox_Activing.Visible = false;
                Txtb_Filter.Visible = true;
            }
        }

        private void Cmbox_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTxtboxCmbox();
        }

        private void FilteringCmboxActiving(bool text)
        {
            UsersDataView.RowFilter = $"IsActive='{text}'";
            DG_People.DataSource = UsersDataView;
        }
        private void Cmbox_Activing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmbox_Activing.SelectedIndex != 2)
            {
                if(Cmbox_Activing.SelectedIndex==0)
                    FilteringCmboxActiving(true);
                else
                    FilteringCmboxActiving(false);
            }
            else
            {
                UpdateUsersList();
            }
        }

        private void FilteringPeopleData(string Text)
        {
            switch (Cmbox_FilterBy.SelectedIndex)
            {
                case 1:
                    UsersDataView.RowFilter = $"FullName like '{Text}%'";
                    DG_People.DataSource = UsersDataView;
                    break;
                case 2:
                    UsersDataView.RowFilter = $"NationalNumber like '{Text}%'";
                    DG_People.DataSource = UsersDataView;
                    break;
                case 3:
                    UpdateUsersList();
                    ShowTxtboxCmbox();
                    break;
                case 4:
                    if (!string.IsNullOrEmpty(Text)&&int.TryParse(Text,out int ID))
                    {
                        UsersDataView.RowFilter = $"UserID='{ID}'";
                        DG_People.DataSource = UsersDataView;
                    }
                    else
                        UpdateUsersList();
                    break;
                case 5:
                    UsersDataView.RowFilter = $"UserName like '{Text}%'";
                    DG_People.DataSource = UsersDataView;
                    break;
                default:
                    break;
            }

        }

        private void Txtb_Filter_TextChanged(object sender, EventArgs e)
        {
            FilteringPeopleData(Txtb_Filter.Text);
        }

        private void showDetailProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.GetUser(Convert.ToInt32( DG_People.CurrentRow.Cells[0].Value));
            FrmUser_sDetailedInfo frmUser_ = new FrmUser_sDetailedInfo(User);
            frmUser_.Update_ += UpdateUsersList;
            frmUser_.ShowDialog();
        }
        private void updateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateUser updateUser = new FrmUpdateUser(Convert.ToInt32(DG_People.CurrentRow.Cells[0].Value));
            UpdateUsersList();
            updateUser.ShowDialog();

        }

        private void deleteInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Delete this User", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                if (clsUser.Delete(Convert.ToInt32(DG_People.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateUsersList();
                }
                else
                    MessageBox.Show("Deleting Failed ", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword password = new FrmChangePassword(Convert.ToInt32(DG_People.CurrentRow.Cells[0].Value));
            password.ShowDialog();
            
        }

    }
}
