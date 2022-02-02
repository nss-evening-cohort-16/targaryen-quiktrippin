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
        public static List<Stores> Stores { get; set; }

        public void AddStore(int storeNum)
        {
            if (Stores == null)
            {
                Stores = new List<Stores>();
            }

            var store = new Stores(storeNum);
            Stores.Add(store);
        }

        public static void ShowStores()
        {
            int storeList = 0;
            foreach (Stores store in Stores)
            {
                storeList++;
                Console.WriteLine($"{storeList}.Store Number: {store.StoreNumber}"); 
            }
        }

    }
}
