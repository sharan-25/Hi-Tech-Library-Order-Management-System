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
    public class EmployeeDB
    {
        public static void SaveEmployeeRecord(Employee employee)
        {
            //Open DB
            SqlConnection conn = UtilityDB.ConnectDB();

            //Perform INSERT operation
           
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO Employees (FirstName,LastName,PhoneNumber,Email,JobId,StatusId) " +
                                    "VALUES(@FirstName,@LastName,@PhoneNumber,@Email,@JobId,@StatusId)";

           // cmdInsert.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
            cmdInsert.Parameters.AddWithValue("@FirstName", employee.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", employee.LastName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@Email", employee.Email);
            cmdInsert.Parameters.AddWithValue("@JobId", employee.JobId);
            cmdInsert.Parameters.AddWithValue("@StatusId", employee.StatusId);

            cmdInsert.ExecuteNonQuery();   

            // Close DB

            conn.Close();
        }

        public static List<Employee> GetAllEmployeeRecords()
        {
            // Creating a list to store Employee data
            List<Employee> listS = new List<Employee>();

            // Establishing a database connection using the ConnectDB method from the UtilityDB class
            SqlConnection conn = UtilityDB.ConnectDB();

            // Creating a SQL command to select all records from the "Employees" table
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Employees", conn);

            // Executing the SQL command to retrieve data using a SqlDataReader
            SqlDataReader reader = cmdSelectAll.ExecuteReader(); // This is used for SELECT queries

            // Creating an Employee object to store each record from the result set
            Employee employee;

            // Looping through the result set using SqlDataReader
            while (reader.Read())
            {

                employee = new Employee();

                // Retrieving values from the reader and populating the Employee object
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.JobId = Convert.ToInt32(reader["JobId"]);
                employee.StatusId = Convert.ToInt32(reader["StatusId"]);



                listS.Add(employee);
            }

            // Closing the database connection
            conn.Close();
            return listS;

        }
        //method to search by EmployeeId
        public static Employee Search(int empId)
        {
            Employee employee = new Employee();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                        "WHERE EmployeeId = @EmployeeId";
                                          
            cmdSearchById.Parameters.AddWithValue("@EmployeeId", empId);
            
            SqlDataReader reader = cmdSearchById.ExecuteReader();
            if (reader.Read()) // found
            {

                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.FirstName = reader["FirstName"].ToString().Trim();
                employee.LastName = reader["LastName"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.JobId = Convert.ToInt32(reader["JobId"]);
                employee.StatusId = Convert.ToInt32(reader["StatusId"]);
            }
            else //not found
            {
                employee = null;
            }

            conn.Close();

            return employee;
        }
        //Method to Search by FirstName,LastName,Emal,PhoneNumber
        public static List<Employee> Search(string input)
        {
            List<Employee> listEmp = new List<Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchByName = new SqlCommand();
            cmdSearchByName.Connection = conn;
            cmdSearchByName.CommandText = "SELECT * FROM Employees " +
                                           "WHERE FirstName = @FirstName " +
                                           "     or LastName = @LastName " +
                                           "     or Email = @Email " +
                                           "     or PhoneNumber = @PhoneNumber ";
            cmdSearchByName.Parameters.AddWithValue("@FirstName", input);
            cmdSearchByName.Parameters.AddWithValue("@LastName", input);
            cmdSearchByName.Parameters.AddWithValue("@Email", input);
            cmdSearchByName.Parameters.AddWithValue("@PhoneNumber", input);
            SqlDataReader reader = cmdSearchByName.ExecuteReader(); // applied to SELECT
            Employee employee;
            while (reader.Read())
            {

                employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.JobId = Convert.ToInt32(reader["JobId"]);
                employee.StatusId = Convert.ToInt32(reader["StatusId"]);
                listEmp.Add(employee);

            }
            conn.Close();
            return listEmp;
        
        
    }
        //Search by JobId, StatusId
        public static List<Employee> SearchById(int Id)
        {
            List<Employee> listEmp = new List<Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSearchById = new SqlCommand();
            cmdSearchById.Connection = conn;
            cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                           "WHERE JobId = @JobId " +
                                           "     or StatusId = @StatusId";
                                           
            cmdSearchById.Parameters.AddWithValue("@JobId", Id);
            cmdSearchById.Parameters.AddWithValue("@StatusId", Id);
            
            SqlDataReader reader = cmdSearchById.ExecuteReader(); // applied to SELECT
            Employee employee;
            while (reader.Read())
            {

                employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.PhoneNumber = reader["PhoneNumber"].ToString();
                employee.JobId = Convert.ToInt32(reader["JobId"]);
                employee.StatusId = Convert.ToInt32(reader["StatusId"]);
                listEmp.Add(employee);

            }
            conn.Close();
            return listEmp;


        }
        //Checking duplicate primary key (Employee Id)
        public static bool IsUniqueId(int empId)
        {
            Employee employee = new Employee();
            employee = Search(empId);
            if (employee != null)
            {
                return false;
            }

            return true;
        }

        public static bool IsUniqueId_V2(int empId)
        {
            List<Employee> listEmp = GetAllEmployeeRecords();
            foreach (Employee emp in listEmp)
            {
                if (emp.EmployeeId == empId)
                {
                    return false;
                }
            }

            return true;
        }

        //Update 
        public static void UpDate(Employee employeeUpdated)

        {
            using (SqlConnection conn = UtilityDB.ConnectDB())
            {
                SqlCommand cmdUpDate = new SqlCommand();
                cmdUpDate.Connection = conn;
                cmdUpDate.CommandText = "UPDATE Employees " +
                               "SET FirstName = @FirstName, " +
                               "    LastName = @LastName, " +
                               "    PhoneNumber = @PhoneNumber, " +
                               "    Email = @Email, " +
                               "    JobId = @JobId, " +
                               "    StatusId = @StatusId " + 
                               "WHERE EmployeeId = @EmployeeId";
                cmdUpDate.Parameters.AddWithValue("@EmployeeId", employeeUpdated.EmployeeId);
                cmdUpDate.Parameters.AddWithValue("@FirstName", employeeUpdated.FirstName);
                cmdUpDate.Parameters.AddWithValue("@LastName", employeeUpdated.LastName);
                cmdUpDate.Parameters.AddWithValue("@PhoneNumber",employeeUpdated.PhoneNumber);
                cmdUpDate.Parameters.AddWithValue("@Email", employeeUpdated.Email);
                cmdUpDate.Parameters.AddWithValue("@JobId", employeeUpdated.JobId);
                cmdUpDate.Parameters.AddWithValue("@StatusId", employeeUpdated.StatusId);
                cmdUpDate.ExecuteNonQuery();
            }

        }
        //Delete
        public static void Delete(Employee employeeDeleted)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = conn;
                cmdDelete.CommandText = "DELETE Employees " +
                                        "WHERE EmployeeId=@EmployeeId";
                cmdDelete.Parameters.AddWithValue("@EmployeeId", employeeDeleted.EmployeeId);


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
