using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsTestAppointment
    {
        public int _TestAppointmentID { get; set; }
        public int _L_LicenseApplicationID { get; set; }
        public int _TestTypeID { get; set; }
        public DateTime _AppointmentDate { get; set; }
        public bool _Islocked { get; set; }

        public clsTestAppointment(int testAppointmentID, int l_LicenseApplicationID,
            int testTypeID, DateTime appointmentDate, bool islocked)
        {
            _TestAppointmentID = testAppointmentID;
            _L_LicenseApplicationID = l_LicenseApplicationID;
            _TestTypeID = testTypeID;
            _AppointmentDate = appointmentDate;
            _Islocked = islocked;
        }

        public void Add()
        {
            _TestAppointmentID = clsTestAppointmentData.Add(_L_LicenseApplicationID,
                _TestTypeID, _AppointmentDate, _Islocked);
        }
        public static bool IsHasAppointmentNotFinished(int L_L_ApplicationID, int TestTypeID)
        {
            return clsTestAppointmentData.IsHasAppointmentNotFinished(L_L_ApplicationID,TestTypeID);
        }

        public static DataTable GetTestAppointmentWithSameTestType(int testTypeID, int l_L_ApplicationID)
        {
            return clsTestAppointmentData.GetTestAppointmentWithSameTestType(testTypeID, l_L_ApplicationID);
        }

        public static DateTime GetTestAppointmentDate(int L_L_ApplicationID,int TestTypeID)
        {
            return clsTestAppointmentData.GetTestAppointmentDate(L_L_ApplicationID,TestTypeID);
        }

        public static clsTestAppointment Find(int testAppointmentID)
        {
            int L_LApplicationID = 0, TestTypeID =0;
            DateTime AppointmentDate=new DateTime();
            bool Islocked = false;
            if(clsTestAppointmentData.Find(testAppointmentID,ref L_LApplicationID,
                ref TestTypeID,ref AppointmentDate,ref Islocked))
                return new clsTestAppointment (testAppointmentID,L_LApplicationID,TestTypeID,AppointmentDate,Islocked);
            return null;
        }

        public bool Update()
        {
            return clsTestAppointmentData.Update(_TestAppointmentID,_AppointmentDate,_Islocked);
        }
    }
}
