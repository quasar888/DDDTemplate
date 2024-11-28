using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTemplate
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Guid CreateOrder(Customer customer)
        {
            var order = new Order(customer);
            _orderRepository.Save(order);
            return order.Id;
        }

        public void AddItemToOrder(Guid orderId, OrderItem item)
        {
            var order = _orderRepository.GetById(orderId);
            if (order == null) throw new ArgumentException("Order not found.", nameof(orderId));

            order.AddItem(item);
            _orderRepository.Save(order);
        }

        public void PayForOrder(Guid orderId)
        {
            var order = _orderRepository.GetById(orderId);
            if (order == null) throw new ArgumentException("Order not found.", nameof(orderId));

            order.MarkAsPaid();
            _orderRepository.Save(order);
        }
    }

}
