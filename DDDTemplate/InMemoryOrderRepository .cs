using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTemplate
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly Dictionary<Guid, Order> _orders = new();

        public void Save(Order order)
        {
            _orders[order.Id] = order;
        }

        public Order GetById(Guid orderId)
        {
            _orders.TryGetValue(orderId, out var order);
            return order;
        }
    }
}
