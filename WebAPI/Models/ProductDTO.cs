using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;

namespace WebAPI.Models
{
    public class ProductDTO
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public List<string>? Images { get; set; }
        public List<VariantDTO>? VariantS { get; set; }
    }
}
