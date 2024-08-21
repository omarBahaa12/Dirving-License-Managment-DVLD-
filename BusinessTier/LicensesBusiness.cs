using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsLicenses
    {
        public int _LicenseID { get; set; }
        public int _ApplicationID { get; set; }
        public string _LicenseName { get; set; }
        public int _DriverID { get; set; }
        public DateTime _IssueDate { get; set; }
        public DateTime _ExpireDate { get; set; }
        public string _IssueReason { get; set; }
        public string _Notes { get; set; }
        public bool _IsActive { get; set; }
        public clsLicenses(int licenseID, int ApplicationID, int driverID, DateTime issueDate,
            DateTime expireDate, string issueReason, string notes, bool isActive, string LicenseName)
        {
            _LicenseID = licenseID;
            _ApplicationID = ApplicationID;
            _DriverID = driverID;
            _IssueDate = issueDate;
            _ExpireDate = expireDate;
            _IssueReason = issueReason;
            _Notes = notes;
            _IsActive = isActive;
            _LicenseName = LicenseName;
        }
        public void Add()
        {
            if (_Notes == null)
                _Notes = Convert.DBNull.ToString();
            _LicenseID = clsLicensesData.Add(_ApplicationID, _DriverID, _IssueDate,
                _ExpireDate, _Notes, _IssueReason, _IsActive, _LicenseName);
        }
        public static clsLicenses Find(int licenseID)
        {
            int ApplicationID = 0, driverID = 0;
            DateTime issueDate = new DateTime(), expireDate = new DateTime();
            string issueReason = "", notes = "", LicenseName = "";
            bool isActive = true;
            clsLicensesData.Find(licenseID, ref ApplicationID, ref driverID, ref issueDate,
               ref expireDate, ref issueReason, ref LicenseName, ref notes, ref isActive);
            return new clsLicenses(licenseID, ApplicationID, driverID,
                issueDate, expireDate, issueReason, notes, isActive, LicenseName);
        }
        public static bool IsLicenseExpired(int licenseID)
        {
            if(clsLicensesData.GetExpireDate(licenseID).Ticks>DateTime.Now.Ticks)
                return true;
            return false;
        }
        public static bool IsActive(int licenseID)
        {
            return clsLicensesData.IsActive(licenseID);
        }
        public static bool IsExist(int licenseID)
        {
            return clsLicensesData.IsExist(licenseID);
        }
        public static int GetLicenseID(int ApplicationID)
        {
            return clsLicensesData.GetLicenseID(ApplicationID);
        }
        public static DataTable LicenseList(int DriverID)
        {
            return clsLicensesData.LicenseList(DriverID);
        }
        public static int GetDriverID(int LicenseID)
        {
            return clsLicensesData.GetDriverID(LicenseID);
        }
        public static string LicenseClassName(int l_LicenseID)
        {
            return clsLicensesData.LicenseClassName(l_LicenseID);
        }
        public static void DeActived(int licenseID)
        {
            clsLicensesData.DeActivtedLicense(licenseID);
        }
    }
}
