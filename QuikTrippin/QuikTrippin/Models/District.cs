using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class District
    {
        //composed of a collection of a Store
        //has one district manager
        //has a district name
        public District(string districtManager, string name)
        {
            DistrictManager = districtManager;
            Name = name;
        }
        public string Name { get; set; }
        public string DistrictManager { get; set; }
        public List<Store> Stores { get; set; }

        public void AddStore(int storeNum, string manager, string assistantManager, double storeManagerRetailSales, double assistantManagerRetailSales)
        {
            if (Stores == null)
            {
                Stores = new List<Store>();
            }

            var store = new Store(storeNum, manager, assistantManager, storeManagerRetailSales, assistantManagerRetailSales);
            Stores.Add(store);
        }

    }
}
