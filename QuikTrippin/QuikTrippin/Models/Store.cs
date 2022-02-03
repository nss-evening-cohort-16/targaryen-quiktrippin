using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class Stores
    {
        //store consists of a group of associates, store manager, and assistant manager
        public Stores(int storeNumber, string storeManager, string assistantManager,
            double storeManagerRetailSales, double assistantManagerRetailSales
            )
        {
            StoreNumber = storeNumber;
            StoreManager = storeManager;
            AssistantManager = assistantManager;
            StoreManagerRetailSales = storeManagerRetailSales;
            AssistantManagerRetailSales = assistantManagerRetailSales;
        }

        public Stores(int storeNumber)
        {
            StoreNumber = storeNumber;
        }

        public int StoreNumber { get; set; }

        //public List<Associate> Associates { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void ShowEmployees()
        {
            Employees.ForEach(em => em.EmployeeDetails());
        }

        public string StoreManager { get; set; }
        public string AssistantManager { get; set; }
        public double StoreManagerRetailSales { get; set; }
        public double AssistantManagerRetailSales { get; set;}

    }
}
