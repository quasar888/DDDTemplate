using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTemplate
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Customer Customer { get; private set; }
        public List<OrderItem> Items { get; private set; }
        public decimal TotalAmount => Items.Sum(item => item.Price * item.Quantity);
        public bool IsPaid { get; private set; }

        public Order(Customer customer)
        {
            Id = Guid.NewGuid();
            Customer = customer ?? throw new ArgumentNullException(nameof(customer));
            Items = new List<OrderItem>();
            IsPaid = false;
        }

        public void AddItem(OrderItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            Items.Add(item);
        }

        public void MarkAsPaid()
        {
            if (!Items.Any()) throw new InvalidOperationException("Cannot pay for an empty order.");
            IsPaid = true;
        }
    }

}
