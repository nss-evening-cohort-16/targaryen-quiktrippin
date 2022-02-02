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

        public void SaveNewDistrict(District district)
        {
            _districts.Add(district);
        }

        public List<District> GetDistricts()
        {
            return _districts;
        }
    }
}
