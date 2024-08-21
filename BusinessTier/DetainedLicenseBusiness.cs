using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsDetainedLicense
    {
        public int _DetainedLicenseID {  get; private set; }
        public int _LicenseID { get; private set; }
        public DateTime _DetainedDate { get; private set; }
        public int _CreatedBy {  get; private set; }
        public double _Fees {  get; private set; }
        public DateTime _ReleasedDate { get; private set; }
        public int _ReleasedApplicationID {  get; private set; }
        public bool _IsReleased {  get; private set; }


        public clsDetainedLicense(int detainedLicenseID, int licenseID, DateTime detainedDate,
            int createdBy, double fees)
        {
            _DetainedLicenseID = detainedLicenseID;
            _LicenseID = licenseID;
            _DetainedDate = detainedDate;
            _CreatedBy = createdBy;
            _Fees = fees;
        }
        public void Add()
        {
            _DetainedLicenseID=clsDetainedLicensesData.Add(_LicenseID,_DetainedDate,_CreatedBy,_Fees);
        }
        public static bool Update(int DetainedID,DateTime ReleasedDate,int ReleasedApplicationID)
        {
            return clsDetainedLicensesData.Update(DetainedID, ReleasedDate, ReleasedApplicationID);
        }
        public static int GetDetainedID(int licenseID)
        {
            return clsDetainedLicensesData.GetDetainedID(licenseID);
        }
        public static double GetFineFees(int licenseID)
        {
            return clsDetainedLicensesData.GetFineFees(licenseID);
        }
        public static int GetLicenseID(int DetainedLicenseID) 
        {
            return clsDetainedLicensesData.GetLicenseID(DetainedLicenseID);
        }      
        public static bool IsExist(int DetainedLicenseID)
        {
            return clsDetainedLicensesData.IsExist(DetainedLicenseID);
        }
        public static DataTable ReleasedAndDetainedLlicenseList()
        {
            return clsDetainedLicensesData.ReleasedAndDetainedLlicenseList();
        }
    }
}
