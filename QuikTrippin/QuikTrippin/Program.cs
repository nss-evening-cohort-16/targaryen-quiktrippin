// See https://aka.ms/new-console-template for more information
using QuikTrippin.Models;
using static QuikTrippin.MenuMethod;

var stringMenuSelect = "0";
int intMenuSelect = 0;
bool success = false;
bool storeNumSuccess = false;
var stringStoreNum = "0";
int storeNum = 0;

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

        Store store = new Store(storeNum);

        district.AddStore(storeNum);

        //testing to see if stores are in the district
        //district.ShowStores();

        Console.Clear();

        success = false;
    }
    else
    {
        Console.WriteLine("Please enter a number between 1-6.\n");
        success = false;
    }
}

