using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailId { get; set; }
        public ICollection<OrderItem> Items { get; set; }
        [Precision(14, 2)]
        public decimal Subtotal { get; set; }
        [Precision(14, 2)]
        public decimal ShippingFee { get; set; }
        [Precision(14, 2)]
        public decimal Tax { get; set; }
        [Precision(14, 2)]
        public decimal Total { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
