using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MobileConnectionLibrary
{
    public class Call : Service
    {
        public int CostPerMinute { get; set; }
        public int NumberOfFreeMinutesPerMonth { get; set; }

        public override int Payment() => CostPerMinute * NumberOfFreeMinutesPerMonth;

        public Call(int cost_per_minute, int free_minutes_per_month) //конструктор класса

        {
            CostPerMinute = cost_per_minute;

            NumberOfFreeMinutesPerMonth = free_minutes_per_month;

        }

        public override string GetInfo() => base.GetInfo();

    }
}