//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QuikTrippin.Models
//{
//    internal class DistrictSales
//    {
//        //Constructors
//        //Enter the district sales
//        //Store sales
//        //Enter store sales should have store manager sales, Assistant Manager sales, and Associate Sales
//        //
//        public DistrictSales(double employeeRetailSales, double assistantManagerSales, double managerSales)
//        {
//            EmployeeRetailSales = employeeRetailSales;
//            AssistantManagerSales = assistantManagerSales;
//            ManagerSales = managerSales;
//        }
//        // Fields
//        private double _EmployeeRetailSales;
//        private double _AssistantManagerSales;
//        private double _ManagerSales;
//        private double _TotalSales;
        
//        // Properties
//        public double EmployeeRetailSales { get; set; }
//        public double AssistantManagerSales { get; set;}
//        public double ManagerSales { get; set; }
//        public double storeSales => EmployeeRetailSales + AssistantManagerSales + ManagerSales;
//        // Methods
//        public void Sales()
//        {
//            _TotalSales = storeSales;
//            Console.WriteLine(_TotalSales.ToString());
//        }
//    }
//}
