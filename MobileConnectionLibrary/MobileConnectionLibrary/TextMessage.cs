using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileConnectionLibrary
{
    public class TextMessage : Service
    {
        public int MessageCost { get; set; }
        public int NumberOfFreeMessagesPerMonth { get; set; }

        public override int Payment() => MessageCost * NumberOfFreeMessagesPerMonth;

        public TextMessage(int message_сost, int free_messages_per_month) //конструктор класса

        {
            MessageCost = message_сost;

            NumberOfFreeMessagesPerMonth = free_messages_per_month;
        }

        public override string GetInfo() => base.GetInfo();
    }
}