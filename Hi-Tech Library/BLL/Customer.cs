using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.DAL;
using HiTechLibrary.DAL;

namespace Hi_Tech_Library.BLL
{
    public class Customer
    {
        //Customer Fields
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;

        public string Street { get; set; } 
        public string City { get; set; }

        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }

        public string CreditLimit { get; set; }

        //Default Constructor

        public Customer() { }

        //Constructor
        public Customer(int customerId, string firstName, string lastName, string street, string city, string postalCode, string phoneNumber, string faxNumber, string creditLimit)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            City = city;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            FaxNumber = faxNumber;
            CreditLimit = creditLimit;
        }



        //list all Customers
        public List<Customer> GetAllCustomer()
        {
            return CustomerDB.GetAllCustomerRecords();
        }

    }
}
