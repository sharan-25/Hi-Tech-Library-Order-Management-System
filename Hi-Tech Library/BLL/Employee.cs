using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class Employee
    {
        //fields
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public int JobId { get; set; }
        public int StatusId { get; set; }

        //Save Employee
        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveEmployeeRecord(emp);
        }

        //Check Unique Primary Key(Employee ID)
        public bool IsUniqueEmployeeId(int empId)
        {
            return EmployeeDB.IsUniqueId(empId);
        }


        //Search Employee by EmployeeID
        public Employee SearchEmployee(int id)
        {
            return EmployeeDB.Search(id);
        }
        //Search Employee by  JobId,StatusId
        public List<Employee> SearchEmployeebyId(int id)
        {
            return EmployeeDB.SearchById(id);
        }
        //Search Employee by FirstName, LastName, Emal, PhoneNumber
        public List<Employee> SearchEmployee(string input)
        {
            return EmployeeDB.Search(input);
        }
        //Get All employee Records
        public List<Employee> GetAllEmployees()
        {
            return EmployeeDB.GetAllEmployeeRecords();
        }

        //Update Employee 
        public void UpDateEmployee(Employee upDatedEmployee)
        {
            EmployeeDB.UpDate(upDatedEmployee);
        }

        //Delete Employee
        public void DeleteEmployee(Employee deletedEmployee)
        {
            EmployeeDB.Delete(deletedEmployee);
        }
    }
}
