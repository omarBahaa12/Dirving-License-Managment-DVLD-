using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsPerson
    {
        public int _PersonID { get; set; }
        public string _Country { get; set; }
        public string _FirstName { get; set; }
        public string _SecondName {  get; set; }
        public string _ThirdName { get; set; }
        public string _LastName { get; set; }
        public string _NationalNo {  get; set; }
        public string _Email {  get; set; }
        public string _Phone { get; set; }
        public string _ImagePath { get; set; }
        public DateTime _BirthDate  {  get; set; }
        public string _Address { get; set; }

        public string _Gender {  get; set; }
        public clsPerson(string Country,string FirstName,string SecondName,string ThirdName,string LastName,
            string NationalNo,string Email,string Phone,string ImagePath,DateTime BirthDate,string Address,string Gender) 
        { 
            _Country = Country;
            _FirstName = FirstName;
            _SecondName = SecondName;
            _ThirdName = ThirdName;
            _LastName = LastName;
            _NationalNo = NationalNo;
            _Email = Email;
            _Phone = Phone;
            if (!string.IsNullOrWhiteSpace(ImagePath))
                _ImagePath = ImagePath;
            else
                _ImagePath = "";
            _BirthDate = BirthDate;
            _Address = Address;
            _Gender= Gender;
        }

        public clsPerson(int PersonID,string Country, string FirstName, string SecondName, string ThirdName, string LastName,
            string NationalNo, string Email, string Phone, string ImagePath, DateTime BirthDate, string Address, string Gender)
        {
            _PersonID = PersonID;
            _Country = Country;
            _FirstName = FirstName;
            _SecondName = SecondName;
            _ThirdName = ThirdName;
            _LastName = LastName;
            _NationalNo = NationalNo;
            _Email = Email;
            _Phone = Phone;
            if (!string.IsNullOrWhiteSpace(ImagePath))
                _ImagePath = ImagePath;
            else
                _ImagePath = "";
            _BirthDate = BirthDate;
            _Address = Address;
            _Gender = Gender;
        }
        public static void SpliteFullName(string FullName, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName)
        {
            var SpliteName = FullName.Split(' ');
            if (SpliteName.Length == 1)
                FirstName = SpliteName[0];
            else if (SpliteName.Length == 2)
            {
                FirstName = SpliteName[0]; SecondName = SpliteName[1];
            }
            else if (SpliteName.Length == 3)
            {
                FirstName = SpliteName[0]; SecondName = SpliteName[1]; ThirdName = SpliteName[2];
            }
            else
            {
                FirstName = SpliteName[0]; SecondName = SpliteName[1]; ThirdName = SpliteName[2]; LastName = SpliteName[3];
            }
        }
        public static DataTable GetPeopleList()
        {
            return clsPersonData.GetPeopleList();
                
        }
        public bool Add()
        {
            _PersonID = clsPersonData.Add(_FirstName, _SecondName, _ThirdName, _LastName, _Email, _Address, _BirthDate, _ImagePath
                , _Phone, _NationalNo, clsCountries.GetCountryID(_Country), _Gender);
            if (_PersonID != 0)
                return true;
            return false;
                       
        }
        public static bool IsExist(string NationalNo)
        {
            return clsPersonData.IsExist(NationalNo);
        }
        public static bool IsExist(int PersonID)
        {
            return clsPersonData.IsExist(PersonID);
        }
        public static clsPerson GetPerson(int ID)
        {
            string FirstName = "", SecondName = "", ThirdName = "",
                LastName = "",Phone="",Email="",NationalNo=""
                ,Gender="",Address="",Image="";
            DateTime DateBirth = new DateTime();
            int CountryID = 0;
            if(clsPersonData.GetPerson(ID,ref FirstName,ref SecondName,ref ThirdName,ref LastName,
                ref Email,ref NationalNo,ref Gender,ref CountryID,ref Phone,ref Address,ref Image,ref DateBirth))
                return new clsPerson(ID,clsCountries.GetCountryName(CountryID),FirstName,SecondName,ThirdName,LastName
                    ,NationalNo,Email,Phone,Image,DateBirth,Address,Gender);
            return null;
        }
        public static clsPerson GetPerson(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "",
                LastName = "", Phone = "", Email = ""
                , Gender = "", Address = "", Image = "";
            DateTime DateBirth = new DateTime();
            int CountryID = 0,ID=0;
            if (clsPersonData.GetPerson(ref ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Email,NationalNo, ref Gender, ref CountryID, ref Phone, ref Address, ref Image, ref DateBirth))
                return new clsPerson(ID, clsCountries.GetCountryName(CountryID), FirstName, SecondName, ThirdName, LastName
                    , NationalNo, Email, Phone, Image, DateBirth, Address, Gender);
            return null;
        }
        public bool Update()
        {
            if(clsPersonData.Update(_PersonID,clsCountries.GetCountryID(_Country),_FirstName,_SecondName,_ThirdName,_LastName,
                _Email,_Phone,_NationalNo,_Gender,_ImagePath,_BirthDate,_Address))
                return true;
            return false;
        }
        public static bool Delete(int ID)
        {
            if (clsPersonData.Delete(ID))
                return true;
            return false;
        }
        public static DateTime GetDataBirth(int PersonID)
        {
            return clsPersonData.GetDataBirth(PersonID);
        }
        public static string GetFullName(int personID)
        {
            return clsPersonData.GetFullName(personID);
        }

    }
}
