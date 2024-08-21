using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsInternationalLicenses
    {
        public int _InternationalLicenseID {  get; set; }
        public int _LocalLicenseID { get;  set; }
        public int _ApplicationID { get; set; }
        public string _LicenseClass { get; set; }
        public int _DirverID {  get; set; }
        public DateTime _IssueDate { get; set; }
        public DateTime _ExpireDate { get; set; }
        public bool _IsActive {  get; set; }

        public clsInternationalLicenses(int InternationalLicenseID, int LocalLicenseID,string LicenseClass,
            int ApplicationID, int DriverID, DateTime IssueDate, DateTime ExpireDate,bool IsActive)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _LocalLicenseID = LocalLicenseID;
            _ApplicationID = ApplicationID;
            _DirverID = DriverID;
            _IssueDate = IssueDate;
            _ExpireDate = ExpireDate;
            _IsActive = IsActive;
            _LicenseClass = LicenseClass;
        }

        public void Add()
        {
            _InternationalLicenseID=clsInternationalLicensesData.Add(_LocalLicenseID,_LicenseClass,_ApplicationID,_DirverID,
                _IssueDate,_ExpireDate,_IsActive);

        }

        public static bool IsHasInternationalLicense(int L_LicenseID)
        {
            return clsInternationalLicensesData.IsHasInternationalLicense(L_LicenseID);
        }
        public static DataTable InternationalLicenseList(int driverID)
        {
            return clsInternationalLicensesData.InternationalLicenseList(driverID);
        }
        public static DataTable InternationalLicenseList()
        {
            return clsInternationalLicensesData.InternationalLicenseList();
        }

    }
}
