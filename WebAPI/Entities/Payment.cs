using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; } 
        public string CardType { get; set; } = string.Empty; 
        public string CardNumberPartial { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty; // Optional payment method (e.g., credit card, PayPal)
    }
}
 