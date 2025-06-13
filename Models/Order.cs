namespace CafeManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal TotalPrice { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
