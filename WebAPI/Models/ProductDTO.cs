using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;

namespace WebAPI.Models
{
    public class ProductDTO
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Precision(14, 2)]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public Guid CategoryId { get; set; }
    }
}
