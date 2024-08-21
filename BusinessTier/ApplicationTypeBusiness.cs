using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsApplicationType
    {
        public int _ApplicationID {  get; set; }
        public string _Title {  get; set; }
        public double _Fees {  get; set; }

        public clsApplicationType(string Title,double Fees,int ApplicationID)
        {
            _Title = Title;
            _Fees = Fees;
            _ApplicationID = ApplicationID;
        }
        public static DataTable GetApplicationList()
        {
            return clsApplicationTypesData.ApplicationTypeList();
        }
        public bool Update()
        {
            return clsApplicationTypesData.Update(_ApplicationID, _Fees, _Title);
        }
        public static clsApplicationType GetApplicationType(int ApplicationID)
        {
            string Title = "";
            double Fees = 0;
            if(clsApplicationTypesData.GetApplicationType(ApplicationID,ref Title,ref Fees))
                return new clsApplicationType(Title,Fees,ApplicationID);
            return null;
        }
        public static double GetApplicationTypeFees(int ApplicationID)
        {
            return clsApplicationTypesData.GetApplicationTypeFees(ApplicationID);
        }

        public static string GetApplicationTypeName(int applicationTypeID)
        {
            return clsApplicationTypesData.GetApplicationTypeName(applicationTypeID);
        }
    }
}
