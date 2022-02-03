using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippin.Models
{
    internal class GasRecord
    {
        public GasRecord(double gasQ1, double gasQ2, double gasQ3, double gasQ4, int storeNum)
        {
            GasQ1 = gasQ1;
            GasQ2 = gasQ2;
            GasQ3 = gasQ3;
            GasQ4 = gasQ4;
            StoreNum = storeNum;
        }

        public double GasQ1 { get; set; }
        public double GasQ2 { get; set; }
        public double GasQ3 { get; set; }
        public double GasQ4 { get; set; }
        public int StoreNum { get; set; }

        public double GasYearly
        {
            get
            {
                double yearly = GasQ1 + GasQ2 + GasQ3 + GasQ4;
                return yearly;
            }
        }

        public void ShowGas()
        {
            Console.WriteLine($@"
Q1: ${GasQ1}
Q2: ${GasQ2}
Q3: ${GasQ3}
Q4: ${GasQ4}
");
        }
    }
}
