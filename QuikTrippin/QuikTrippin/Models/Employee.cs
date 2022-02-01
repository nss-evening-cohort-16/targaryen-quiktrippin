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

        private string Role;
        private string FirstName;
        private string LastName;
        private double RetailSales;

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
