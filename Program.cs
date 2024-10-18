using ShoppingCart.Models;

namespace ShoppingCart
{
    class Program
    {
        static void Main()
        {
           

            var laptop = new Product(101, "Laptop", 1000, 10);
            var mobile = new Product(102, "Mobile", 50, 5);
            var tab = new Product(103, "Tab", 300, 15);
            var computer = new Product(104, "Computer", 100, 0);

            var lineItem1 = new LineItem(201, 1, laptop);
            var lineItem2 = new LineItem(202, 2, mobile);
            var lineItem3 = new LineItem(203, 1, tab);
            var lineItem4 = new LineItem(204, 1, computer);

            var order1 = new Order(301, new DateTime(2024, 10, 8), new List<LineItem> { lineItem1, lineItem3 });
            var order2 = new Order(302, new DateTime(2024, 10, 7), new List<LineItem> { lineItem2, lineItem4 });

            var customer1 = new Customer(401, "Chandrabose Chiluka", new List<Order> { order1, order2 });

            customer1.DisplayCustomerDetails();
        }
    }

}
