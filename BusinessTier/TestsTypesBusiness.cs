using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsTestsTypes
    {
        public int _TestID {  get; set; }
        public string _TestName {  get; set; }
        public string _TestDescription { get; set; }
        public double _Fees {  get; set; }
        public clsTestsTypes(int TestID,string TestName, string TestDescription, double Fees)
        {
            _TestID = TestID;
            _TestName = TestName;
            _TestDescription = TestDescription;
            _Fees = Fees;
        }
        public static DataTable TestTypesList()
        {
            return clsTestTypesData.GetTestTypesList();
        }
        public bool Update()
        {
            if(clsTestTypesData.Update(_TestID,_TestName,_TestDescription,_Fees))
                return true;
            return false;
        }
        public static clsTestsTypes TestTypes(int ID)
        {
            string DescriptionName = "", TestName = "";
            double Fees = 0;
            if (clsTestTypesData.GetTestType(ID, ref TestName, ref DescriptionName, ref Fees))
                return new clsTestsTypes(ID, TestName, DescriptionName, Fees);
            return null;
            
        }
        public static string GetTestTypeName(int TestID)
        {
            return clsTestTypesData.GetTestTypeName(TestID);
        }

        public static double GetFees(int testTypeID)
        {
            return clsTestTypesData.GetFees(testTypeID);
        }
    }
}
