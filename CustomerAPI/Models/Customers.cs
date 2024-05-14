﻿using System.ComponentModel.DataAnnotations;

namespace CustomerAPI.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
    }
}
