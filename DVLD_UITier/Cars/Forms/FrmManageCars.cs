using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_UITier.Cars.Forms
{
    public partial class FrmManageCars : Form
    {
        DataTable DT = new DataTable();
        public FrmManageCars()
        {
            Task<DataTable> TCars = Task.Run(() => clsCars.GetAllCarsData());
            InitializeComponent();
            TCars.GetAwaiter().OnCompleted(() =>
            {
                DT = TCars.Result;
                LoadData();
            });

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadData()
        {
            DGV_Cars.DataSource = DT.AsDataView();
        }
        private void FrmManageCars_Load(object sender, EventArgs e)
        {
        }
    }
}
