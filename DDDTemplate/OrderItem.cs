using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTemplate
{
    public class OrderItem
    {
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(string productName, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(productName)) throw new ArgumentNullException(nameof(productName));
            if (price <= 0) throw new ArgumentException("Price must be greater than zero.", nameof(price));
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.", nameof(quantity));

            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }

}
