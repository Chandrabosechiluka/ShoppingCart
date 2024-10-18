using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Customer
    {
        public int Id { get; }
        public string Name { get; }
        public List<Order> Orders { get; }

        public Customer(int id, string name, List<Order> orders)
        {
            Id = id;
            Name = name;
            Orders = orders;
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer Id: {Id}");
            Console.WriteLine($"Customer Name: {Name} ");
            Console.WriteLine($"Order Count: {Orders.Count}\n");

            for (int i = 0; i < Orders.Count; i++)
            {
                Orders[i].DisplayOrderDetails(i + 1);
            }
        }
    }


}
