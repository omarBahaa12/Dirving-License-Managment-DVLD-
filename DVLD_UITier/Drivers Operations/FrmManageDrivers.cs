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

namespace DVLD_UITier.Drivers_Operations
{
    public partial class FrmManageDrivers : Form
    {
        private DataTable DriversTable;
        private DataView DVDrivers;
        public FrmManageDrivers()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmManageDrivers_Load(object sender, EventArgs e)
        {
            DG_Drivers.DataSource=DriversTable=clsDrivers.GetDriverList();
            DVDrivers = DriversTable.DefaultView;
        }

        private void Cmb_Filterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_Filterby.SelectedIndex!=0)
            {
                Txtb_Filterby.Visible = true;
            }
            else
                Txtb_Filterby.Visible=false;
        }

        private void FilterDataView()
        {
            switch (Cmb_Filterby.SelectedIndex)
            {
                case 0:
                    DG_Drivers.DataSource = DriversTable.AsDataView();
                    break;
                case 1:
                    FilterByDriverID();
                    break;
                case 2:
                    FilterByPersonID();
                    break;
                case 3:
                    FilterByFullName();
                    break;
                case 4:
                    FilterByNationNo();
                    break;
                default:
                    break;

            }
        }

        private void FilterByNationNo()
        {
            if (!string.IsNullOrWhiteSpace(Txtb_Filterby.Text))
            {
                DVDrivers.RowFilter = $"NationalNumber like '{Txtb_Filterby.Text}%'";
                DG_Drivers.DataSource = DVDrivers;
            }
            else
                DG_Drivers.DataSource = DriversTable.AsDataView();
        }

        private void FilterByFullName()
        {
            if (!string.IsNullOrWhiteSpace(Txtb_Filterby.Text))
            {
                DVDrivers.RowFilter = $"FullName like '{Txtb_Filterby.Text}%'";
                DG_Drivers.DataSource = DVDrivers;
            }
            else
                DG_Drivers.DataSource = DriversTable.AsDataView();
        }

        private void FilterByPersonID()
        {
            if (int.TryParse(Txtb_Filterby.Text,out int PerosnID))
            {
                DVDrivers.RowFilter = $"PersonID='{PerosnID}'";
                DG_Drivers.DataSource = DVDrivers;
            }
            else
                DG_Drivers.DataSource = DriversTable.AsDataView();
        }

        private void FilterByDriverID()
        {
            if (int.TryParse(Txtb_Filterby.Text, out int DriverID))
            {
                DVDrivers.RowFilter = $"DriverID='{DriverID}'";
                DG_Drivers.DataSource = DVDrivers;
            }
            else
                DG_Drivers.DataSource = DriversTable.AsDataView();
        }

        private void Txtb_Filterby_TextChanged(object sender, EventArgs e)
        {
            FilterDataView();
        }
    }
}
