using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class DistrictRepository
    {
        static List<District> _districts = new List<District>();

        public void GetDistricts()
        {
            foreach (District district in _districts)
            {
                Console.WriteLine(district.DistrictManager);
            }
        }

        public void SaveNewDistrict(District district)
        {
            _districts.Add(district);
        }

        public void PrintDistrictReport()
        {
            Console.WriteLine($@"
District Sales Report
");
        }
    }
}
