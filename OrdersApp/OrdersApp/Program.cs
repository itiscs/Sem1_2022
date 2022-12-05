using OrdersApp;

MyShop shop = new MyShop();
shop.Init();
bool exit = false;

while (!exit)
{
    Console.WriteLine();
    Console.WriteLine("***********************************");
    Console.WriteLine("Выберите пункт меню:");
    Console.WriteLine("1. Просмотреть товары.");
    Console.WriteLine("2. Просмотреть покупателей");
    Console.WriteLine("3. Просмотреть заказы");
    Console.WriteLine("4. Ввести заказ");
    Console.WriteLine("5. Выйти");

    var k = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (k)
    {
        case 1:
            {
                shop.PrintProducts();
                break;
            }
        case 2:
            {
                shop.PrintCustomers();
                break;
            }
        case 3:
            {
                shop.PrintOrders();
                break;
            }
        case 4:
            {
                Console.WriteLine("Введите номер покупаетеля");
                var cId = int.Parse(Console.ReadLine());
                if (!shop.ExistCustomer(cId))
                    break;
                Console.WriteLine("Введите номер товара");
                var pId = int.Parse(Console.ReadLine());
                if (!shop.ExistProduct(pId))
                    break;
                Console.WriteLine("Введите количество");
                var count = int.Parse(Console.ReadLine());

                shop.AddNewOrder(cId,pId,count);
                break;
            }
        case 5:
            {
                exit = true;
                break;
            }
        default:
            break;

    }
    




}