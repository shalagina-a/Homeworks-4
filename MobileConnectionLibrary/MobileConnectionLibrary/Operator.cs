using MobileConnectionLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MobileConnection
{
    public class Operator : IEnumerable<Subscriber>
    {
        public OrganizationName OrganizationName;
        public int OrganizationTaxIdentificationNumber;

        List<Subscriber> subscriber_list;

        public int Count { get => subscriber_list.Count; }

        public Operator(OrganizationName organization_name, int organization_tin, IEnumerable<Subscriber> subscribers)

        {

            OrganizationName = organization_name;

            OrganizationTaxIdentificationNumber = organization_tin;

            subscriber_list = new List<Subscriber>(subscribers.Distinct());

        }

        public IEnumerator<Subscriber> GetEnumerator() => subscriber_list.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
