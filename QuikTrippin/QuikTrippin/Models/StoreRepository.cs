using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class StoreRepository
    {
        static List<Store> _stores = new List<Store>();

        public void SaveNewStore(Store store)
        {
            _stores.Add(store);
        }

        public List<Store> GetStores()
        {
            return _stores;
        }
    }
}
