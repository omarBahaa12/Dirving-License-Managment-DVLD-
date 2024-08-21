using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsDrivers
    {
        public int _DriverID {  get; set; }
        public int _PersonID {  get; set; }
        public clsDrivers(int driverID, int personID)
        {
            _DriverID = driverID;
            _PersonID = personID;
        }
        public void Add()
        {
            _DriverID = clsDriversData.Add(_PersonID);
        }
        public static bool IsExist(int PersonID)
        {
            return clsDriversData.IsExist(PersonID);
        }
        public static int GetPersonID(int driverID)
        {
            return clsDriversData.GetPersonID(driverID);
        }
        public static int GetDriverID(int PersonID)
        {
            return clsDriversData.GetDriverID(PersonID);
        }
        public static DataTable GetDriverList()
        {
            return clsDriversData.DriverList();
        }

    }
}
