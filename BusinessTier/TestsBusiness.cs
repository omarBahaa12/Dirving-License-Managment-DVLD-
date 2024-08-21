using DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsTests
    {
        public int _TestID {  get; set; }
        public int _TestAppointmentID {  get; set; }
        public bool _Result {  get; set; }
        public string _Notes {  get; set; }

        public clsTests(int TestID,int TestAppointment, bool Result,string Notes)
        {
            _TestID = TestID;
            _TestAppointmentID = TestAppointment;
            _Result = Result;
            _Notes = Notes;
        }
        public static bool IsPassedTestType(int L_L_applicationID,int TestTypeID)
        {
            return clsTestData.IsPassedTestType(L_L_applicationID, TestTypeID);
        }
        public static bool IsFailedTestType(int L_L_applicationID, int TestTypeID)
        {
            return clsTestData.IsFailedTestType(L_L_applicationID, TestTypeID);
        }

        public void Add()
        {
            _TestID=clsTestData.Add(_TestAppointmentID,_Result, _Notes);

        }
    }
}
