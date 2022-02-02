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

        public void SaveNewStore(Stores store)
        {
            _stores.Add(store);
        }

        public List<Stores> GetStores()
        {
            return _stores;
        }
    }
}
