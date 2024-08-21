using BusinessTier;
using DVLD_UITier.LocalLicenseOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.International_License
{
    public partial class FrmManageInternationalLicenses : Form
    {
        private DataTable InternationalTable;
        private DataView InternationalView;
        public FrmManageInternationalLicenses()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            DG_InternationalLicenses.DataSource = InternationalTable=clsInternationalLicenses.InternationalLicenseList();
            InternationalView = InternationalTable.DefaultView;
            Cmb_FilterBy.SelectedIndex = 0;
        }

        private void FilterByNum(string Filter)
        {
            InternationalView.RowFilter =Filter;
            DG_InternationalLicenses.DataSource = InternationalView;
        }

        private void ShowTextbox(int Selected)
        {
            if (Selected != 0)
                Txtb_Filterby.Visible = true;

        }
        private void WhichSelectIndex()
        {
            if (int.TryParse(Txtb_Filterby.Texts, out int value))
            {
                switch (Cmb_FilterBy.SelectedIndex)
                {
                    case 1:
                        FilterByNum($"I_L_ID='{value}'");
                        break;
                    case 2:
                        FilterByNum($"DriverID='{value}'");
                        break;
                    case 3:
                        FilterByNum($"LocalLicenseID={value}");
                        break;

                }
            }
            else
                DG_InternationalLicenses.DataSource = InternationalTable.AsDataView();
        }
        private void Cmb_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTextbox(Cmb_FilterBy.SelectedIndex);
        }

        private void Txtb_Filterby__TextChanged(object sender, EventArgs e)
        {
            WhichSelectIndex();
        }

        private void showPersonDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetailedInformation detailedInformation = new FrmShowDetailedInformation(
                clsDrivers.GetPersonID(Convert.ToInt32(DG_InternationalLicenses.CurrentRow.Cells[1].Value)));
            detailedInformation.Show();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicensePersonHistory personHistory = new FrmLicensePersonHistory(
                clsDrivers.GetPersonID(Convert.ToInt32(DG_InternationalLicenses.CurrentRow.Cells[1].Value)));
            personHistory.ShowDialog();
        }
    }
}
