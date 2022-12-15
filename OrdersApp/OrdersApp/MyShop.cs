using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApp
{
    public class MyShop
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Order> Orders { get; set; } = new List<Order>(); 

        public void Init()
        {
            Orders.Clear();
            Products.Add(new Product()
            {
                ProductId = 1,
                Name = "Яблоки",
                Price = 80m,
                Count = 1000
            });
            Products.Add(new Product()
            {
                ProductId = 2,
                Name = "Мандарины",
                Price = 120m,
                Count = 1000
            });
            Products.Add(new Product()
            {
                ProductId = 3,
                Name = "Груши",
                Price = 180m,
                Count = 900
            });
            Products.Add(new Product()
            {
                ProductId = 4,
                Name = "Бананы",
                Price = 70m,
                Count = 800
            });
            Products.Add(new Product()
            {
                ProductId = 5,
                Name = "Виноград",
                Price = 150m,
                Count = 1200
            });
            Customers.Add(new Customer()
            {
                CustomerId = 1,
                Name = "Иванов",
                City = "Казань",
                Address = "Адрес 1"
            }) ;
            Customers.Add(new Customer()
            {
                CustomerId = 2,
                Name = "Петров",
                City = "Москва",
                Address = "Адрес 2"
            });
            Customers.Add(new Customer()
            {
                CustomerId = 3,
                Name = "Сидоров",
                City = "Самара",
                Address = "Адрес 3"
            });
        }


        public void PrintProducts()
        {
            Console.WriteLine("Список товаров;");
            Products.Sort();
            foreach (var prod in Products)
            {
                Console.WriteLine(prod);
            }
        }
        public void PrintCustomers()
        {
            //Customers.Sort();
            Console.WriteLine("Список заказчиков;");
            foreach (var cust in Customers)
            {
                Console.WriteLine(cust);
            }
        }
        public void PrintOrders()
        {
            Console.WriteLine("Список заказов;");
            foreach (var ord in Orders)
            {
                Console.WriteLine(ord);
            }
        }

        public bool ExistCustomer(int id)
        {
            foreach(var c in Customers)
            {
                if(c.CustomerId == id) 
                    return true; 
            }
            return false;
        }

        public bool ExistProduct(int id)
        {
            foreach (var p in Products)
            {
                if (p.ProductId == id)
                    return true;
            }
            return false;
        }

        public void AddNewOrder(int custId, int prodId, int count)
        {
            Customer cust = null;
            Product prod = null;
            foreach (var c in Customers)
            {
                if (c.CustomerId == custId)
                    cust = c;
            }
            
            foreach (var p in Products)
            {
                if (p.ProductId == prodId)
                    prod = p; ;
            }
            var ord = new Order(cust, prod, count);
            Orders.Add(ord);
            Console.WriteLine("Добавлен заказ:");
            Console.WriteLine(ord);
        }


    }
}
