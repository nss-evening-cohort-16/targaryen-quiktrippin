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

        public Store(int storeNumber, string districtName)
        {
            StoreNumber = storeNumber;
            DistrictName = districtName;
        }

        public int StoreNumber { get; set; }
        public string StoreManager { get; set; }
        public string AssistantManager { get; set; }
        public double StoreManagerRetailSales { get; set; }
        public double AssistantManagerRetailSales { get; set; }

        public string DistrictName { get; set; }
        public static List<Employee> Employees { get; set; } = new List<Employee>();
        public static List<GasRecord> GasRecords { get; set; } = new List<GasRecord>();

        public void AddGasRecord(GasRecord gasrecord)
        {
            GasRecords.Add(gasrecord);
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void ShowEmployees()
        {
            Employees.ForEach(em => em.EmployeeDetails());
        }

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

        public static void GasReport(int store)
        {
            foreach (GasRecord record in GasRecords)
            {
                if(record.StoreNum == store)
                {
                    Console.WriteLine($@"
Gas Yearly: ${record.GasYearly}
Gas Current Quarter: ${record.GasQ1}");
                }
            }
        }

        public static void RetailReport(int store)
        {
            double retailCurrentQuarter = 0;
            foreach (Employee employee in Employees)
            {
                if (employee.StoreNumber == store)
                {
                    retailCurrentQuarter += employee.RetailSales;
                }
            }
            double retailYearly = retailCurrentQuarter * 4;

            Console.WriteLine($@"Retail Yearly: ${retailYearly}
Retail Current Quarter: ${retailCurrentQuarter}
");
        }

    }
}
