// See https://aka.ms/new-console-template for more information
using QuikTrippin.Models;
using static QuikTrippin.MenuMethod;

var stringMenuSelect = "0";
int intMenuSelect = 0;
bool success = false;
bool storeNumSuccess = false;
var stringStoreNum = "0";
int storeNum = 0;
double parsedRetail = 0;

while (intMenuSelect != 5)
{
    Menu();
    stringMenuSelect = Console.ReadLine();
    success = (int.TryParse(stringMenuSelect, out intMenuSelect));
    if (success && intMenuSelect == 4)
    {
        Console.Clear();

        Console.WriteLine("Enter District Name:");
        var districtName = Console.ReadLine();

        Console.WriteLine("Enter District Manager Name:");
        var districtManagerName = Console.ReadLine();

        District district = new District(districtManagerName, districtName);

        Console.WriteLine("Enter store number:");
        stringStoreNum = Console.ReadLine();
        storeNumSuccess = (int.TryParse(stringStoreNum, out storeNum));

        Stores store = new Stores(storeNum);

        district.AddStore(storeNum);

        //testing to see if stores are in the district
        //district.ShowStores();

        Console.Clear();

        success = false;
    } else if (success && intMenuSelect == 3)
    {
        var StoreQ = "Enter store's number";
        var EmployeeName1 = "Enter Employee's First Name";

        Console.Clear();

        District.ShowStores();

        Console.WriteLine(StoreQ);
        var StoreNumber = Console.ReadLine();
        storeNumSuccess = int.TryParse(StoreNumber, out storeNum);

        var MatchingStoreNum = District.Stores.Find(store => store.StoreNumber == storeNum);

        Console.Clear();

        Console.WriteLine(EmployeeName1);
        var firstname = Console.ReadLine();

        var EmployeeName2 = $"Enter {firstname}'s Last Name";

        Console.WriteLine(EmployeeName2);
        var lastname = Console.ReadLine();

        Console.WriteLine($"Enter {firstname}'s retail sales");
        var retailsales = Console.ReadLine();
        success = double.TryParse(retailsales, out parsedRetail);

        Employee employees = new Employee(firstname, lastname, parsedRetail);

        employees.ShowRoleMenu();

        MatchingStoreNum.AddEmployee(employees);

        Console.Clear();

    }
    else
    {
        Console.WriteLine("Please enter a number between 1-6.\n");
        success = false;
    }
}

