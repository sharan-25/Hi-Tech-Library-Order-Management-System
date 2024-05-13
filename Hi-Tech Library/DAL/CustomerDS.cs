using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechLibrary.DAL;

namespace Hi_Tech_Library.DAL
{
    public class CustomerDS
    {
        private static DataSet dsCustomerDB = null;

        public static DataSet GetCustomerDS()
        {
            if (dsCustomerDB == null)
            {
                dsCustomerDB = new DataSet("CustomerDS");

                DataTable dtCustomers = new DataTable("Customers");

                dsCustomerDB.Tables.Add(dtCustomers);

                dtCustomers.Columns.Add("CustomerId", typeof(int));
                dtCustomers.Columns.Add("FirstName", typeof(string));
                dtCustomers.Columns.Add("LastName", typeof(string));
                dtCustomers.Columns.Add("Street", typeof(string)); 
                dtCustomers.Columns.Add("City", typeof(string)); 
                dtCustomers.Columns.Add("PostalCode", typeof(string));
                dtCustomers.Columns.Add("PhoneNumber", typeof(string)); 
                dtCustomers.Columns.Add("FaxNumber", typeof(string)); 
                dtCustomers.Columns.Add("CreditLimit", typeof(string)); 

                dtCustomers.PrimaryKey = new DataColumn[] { dtCustomers.Columns["CustomerId"] };

                dtCustomers.Columns["CustomerId"].AutoIncrement = true;
                dtCustomers.Columns["CustomerId"].AutoIncrementSeed = 555;
                dtCustomers.Columns["CustomerId"].AutoIncrementStep = 1;

                CustomersDataAdapter();
            }

            return dsCustomerDB;
        }

        public static SqlDataAdapter CustomersDataAdapter()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Customers;", UtilityDB.ConnectDB());

            sqlDataAdapter.TableMappings.Add("Customers", "Customers");

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            sqlDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Customers;", UtilityDB.ConnectDB());

            sqlDataAdapter.Fill(dsCustomerDB, "Customers");

            return sqlDataAdapter;
        }

    }
}
