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
        public static List<Store> Stores { get; set; }

        public void AddStore(int storeNum, string districtName)
        {
            if (Stores == null)
            {
                Stores = new List<Store>();
            }

            var store = new Store(storeNum, districtName);
            Stores.Add(store);
        }

        public static void ShowStores()
        {
            int storeList = 0;
            foreach (Store store in Stores)
            {
                storeList++;
                Console.WriteLine($"{storeList}.Store Number: {store.StoreNumber}");
            }
        }

        public static void ShowStores(string name)
        {
            int storeList = 0;
            foreach (Store store in Stores)
            {
                if (store.DistrictName == name)
                {
                    storeList++;
                    Console.WriteLine($"{storeList}.Store Number: {store.StoreNumber}");
                }
            }
        }

        public static void DistrictReport(string name)
        {
            int storeList = 0;
            foreach (Store store in Stores)
            {
                if (store.DistrictName == name)
                {
                    storeList++;
                    Console.WriteLine($@"
{name} Store #{store.StoreNumber}
------------------------------");
                    Store.EmployeeReport(store.StoreNumber);
                    Store.GasReport(store.StoreNumber);
                    Store.RetailReport();
                }
            }
        }

    }
}
