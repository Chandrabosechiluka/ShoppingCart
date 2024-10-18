using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class LineItem
    {
        public int Id { get; }
        public int Quantity { get; }
        public Product Product { get; }

        public LineItem(int id, int quantity, Product product)
        {
            Id = id;
            Quantity = quantity;
            Product = product;
        }

        public double CalculateLineItemCost()
        {
            return Quantity * Product.CalculateDiscountedPrice();
        }

    }


}
