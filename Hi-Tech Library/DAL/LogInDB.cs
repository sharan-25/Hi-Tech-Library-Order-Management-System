using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Hi_Tech_Library.DAL
{
    public class LogInDB
    {
        public static bool VerifyLogin(int userId, string password, out string formName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the user exists and the password is valid
                if (GetFormForUser(connection, userId, password, out formName))
                {
                    return true; // Login successful
                }
            }

            formName = null;
            return false; // Login failed

            
        }
        
        private static bool GetFormForUser(SqlConnection connection, int userId, string password, out string formName)
        {
            // performing actual database queries to validate the user credentials
           
            if (userId == 2225 && password == "Henry@25")
            {
                formName = "MainMenuForm"; // User with user ID 2225
                return true;
            }
            else if (userId == 2223 && password == "Thomas@22")
            {
                formName = "CustomerForm"; // User with user ID 2223
                return true;
            }
            else if (userId == 2235 && password == "Peter@33")
            {
                formName = "BookForm"; // User with user ID 2235
                return true;
            }
            else if (userId == 2237 && password == "MaryBrown@99")
            {
                formName = "OrdersForm"; // User with user ID 2237
                return true;
            }
            else if (userId == 2238 && password == "Jennifer@88")
            {
                formName = "OrdersForm"; // User with user ID 2238
                return true;
            }
            else
            {
                formName = null; // No form associated with invalid user
                return false; // Invalid login credentials
            }
        }


    }
}
