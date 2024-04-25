using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities
{
    public class Variant
    {
        [Key]
        public Guid VariantId { get; set; }
        public string Sku { get; set; } = string.Empty;
        public int? Stock { get; set; }
        [Precision(14, 2)]
        public decimal Price { get; set; }
        public string Size { get; set; } = string.Empty; 
        public Guid ProductId { get; set; } 

        public Product Product { get; set; } 
    }
}
