using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Count { get; set; }
        public decimal Amount { get; set; }
        public  Customer Customer{ get; set; }
        public Product Product { get; set; }

        public static int CurId { get; set; } = 0;

        public override string ToString()
        {
            return $"Заказ {OrderId} - {OrderDate:g} {Product.Name}  {Customer.Name} {Count} {Amount}";
        }
    }
}
