using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Order
    {
        public int Id { get; }
        public DateTime Date { get; }
        public List<LineItem> Items { get; }

        public Order(int id, DateTime date, List<LineItem> items)
        {
            Id = id;
            Date = date;
            Items = items;
        }

        public double CalculateOrderPrice()
        {
            double totalPrice = 0;
            foreach (var item in Items)
            {
                totalPrice += item.CalculateLineItemCost();
            }
            return totalPrice;
        }
        public void DisplayOrderDetails(int orderNumber)
        {
            Console.WriteLine($"\nOrder No. {orderNumber}");
            Console.WriteLine($"Order Id: {Id}");
            Console.WriteLine($"Order Date: {Date.ToShortDateString()}\n");

            Console.WriteLine("LineItemId  ProductId  ProductName  " +
                "   Quantity  UnitPrice  Discount%  " +
                "Unit Cost After Discount  Total LineItem Cost");
            Console.WriteLine("------------------------------------------------" +
                "---------------------------------------------------------------------");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Id,-12}  {item.Product.Id,-10} " +
                    $" {item.Product.Name,-14}  {item.Quantity,-8}  {item.Product.Price,-10}" +
                    $"  {item.Product.DiscountPercent,-9}  {item.Product.CalculateDiscountedPrice(),-23} " +
                    $" {item.CalculateLineItemCost()}");
            }
            Console.WriteLine($"\nOrder Cost: {CalculateOrderPrice()}");
        }

    }


}
