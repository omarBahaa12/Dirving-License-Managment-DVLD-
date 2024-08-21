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

namespace DVLD_UITier.LicenseOperation
{
    public partial class FrmAddLocalLicense : Form
    {
        public delegate void SetL_L_Application(int ID);
        public event SetL_L_Application NewL_L_Applicaton_;

        public delegate void UpdateList();
        public event UpdateList UpdateAndAdd;

        private int UserId;
        private DateTime BirthDate;
        private bool SelectedPerson=false;
        private int PersonID;
        public FrmAddLocalLicense(int UserID)
        {
            InitializeComponent();       
            UserId = UserID;
            NewL_L_Applicaton_ += ucAddLocalLicense1.SetL_L_ApplicationID;
            
        }
        private void SendPersonInfoToUCDetail(clsPerson person)
        {
            ucDetailedInfo1.GetPerson(person);
            BirthDate = person._BirthDate;
            SelectedPerson = true;
            PersonID= person._PersonID;
        }
        private bool CheckingPerson()
        {
            if(SelectedPerson)
            {
                if(clsL_LicenseApplication.IsPersonHasSameApplicationOfL_L_Application
                    (PersonID,ucAddLocalLicense1.LicenseClassID))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsUserSelectLicenseClass()
        {
            if (ucAddLocalLicense1.LicenseClassID != 0)
                return true; 
            return false;
        }
        private bool IsAgeAllowed()
        {
            short Minimumage = clsLicenseClass.MinimumAge(ucAddLocalLicense1.LicenseClassID);
            TimeSpan MinAge = new TimeSpan(Minimumage*365, 0, 0, 0);
            if(BirthDate.Ticks<MinAge.Ticks)
            {
                return false;
            }
            return true;
        }
        private void FrmAddLocalLicense_Load(object sender, EventArgs e)
        {
            ucFindByNationalNo1.FoundPerson_ += SendPersonInfoToUCDetail;
            ucAddLocalLicense1.GetUserID(UserId);
        }
        private int MakeL_LicenseApplication()
        {
            clsL_LicenseApplication NewL_L_Application = new clsL_LicenseApplication(0,
                            ucAddLocalLicense1.LicenseClassID,0,0, "New",
                            1, PersonID, DateTime.Now, UserId);
            NewL_L_Application.Add();
            return NewL_L_Application._L_LicenseApplicationID;
        }
        private void Save()
        {
            if (IsUserSelectLicenseClass())
            {
                if (CheckingPerson())
                {
                    if (IsAgeAllowed())
                    {                                         
                        NewL_L_Applicaton_?.Invoke(MakeL_LicenseApplication());
                        UpdateAndAdd?.Invoke();
                        MessageBox.Show("Added Successfully", "DONE");
                    }
                    else
                        MessageBox.Show("Applicant's Age doesn't has The Minimum age", "Failed"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please Enter The Person or\n Person Has Same type of Application didn't complete", "Failed"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Enter The License Class ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Save();
        }
       
    }
}
