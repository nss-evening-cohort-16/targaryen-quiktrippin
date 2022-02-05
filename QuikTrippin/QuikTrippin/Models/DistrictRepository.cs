using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class DistrictRepository
    {
        public static List<District> _districts = new List<District>();

        public static void SaveNewDistrict(District district)
        {
            _districts.Add(district);
        }

        public static List<District> GetDistricts()
        {
            return _districts;
        }

        //public static void DistrictReport(string districtName)
        //{
        //    foreach(District district in _districts)
        //    {
        //        if (district.Name == districtName)
        //        {
        //            District.StoreReport(district);
        //        }
        //    }
        //}
    }
}