using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class Employee
    {
        public Employee(string firstname, string lastname, double retailsales, int storeNumber)
        {
            FirstName = firstname;
            LastName = lastname;
            RetailSales = retailsales;
            StoreNumber = storeNumber;
        }

        public string RoleMenu
        {
            get
            {
                return 
@$"Please Choose Employee's Role
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
        public int StoreNumber;

        public void EmployeeDetails()
        {
            Console.WriteLine($@"
  {Role}
  Employee Name: {FirstName} {LastName}
  Retail Sales: ${RetailSales}
");
        }

        public void ShowRoleMenu()
        {
            GetRoleMenu();
            GetPlayerInput();
        }

        public void GetPlayerInput()
        {
            var input = Console.ReadKey().KeyChar.ToString();

            var inputInt = int.TryParse(input, out int inputAsInt);

            if (!String.IsNullOrWhiteSpace(input) && inputInt)
            {
                Role = (RoleSelection)inputAsInt;
            } else
            {
                ShowRoleMenu();
            }
        }

        public void GetRoleMenu()
        {
            Console.WriteLine(RoleMenu);
        }
    }
}
