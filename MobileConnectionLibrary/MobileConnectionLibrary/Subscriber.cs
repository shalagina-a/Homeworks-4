using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileConnectionLibrary
{
    public class Subscriber
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public long PhoneNumber { get; set; } // длинный инт

        public readonly int ContractNumber;

        private string tariff_name; //поле
        public string TariffName //свойство
        {
            get
            {
                return tariff_name;
            }

            set
            {
                tariff_name = value;
            }
        }

        public PaymentType PaymentType;

        private int sum;
        public int Sum
        {
            get
            {
                return sum;
            }

            set
            {
                sum = value;
            }
        }

        public Subscriber(string name, string surname, long phone_number, int contract_number) //конструктор класса

        {
            Name = name;
            Surname = surname;
            PhoneNumber = phone_number;
            ContractNumber = contract_number;

        }

        public string GetInfo()
        {
            return $"{Name} {Surname}. Телефонный номер: {PhoneNumber}. " +
                $"Номер договора: {ContractNumber}. ";
        }
    }
}