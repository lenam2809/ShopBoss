using Microsoft.EntityFrameworkCore;

namespace WebAPI.Entities
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        [Precision(14, 2)]
        public decimal UnitPrice { get; set; }
    }
}
