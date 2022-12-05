using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Покупатель {CustomerId} -  {Name} {City} {Address}";
        }

    }
}
