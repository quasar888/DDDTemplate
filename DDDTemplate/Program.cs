namespace DDDTemplate
{
    public class Program
    {
        public static void Main()
        {
            var repository = new InMemoryOrderRepository();
            var orderService = new OrderService(repository);

            Console.WriteLine("Creating a new customer...");
            var customer = new Customer("John Doe", "john.doe@example.com");

            Console.WriteLine("Creating a new order...");
            var orderId = orderService.CreateOrder(customer);

            Console.WriteLine("Adding items to the order...");
            orderService.AddItemToOrder(orderId, new OrderItem("Laptop", 1200, 1));
            orderService.AddItemToOrder(orderId, new OrderItem("Mouse", 25, 2));

            Console.WriteLine("Paying for the order...");
            orderService.PayForOrder(orderId);

            var order = repository.GetById(orderId);
            Console.WriteLine($"Order {order.Id} for {order.Customer.Name} has been paid. Total amount: ${order.TotalAmount}");
        }
    }

}
