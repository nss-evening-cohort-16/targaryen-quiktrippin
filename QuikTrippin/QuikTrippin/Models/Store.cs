using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class Store
    {
        //store consists of a group of associates, store manager, and assistant manager
        public Store(int storeNumber, string storeManager, string assistantManager,
            double storeManagerRetailSales, double assistantManagerRetailSales
            )
        {
            StoreNumber = storeNumber;
            StoreManager = storeManager;
            AssistantManager = assistantManager;
            StoreManagerRetailSales = storeManagerRetailSales;
            AssistantManagerRetailSales = assistantManagerRetailSales;
        }

        public Store(int storeNumber)
        {
            StoreNumber = storeNumber;
        }

        public int StoreNumber { get; set; }

        //public List<Associate> Associates { get; set; }
        public static List<Employee> Employees { get; set; } = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public string StoreManager { get; set; }
        public string AssistantManager { get; set; }
        public double StoreManagerRetailSales { get; set; }
        public double AssistantManagerRetailSales { get; set;}

        public static void EmployeeReport(int store)
        {
            int employeeNum = 0;
            foreach (Employee employee in Employees)
            {
                if (employee.StoreNumber == store)
                {
                    employeeNum++;
                    Console.WriteLine($@"{employeeNum}.  {employee.Role}
    {employee.FirstName} {employee.LastName}:
        Retail Sales: ${employee.RetailSales}
");
                }
            }
        }

    }
}
