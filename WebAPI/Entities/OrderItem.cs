using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities
{
    public class OrderItem
    {
        [Key]
        public Guid OrderItemId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public int? Quantity { get; set; }
        [Precision(14, 2)]
        public decimal Price { get; set; }

        public Guid OrderDetailId { get; set; } 
        public OrderDetail OrderDetail { get; set; } 
    }
}
