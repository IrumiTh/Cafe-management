// File: Models/OrderItem.cs
using System.Text.Json.Serialization;

namespace CafeManagement.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        [JsonIgnore] // Prevents MenuItem from being required in the request body
        public MenuItem? MenuItem { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}