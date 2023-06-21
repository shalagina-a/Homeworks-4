using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileConnectionLibrary
{
    public class Internet : Service
    {
        public int MbOfTrafficCost { get; set; }
        public int AmountOfFreeTrafficPerMonth { get; set; }

        public override int Payment() => MbOfTrafficCost * AmountOfFreeTrafficPerMonth;

        public Internet(int mb_of_traffic_cost, int free_traffic_per_month) //конструктор класса

        {
            MbOfTrafficCost = mb_of_traffic_cost;
            AmountOfFreeTrafficPerMonth = free_traffic_per_month;
        }

        public override string GetInfo() => base.GetInfo();
    }
}