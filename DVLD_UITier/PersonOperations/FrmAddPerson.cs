using BusinessTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD_UITier
{
    public partial class FrmAddPerson : Form
    {
        public delegate void AddedPerson(object sender);
        public event AddedPerson UpdateList;

        public delegate void AddedNewPerson(object sender,clsPerson person);
        public event AddedNewPerson Added_Person;
        public FrmAddPerson()
        {
            InitializeComponent();
            Added_Person += ucAddPerson1.SetPersonID;
        }          

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckingFromAttrbite()
        {
            if (!string.IsNullOrWhiteSpace(ucAddPerson1.Country) && 
                !string.IsNullOrWhiteSpace(ucAddPerson1.First)
                && !string.IsNullOrWhiteSpace(ucAddPerson1.Second) &&
                !string.IsNullOrWhiteSpace(ucAddPerson1.Third) &&
                !string.IsNullOrWhiteSpace(ucAddPerson1.Last) && 
                !string.IsNullOrWhiteSpace(ucAddPerson1.NationalNo)
                && !string.IsNullOrWhiteSpace(ucAddPerson1.Email) &&
                !string.IsNullOrWhiteSpace(ucAddPerson1.Phone) && 
                ucAddPerson1.DateBirth != null
                && !string.IsNullOrWhiteSpace(ucAddPerson1.Address) && 
                !string.IsNullOrWhiteSpace(ucAddPerson1.Gender))
                return true;

            return false;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckingFromAttrbite())
            {
                clsPerson NewPerson = new clsPerson(ucAddPerson1.Country, ucAddPerson1.First, ucAddPerson1.Second, ucAddPerson1.Third, ucAddPerson1.Last, ucAddPerson1.NationalNo
                    , ucAddPerson1.Email, ucAddPerson1.Phone, ucAddPerson1.Image, ucAddPerson1.DateBirth, ucAddPerson1.Address, ucAddPerson1.Gender);
                if (NewPerson.Add())
                {
                    MessageBox.Show("Person ID = " + NewPerson._PersonID.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateList?.Invoke(sender);
                    Added_Person?.Invoke(sender, NewPerson);
                }
            }
            else
                MessageBox.Show("There Something Missing???", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
