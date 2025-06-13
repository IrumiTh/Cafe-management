﻿namespace CafeManagement.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }

        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
