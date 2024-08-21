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
    public partial class UCFindByNationalNo : UserControl
    {
        public delegate void FindPerson_NationalNumber(clsPerson person);
        public event FindPerson_NationalNumber FoundPerson_;

        public UCFindByNationalNo()
        {
            InitializeComponent();
        }

        
        public void SetPersonIDToUpdate(int PersonID)
        {
            Txtb_FindPerson.Texts = PersonID.ToString();
            object sender=null;
            Btn_Search_Click(sender,new EventArgs());
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Txtb_FindPerson.Texts, out int ID))
            {
                clsPerson FoundPerson = clsPerson.GetPerson(ID);
                if (FoundPerson != null)
                {
                    FoundPerson_?.Invoke(FoundPerson);
                }
                else
                    MessageBox.Show("Not Found Add Person First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clsPerson FoundPerson = clsPerson.GetPerson(Txtb_FindPerson.Texts);
                if (FoundPerson != null)
                {
                    FoundPerson_?.Invoke(FoundPerson);
                }
                else
                    MessageBox.Show("Not Found Add Person First", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {
            FrmAddPerson addPerson = new FrmAddPerson();
            addPerson.Added_Person += GetPersonIDAdded;
            addPerson.ShowDialog();
        }

        private void GetPersonIDAdded(object sender,clsPerson person)
        {
            FoundPerson_?.Invoke(person);
        }
    }
}
