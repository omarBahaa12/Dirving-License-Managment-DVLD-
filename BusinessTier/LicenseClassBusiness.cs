using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsLicenseClass
    {
        public int _LicenseClassID { get; set; }
        public string _ClassName {  get; set; }
        public string _ClassDescription {  get; set; }
        public short _MinimumAllowedAge {  get; set; }
        public short _DefalultValidityLength { get; set; }
        public double _Fees {  get; set; }

        clsLicenseClass(int licenseClassID, string className, string classDescription,
            short minimumAllowedAge, short defalultValidityLength, double fees)
        {
            _LicenseClassID = licenseClassID;
            _ClassName = className;
            _ClassDescription = classDescription;
            _MinimumAllowedAge = minimumAllowedAge;
            _DefalultValidityLength = defalultValidityLength;
            _Fees = fees;
        }

        public static DataTable LicenseClassListName()
        {
            return clsLicenseClassData.LicenseClassListName();
        }
        public static int LicenseClassID(string LicenseClassName)
        {
            int LicenseClassID = clsLicenseClassData.LicenseClassID(LicenseClassName);
            return LicenseClassID;
        }
        public static string LicenseClassName(int LicenseClassID) 
        {
            string LicenseClassName = clsLicenseClassData.LicenseClassName(LicenseClassID);
            return LicenseClassName;
        }
        public static short MinimumAge(int LicenseClassID)
        {
            return clsLicenseClassData.GetMinimumAge(LicenseClassID);
        }
        public static short ValidityLength(int LicenseClassID)
        {
            return clsLicenseClassData.ValidityLength(LicenseClassID);
        }
        public static double GetFeesLicenseClass(int licenseClassID)
        {
            return clsLicenseClassData.GetFeesLicenseClass(licenseClassID);
        }
    }
}
