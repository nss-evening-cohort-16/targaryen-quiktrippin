using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class StoreReport
    {
        // Constructors
        public StoreReport(
            int storeNumber
        )
        {
            _storeNumber = storeNumber;
        }

        // Fields
        private int _storeNumber;
        //_employees // an employee has a title, name, and retail sales

        // Properties
        float gasYearly { get; set; }
        float gasCurrentQuarter { get; set; }
        float retailYearly { get; set; }
        float retailCurrentQuarter { get; set; }

        // Methods
        public void PrintStoreReport()
        {
            Console.WriteLine(@$"
Store #{_storeNumber}
------------------------------
");
        }
    }
}
