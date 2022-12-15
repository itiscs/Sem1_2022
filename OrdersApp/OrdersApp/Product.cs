using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class Product:IComparable
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Товар {ProductId} - {Name} {Price} {Count}";
        }

        public int CompareTo(object? other)
        {
            var prod = other as Product;
            if (prod == null)
                throw new ArgumentException("Нужен товар!");


            //return -1 * Name.CompareTo(prod.Name);   

            if (Count == prod.Count) return 0 ;
            if (Count > prod.Count) return 1;
            return -1;           
        }



    }
}
