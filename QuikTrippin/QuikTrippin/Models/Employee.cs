using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class Employee
    {
        public Employee(string role, string firstname, string lastname, double retailsales)
        {
            firstname = FirstName;
            lastname = LastName;
            retailsales = RetailSales;
            role = Role;
        }

        public string Role;
        public string FirstName;
        public string LastName;
        public double RetailSales;

        public void EmployeeDetails()
        {
            Console.WriteLine($@"
  {Role}
  Employee Name: {FirstName} {LastName}
  Retail Current quarter: ${RetailSales}
");
        }
    }
}
