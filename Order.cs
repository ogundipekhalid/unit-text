
  public    class OrderItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        // Other properties specific to an order item
    }



    
    // Define the Order entity
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        // Other properties specific to an order

        // Constructor for creating a new order
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        // Add an order item to the order
        public void AddOrderItem(OrderItem item)
        {
            // Validate business rules (e.g., quantity > 0, product exists, etc.)
            // Add the item to the list
            OrderItems.Add(item);
        }

        // Other methods related to order management
    }