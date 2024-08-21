using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsL_LicenseApplication:clsApplication
    {
        public int _L_LicenseApplicationID {  get; set; }
        public int _LicenseClassID {  get; set; }
        public byte _TestPassed {  get; set; }
        public clsL_LicenseApplication(int L_LicenseApplicationID,int LicenseClassID,byte TestPassed, int ApplicationID, string ApplicationStatus, int ApplicationTypeID,
            int PersonID, DateTime ApplicationDate, int UserID) : base(ApplicationID, ApplicationStatus, ApplicationTypeID, PersonID, ApplicationDate, UserID)
        {
            _L_LicenseApplicationID = L_LicenseApplicationID;
            _LicenseClassID = LicenseClassID;
            _TestPassed = TestPassed;
        }
        public static bool IsPersonHasSameApplicationOfL_L_Application(int PersonID, int LicenseClassID)
        {
            return clsL_LicenseApplicationData.IsPersonHasSameApplicationOfL_L_Application(PersonID, LicenseClassID);
        }
        public override void Add()
        {
            _ApplicationID = clsApplicationData.Add(_ApplicationStatus,_ApplicationTypeID,_PersonID,
                _ApplicationDate, _UserID);
            _L_LicenseApplicationID = clsL_LicenseApplicationData.Add(_LicenseClassID, _ApplicationID,_TestPassed);
        }
        public override bool Update()
        {
            if(base.Update())
            {
                if(clsL_LicenseApplicationData.Update(_L_LicenseApplicationID, _LicenseClassID,_TestPassed))
                    return true;
            }
            return false;

        }
        public static DataTable L_LicenseApplicationList()
        {
            return clsL_LicenseApplicationData.GetL_L_ApplicationList();
        }
        public static int GetApplicationID(int L_L_ApplicationID)
        {
            return clsL_LicenseApplicationData.GetApplicationID(L_L_ApplicationID);
        }
        public static new bool Delete(int L_L_ApplicationID)
        {
            int ApplicationID=clsL_LicenseApplication.GetApplicationID(L_L_ApplicationID);
            if(clsL_LicenseApplicationData.Delete(L_L_ApplicationID))
            {
                if(clsApplication.Delete(ApplicationID))
                    return true;
            }
            return false;
        }
        public static new clsL_LicenseApplication Find(int L_L_ApplicationID)
        {
            int LicenseClassID = 0, ApplicationID=0, ApplicationTypeID=0, PersonID=0, UserID=0;
            byte TestPassed = 0;
            string ApplicationStatus = "";
            DateTime ApplicationDate=new DateTime();
            clsL_LicenseApplicationData.Find(L_L_ApplicationID,ref LicenseClassID,ref ApplicationID,ref ApplicationTypeID,
                ref PersonID,ref UserID,ref ApplicationStatus,ref TestPassed,ref ApplicationDate);
            return new clsL_LicenseApplication(L_L_ApplicationID, LicenseClassID, TestPassed, ApplicationID, ApplicationStatus, ApplicationTypeID,
             PersonID, ApplicationDate, UserID);
        }
        public static int GetPersonID(int L_L_ApplicationID)
        {
            return clsL_LicenseApplicationData.GetPersonID(L_L_ApplicationID);
        }
        public static int GetLicenseClassID(int L_L_ApplicationID)
        {
            return clsL_LicenseApplicationData.GetLicenseClassID(L_L_ApplicationID);
        }
        public static bool UpdateApplicationStatus(int L_L_ApplicationID,string ApplicationStatus)
        {
            return clsL_LicenseApplicationData.UpdateApplicationStatus(GetApplicationID(L_L_ApplicationID),ApplicationStatus);
        }
        public static byte GetTestPassed(int L_L_ApplicationID)
        {
            return clsL_LicenseApplicationData.GetTestPassed(L_L_ApplicationID);
        }
    }
}
