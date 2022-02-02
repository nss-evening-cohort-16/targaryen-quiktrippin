using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class Employee
    {
        public Employee(string firstname, string lastname, double retailsales)
        {
            firstname = FirstName;
            lastname = LastName;
            retailsales = RetailSales;
        }

        public string RoleMenu
        {
            get
            {
                return @$"
Please Choose Employee's Role
1) Manager
2) Assistant Manager
3) Associate
";
            }

        }

        public enum RoleSelection
        {
            None = -1,
            Manager = 1,
            AssistantManager = 2,
            Associate = 3,
        }

        internal Employee()
        {
            Role = RoleSelection.None;
        }



        public RoleSelection Role;
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

        public void ShowRoleMenu()
        {
            GetRoleMenu();
            GetPlayerInput();
        }

        private void GetPlayerInput()
        {
            var input = Console.ReadKey().KeyChar.ToString();

            if (!String.IsNullOrWhiteSpace(input) && int.TryParse(input, out int inputAsInt))
            {
                Role = (RoleSelection)inputAsInt;
            }
        }

        private void GetRoleMenu()
        {
            Console.Clear();
            Console.WriteLine(RoleMenu);
        }
    }
}
