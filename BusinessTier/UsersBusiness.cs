using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsUser
    {
        public int _UserID {  get; set; }
        public string _UserName { get; set; }
        public string _Password { get; set; }
        public int _PersonID {  get; set; }
        public bool _IsActive { get; set; }
        public clsUser(int userID, string userName, string password, int PersonID,bool IsActive)
            
        {
            _UserID = userID;
            _UserName = userName;
            _Password = password;
            _PersonID = PersonID;
            _IsActive = IsActive;
        }
        public static DataTable GetUserList()
        {
            return clsUsersData.GetUserList();

        }
        public bool Add()
        {
            _UserID=clsUsersData.Add(_UserName,_Password,_PersonID,_IsActive);
            if(_UserID!=0)
                return true;
            return false;
        }
        public static bool Delete(int UserID) 
        {
            if(clsUsersData.Delete(UserID)) 
                return true; 
            return false; 
        }
        public static bool IsExistPersonIDInUser(int UserID, int PersonID)
        {
            return clsUsersData.IsExistPersonID(UserID,PersonID);
        }
        public static clsUser GetUser(int UserID)
        {
            string UserName = "", Password = "";
            int PersonID = 0;
            bool IsActive = false;
            if(clsUsersData.IsExist(UserID))
            {
                clsUsersData.GetUser(UserID, ref UserName, ref Password, ref PersonID, ref IsActive);
                return new clsUser(UserID, UserName, Password, PersonID, IsActive);
            }
            return null;
        }
        public bool Update()
        {
            if(clsUsersData.Update(_UserID,_Password, _PersonID, _IsActive,_UserName))
                return true;
            return false;
        }
        public static clsUser IsUserFound(string Password,string UserName)
        {
            int PersonID=0, UserID=0;
            bool IsActive = false;
            if(clsUsersData.IsUserFound(ref UserID,ref UserName, Password,ref PersonID,ref IsActive))
            {
                return new clsUser( UserID, UserName, Password, PersonID, IsActive);
            }
            return null;
        }
        public static string GetUserName(int UserID)
        {  
            return clsUsersData.GetUserName(UserID);
        }
    }
}
