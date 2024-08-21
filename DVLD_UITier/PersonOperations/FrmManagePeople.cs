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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_UITier
{
    public partial class FrmManagePeople : Form
    {
        private DataTable PersonsTable;
        private DataView PersonsView;
        public FrmManagePeople()
        {
            InitializeComponent();
            GetPeopleData();
            Cmbox_FilterBy.SelectedIndex = 3;
        }

        private void GetPeopleData()
        {
            PersonsTable = clsPerson.GetPeopleList();
            DG_People.DataSource = PersonsTable;
            PersonsView = PersonsTable.DefaultView;
        }

        private void ShowTxtboxCmbox()
        {
            if (Cmbox_FilterBy.SelectedIndex == 1)
            {
                Txtb_Filter.Visible = false;
                Cmbox_GenderType.Visible = true;
            }
            else if (Cmbox_FilterBy.SelectedIndex == 3)
            {
                Cmbox_GenderType.Visible = false;
                Txtb_Filter.Visible = false;
                GetPeopleData();
            }
            else
            {
                Cmbox_GenderType.Visible = false;
                Txtb_Filter.Visible = true;
            }
        }

        private void Cmbox_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTxtboxCmbox();
        }

        private void FilteringCmboxGender(string text)
        {
            PersonsView.RowFilter = $"Gender='{text}'";
            DG_People.DataSource =PersonsView;

        }
        private void Cmbox_GenderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmbox_GenderType.SelectedIndex != 2)
            {
                FilteringCmboxGender(Cmbox_GenderType.SelectedItem.ToString());
            }
            else
            {
                GetPeopleData();
            }
        }

        private void FilteringPeopleData(string Text)
        {
            switch (Cmbox_FilterBy.SelectedIndex) 
            {
                case 0:
                    PersonsView.RowFilter = $"FullName like '{Text}%'";
                    DG_People.DataSource = PersonsView;
                    break;
                case 2:
                    PersonsView.RowFilter = $"NationalNumber like '{Text}%'";
                    DG_People.DataSource = PersonsView;
                    break;
                case 4:
                    if (!string.IsNullOrEmpty(Text))
                    {
                        PersonsView.RowFilter = $"PersonID='{Convert.ToInt32(Text)}'";
                        DG_People.DataSource = PersonsView;
                    }
                    else
                        DG_People.DataSource = PersonsTable.AsDataView();
                    break;
                default:
                    break;
            }

        }
        private void Txtb_Filter_TextChanged(object sender, EventArgs e)
        {
            FilteringPeopleData(Txtb_Filter.Text);
        }
     
        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {
            FrmAddPerson frmAddPerson = new FrmAddPerson();
            frmAddPerson.UpdateList += UpdatePeopleList;
            frmAddPerson.ShowDialog();
        }

        private void UpdatePeopleList(object sender)
        {
            GetPeopleData();
        }

        private void showDetailProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetailedInformation information = new FrmShowDetailedInformation
                (Convert.ToInt32( DG_People.CurrentRow.Cells[0].Value));
            information.ShowDialog();
        }

        private void updateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdatePerson updatePerson = new FrmUpdatePerson(Convert.ToInt32(DG_People.CurrentRow.Cells[0].Value));
            updatePerson.UpdatePerson += UpdatePeopleList;
            updatePerson.ShowDialog();
        }

        private void deleteInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Delete this Person", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                if (clsPerson.Delete(Convert.ToInt32(DG_People.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Deleted Successfully", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatePeopleList(sender);
                }
                else
                    MessageBox.Show("Deleting Failed ", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
      
    }
}
