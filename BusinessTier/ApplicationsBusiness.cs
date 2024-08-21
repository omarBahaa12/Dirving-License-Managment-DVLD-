using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsApplication
    {
        public int _ApplicationID {  get; set; }
        public string _ApplicationStatus {  get; set; }
        public int _ApplicationTypeID {  get; set; }
        public int _PersonID {  get; set; }
        public DateTime _ApplicationDate { get; set; }
        public int _UserID {  get; set; }

        public clsApplication(int ApplicationID,string ApplicationStatus,int ApplicationTypeID,
            int PersonID,DateTime ApplicationDate,int UserID)
        {
            _ApplicationID = ApplicationID;
            _ApplicationStatus = ApplicationStatus;
            _ApplicationTypeID = ApplicationTypeID;
            _PersonID = PersonID;
            _ApplicationDate = ApplicationDate;
            _UserID = UserID;
        }
        public virtual void Add()
        {
            _ApplicationID = clsApplicationData.Add(_ApplicationStatus,
                _ApplicationTypeID,_PersonID,_ApplicationDate,_UserID);
        }
        public virtual bool Update()
        {
            return clsApplicationData.Update(_ApplicationID,_PersonID);
        }
        public static bool Delete(int ApplicationID)
        {
            return clsApplicationData.Delete(ApplicationID);
        }
        public static clsApplication Find(int applicationID)
        {
            int PersonID = 0, UserID = 0, ApplicationType = 0;
            string ApplicationStatus = "";
            DateTime ApplicationDate=new DateTime();
            if(clsApplicationData.Find(applicationID,ref PersonID,ref UserID,ref ApplicationType
                ,ref ApplicationStatus,ref ApplicationDate))
                return new clsApplication(applicationID,ApplicationStatus,ApplicationType,PersonID,ApplicationDate,UserID);
            return null;
        }
    }
}
