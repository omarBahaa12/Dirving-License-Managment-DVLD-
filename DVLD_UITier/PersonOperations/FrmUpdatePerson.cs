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
    public partial class FrmUpdatePerson : Form
    {
        public delegate void AddedPerson(object sender);
        public event AddedPerson UpdatePerson;

        int iD=0;
        public FrmUpdatePerson(int ID)
        {
            InitializeComponent();
            ucAddPerson1.GetPersonID(ID);
            iD=ID;
        } 
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckingFromAttrbite()
        {
            if (ucAddPerson1.Country != "" && ucAddPerson1.First != "" && ucAddPerson1.Second != "" &&
                ucAddPerson1.Third != "" && ucAddPerson1.Last != "" && ucAddPerson1.NationalNo != ""
                && ucAddPerson1.Email != "" && ucAddPerson1.Phone != "" && ucAddPerson1.DateBirth != null
                && ucAddPerson1.Address != "" && ucAddPerson1.Gender != "")
                return true;
            return false;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckingFromAttrbite())
            {
                clsPerson NewPerson = new clsPerson(iD, ucAddPerson1.Country, ucAddPerson1.First,
                    ucAddPerson1.Second,ucAddPerson1.Third,ucAddPerson1.Last,ucAddPerson1.NationalNo,ucAddPerson1.Email,
                    ucAddPerson1.Phone,ucAddPerson1.Image,ucAddPerson1.DateBirth,ucAddPerson1.Address,ucAddPerson1.Gender);
                if (NewPerson.Update())
                {
                    MessageBox.Show("Updated Successfully" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdatePerson?.Invoke(sender);
                }
                else
                    MessageBox.Show("Updating Failed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("There Something Missing???", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
    }
}
