// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 public class text
    {
        public static void Main()
        {
            var order = new Order();
            var item1 = new OrderItem { ProductId = 1, Quantity = 2 };
            var item2 = new OrderItem { ProductId = 2, Quantity = 3 };

            order.AddOrderItem(item1);
            order.AddOrderItem(item2);
            // Perform other operations on the order
            // ...
        }
    }