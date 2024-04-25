﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Entities
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public ICollection<Order>? Orders { get; set; }
    }
}
