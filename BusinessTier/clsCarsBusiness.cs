using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
namespace BusinessTier
{
    public class clsCars
    {
        public enum enMode :byte{ Add, Update}
        private enMode Mode = enMode.Update;
        public short IssueDate { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string BodyStyle { get; set; }
        public int ID { get; private set; }

        public clsCars(int id,short issuedate,string maker,string model,string bodystyle,enMode mode)
        {
            Mode = mode;
            IssueDate = issuedate;
            Maker = maker;
            Model = model;
            BodyStyle = bodystyle;
            ID = id;
        }
        private int Add()
        {
            return clsCarsData.Add(IssueDate, Maker, Model, BodyStyle);
        }
        private bool Update()
        {
            return clsCarsData.Update(ID,IssueDate, Maker, Model, BodyStyle);
        }
        public bool Save()
        {
            switch(Mode)
            {

                case enMode.Add:
                    ID=Add();
                    Mode = enMode.Update;
                    if(ID!=0)
                        return true;
                    return false;


                case enMode.Update:
                    return Update();

            }
            return false;
        }
        static public DataTable GetAllCarsData()
        {
            return clsCarsData.AllCarsData();
        }
        static public clsCars Find(int ID)
        {
            string Maker = "", Model = "", BodyStyle = "";
            short IssueDate = 0;

            if (clsCarsData.Find(ID, ref Maker, ref Model, ref BodyStyle, ref IssueDate))
                return new clsCars(ID,IssueDate, Maker, Model, BodyStyle, enMode.Update);
            return null;
        }

    }
}
