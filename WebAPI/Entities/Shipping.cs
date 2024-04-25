﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities
{
    public class Shipping
    {
        [Key]
        public Guid ShippingId { get; set; } 
        public string CustomerName { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty; 
        public string City { get; set; } = string.Empty; 
        public string State { get; set; } = string.Empty; 
        public string ZipCode { get; set; } = string.Empty; 
        public string Country { get; set; } = string.Empty; 
    }
}
