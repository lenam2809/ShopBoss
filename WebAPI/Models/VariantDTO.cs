using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;

namespace WebAPI.Models
{
    public class VariantDTO
    {
        public Guid VariantId { get; set; }
        public string Sku { get; set; } = string.Empty;
        public int? Stock { get; set; }
        public decimal? Price { get; set; }
        public string Size { get; set; } = string.Empty;
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
