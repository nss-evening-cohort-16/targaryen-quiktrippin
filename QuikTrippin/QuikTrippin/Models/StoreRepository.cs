using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class StoreRepository
    {
        static List<Stores> _stores = new List<Stores>();

        public void GetStores()
        {
            foreach (Store store in _stores)
            {
                Console.WriteLine(store.StoreNumber);
            }
        }

        public void SaveNewStore(Store store)
        {
            _stores.Add(store);
        }

        public List<Store> GetStores()
        {
            Console.WriteLine(@$"

");
        }
    }
}
