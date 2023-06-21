using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileConnectionLibrary
{
    public abstract class Service
    {

        public abstract int Payment();

        public virtual string GetInfo()
        {
            var payment = Payment();
            return $"К оплате {payment}";
        }
    }
}