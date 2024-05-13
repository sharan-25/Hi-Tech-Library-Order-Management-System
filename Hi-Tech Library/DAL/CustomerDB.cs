using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechLibrary.DAL;
using Hi_Tech_Library.BLL;

namespace Hi_Tech_Library.DAL
{
    public class CustomerDB
    {
        //Getting all the customer records from the database
        public static List<Customer> GetAllCustomerRecords()
        {
            List<Customer> list = new List<Customer>();

            SqlConnection conn = UtilityDB.ConnectDB();

            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Customers;", conn);

            SqlDataReader dataReader = cmdSelectAll.ExecuteReader();

            Customer customer;

            while (dataReader.Read())
            {
                customer = new Customer(
                    Convert.ToInt32(dataReader[0]),
                    dataReader[1].ToString(),
                    dataReader[2].ToString(),
                    dataReader[3].ToString(),
                    dataReader[4].ToString(),
                    dataReader[5].ToString(),
                    dataReader[6].ToString(),
                    dataReader[7].ToString(),
                    dataReader[8].ToString()); 

                list.Add(customer);
            }

            return list;
        }

        //This method will return the current auto-Increment values for CustomerId
        public static int CurrentIncrementValue()
        {

            SqlConnection conn = UtilityDB.ConnectDB();

            SqlCommand cmdSelectAll = new SqlCommand($"SELECT IDENT_CURRENT('Customers');", conn);

            SqlDataReader dataReader = cmdSelectAll.ExecuteReader();

            if (dataReader.Read())
            {
                return Convert.ToInt32(dataReader[0]);
            }

            return 0;
        }

        

        

    }
}
