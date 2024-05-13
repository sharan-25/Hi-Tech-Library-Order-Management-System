using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class User
    {
        public int UserId {  get; set; }
        public string Password { get; set; } 

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public int StatusId { get; set; }
        public int EmployeeId { get; set; }

        //Save Record
        public void SaveUser(User user)
        {
            UserDB.SaveUserRecord(user);
        }

        //IsUnique Id
        public bool IsUniqueUserId(int userId)
        {
            return UserDB.IsUniqueId(userId);
        }
        //Search User by UserId
        public User SearchUser(int id)
        {
            return UserDB.Search(id);
        }

        //Search User by EmployeeId, StatusId
        public List<User> SearchUserbyId(int id)
        {
            return UserDB.SearchById(id);
        }
        //Get All User records
        public List<User> GetAllUsers()
        {
            return UserDB.GetAllUserRecords();
        }
        //Update User 
        public void UpDateUser(User upDatedUser)
        {
            UserDB.UpDate(upDatedUser);
        }

        //Delete Employee
        public void DeleteUser(User deletedUser)
        {
            UserDB.Delete(deletedUser);
        }
    }
}
