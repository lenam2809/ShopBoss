using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public string OrderCode { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public DateTime OrderUpdateDate { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        [Precision(14, 2)]
        public decimal? Amount { get; set; }

        public OrderDetail OrderDetail { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
