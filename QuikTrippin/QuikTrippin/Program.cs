// See https://aka.ms/new-console-template for more information
using QuikTrippin.Models;
using static QuikTrippin.MenuMethod;

var stringMenuSelect = "0";
int intMenuSelect = 0;
bool success = false;

while (intMenuSelect != 5)
{
    Menu();
    stringMenuSelect = Console.ReadLine();
    success = (int.TryParse(stringMenuSelect, out intMenuSelect));
    if (success)
    {
        Console.WriteLine(intMenuSelect);
        success = false;
    }
    else
    {
        Console.WriteLine("Please enter a number between 1-6.\n");
        success = false;
    }
}
