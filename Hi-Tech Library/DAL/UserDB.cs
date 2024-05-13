using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL;
using HiTechLibrary.DAL;

namespace Hi_Tech_Library.DAL
{
    public class UserDB
    {
        //Save user Record
        public static void SaveUserRecord(User user)
        {
            //Open DB
            SqlConnection conn = UtilityDB.ConnectDB();

            //Perform INSERT operation
            //Create and customize an object of type SqlCommand 
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO Users (Password,DateCreated,DateModified,StatusId,EmployeeId) " +
                                    "VALUES(@Password,@DateCreated,@DateModified,@StatusId,@EmployeeId)";


           // cmdInsert.Parameters.AddWithValue("@UserId", user.UserId);
            cmdInsert.Parameters.AddWithValue("@Password", user.Password);
            cmdInsert.Parameters.AddWithValue("@DateCreated", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("@DateModified", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("@StatusId", user.StatusId);
            cmdInsert.Parameters.AddWithValue("@EmployeeId", user.EmployeeId);
            

            cmdInsert.ExecuteNonQuery();   // applied to INSERT/UPDATE/DELETE

            // Close DB

            conn.Close();
        }

        //List All Users
        public static List<User> GetAllUserRecords()
        {
            // Creating a list to store User data
            List<User> listUser = new List<User>();

            // Establishing a database connection using the ConnectDB method from the UtilityDB class
            SqlConnection conn = UtilityDB.ConnectDB();

            // Creating a SQL command to select all records from the "Users" table
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Users", conn);

            // Executing the SQL command to retrieve data using a SqlDataReader
            SqlDataReader reader = cmdSelectAll.ExecuteReader(); 

            // Creating an User object to store each record from the result set
            User user;

            // Looping through the result set using SqlDataReader
            while (reader.Read())
            {

                user = new User();
                
                //retreving values from the reader and populating the User object
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.Password = reader["Password"].ToString();
                // Convert "DateCreated" to DateTime
                if (reader["DateCreated"] != DBNull.Value)
                {
                    user.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                }
                if (reader["DateModified"] != DBNull.Value)
                {
                    user.DateModified = Convert.ToDateTime(reader["DateModified"]);
                }
                user.StatusId = Convert.ToInt32(reader["StatusId"]);
                user.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);


                listUser.Add(user);
            }

            // Closing the database connection
            conn.Close();
            return listUser;

        }
        //method to search by UserId
        public static User Search(int userId)
        {
           
            User user = new User();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Users " + 
                                        "WHERE UserId = @UserId";
            cmdSearchById.Parameters.AddWithValue("@UserId", userId);
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read()) // found
            {

                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.Password = reader["Password"].ToString();
                // Convert "DateCreated" to DateTime
                if (reader["DateCreated"] != DBNull.Value)
                {
                    user.DateCreated = Convert.ToDateTime(reader["DateCreated"]);
                }
                else
                {
                    user.DateCreated = DateTime.MinValue; // Assign a default value if the database value is null
                }

                // Convert "DateModified" to DateTime
                if (reader["DateModified"] != DBNull.Value)
                {
                    user.DateModified = Convert.ToDateTime(reader["DateModified"]);
                }
                else
                {
                    user.DateModified = DateTime.MinValue; // Assign a default value if the database value is null
                }
                user.StatusId = Convert.ToInt32(reader["StatusId"]);
                user.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);

            }
            else //not found
            {
                user = null;
            }

            conn.Close();

            return user;
        }
        //Search by EmployeeId,StatusId
        public static List<User> SearchById(int Id)
        {
            List<User> userList = new List<User>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Users " +
                                        "WHERE EmployeeId = @EmployeeId OR StatusId = @StatusId";

            cmdSearchById.Parameters.AddWithValue("@EmployeeId", Id);
            cmdSearchById.Parameters.AddWithValue("@StatusId", Id);

            SqlDataReader reader = cmdSearchById.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.Password = Convert.ToString(reader["Password"]);
                user.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                user.StatusId = Convert.ToInt32(reader["StatusId"]);
                userList.Add(user);
            }
            conn.Close();
            return userList;
        }


        //Methods to check duplicate Primary Key

        public static bool IsUniqueId(int userId)
        {
           
            User user = new User();
            user = Search(userId);
            
            if (user != null)
            {
                return false;
            }

            return true;
        }

        public static bool IsUniqueId_V2(int userId)
        {
            List<User> listUser = GetAllUserRecords();
            foreach (User user in listUser)
            {
                if (user.UserId == userId)
                {
                    return false;
                }
            }

            return true;
        }


        //Update 
        public static void UpDate(User userUpdated)

        {
            
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                
                SqlCommand cmdUpDate = new SqlCommand();
                cmdUpDate.Connection = conn;
                cmdUpDate.CommandText = "UPDATE Users " +
                                        " SET Password=@Password, " +
                                        "     DateModified = @DateModified, " +
                                        "     StatusId = @StatusId, " +
                                        "     EmployeeId = @EmployeeId " +
                                        "WHERE UserId = @UserId";
                cmdUpDate.Parameters.AddWithValue("@UserId", userUpdated.UserId);
                cmdUpDate.Parameters.AddWithValue("@Password", userUpdated.Password);
                //cmdUpDate.Parameters.AddWithValue("@DateCreated", userUpdated.DateCreated);
                cmdUpDate.Parameters.AddWithValue("@DateModified", DateTime.Now);
                cmdUpDate.Parameters.AddWithValue("@StatusId", userUpdated.StatusId);
                cmdUpDate.Parameters.AddWithValue("@EmployeeId", userUpdated.EmployeeId);
               
                cmdUpDate.ExecuteNonQuery();
            }

        }
        //Delete
        public static void Delete(User userDeleted)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = conn;
                //because User is reserved keyword thats why cause
                cmdDelete.CommandText = "DELETE Users " +
                        "WHERE UserId = @UserId";
                cmdDelete.Parameters.AddWithValue("@UserId", userDeleted.UserId);


                cmdDelete.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }


        }

    }
}
