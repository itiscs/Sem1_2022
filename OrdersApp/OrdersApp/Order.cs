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
        private static int CurId { get; set; } = 0;

        public Order(Customer cust, Product prod, int count)
        {
            OrderId = CurId++;
            Customer = cust;
            Product = prod;
            Count = count;
            OrderDate = DateTime.Now;
            Amount = count * prod.Price;
        }

        public override string ToString()
        {
            return $"Заказ {OrderId} - {OrderDate:g} {Product.Name}  {Customer.Name} {Count} {Amount}";
        }
    }
}
