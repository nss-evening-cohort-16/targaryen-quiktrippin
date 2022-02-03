using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin
{
    public class MenuMethod
    {
        public static void Menu()
        {
            Console.WriteLine("QuickTrip Management Systems");
            Console.WriteLine(@"
1. Enter District Sales
2. Generate District Report
3. Add New Employee
4. Add a Store/District
5. Exit
");
        }
    }
}
