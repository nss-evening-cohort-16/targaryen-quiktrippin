using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class Store
    {
        //store consists of a group of associates, store manager, and assistant manager
        public Store(int storeNumber, string storeManager, string assistantManager, double storeManagerRetailSales, double assistantManagerRetailSales)
        {
            StoreNumber = storeNumber;
            StoreManager = storeManager;
            AssistantManager = assistantManager;
            StoreManagerRetailSales = storeManagerRetailSales;
            AssistantManagerRetailSales = assistantManagerRetailSales;
        }

        public int StoreNumber { get; set; }
        //gabriel making these?
        //public List<Associate> Associates { get; set; }
        public string StoreManager { get; set; }
        public string AssistantManager { get; set; }
        public double StoreManagerRetailSales { get; set; }
        public double AssistantManagerRetailSales { get; set;}
    }
}
