﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_tier.Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string ISBN { get; set; } = null!;
        
        public string? Author { get; set; }
        [Range(1,1000)]
        public double ListPrice { get; set; }

        [Display(Name = "Price for 1-50")]
        [Range(1, 1000)]
        public double Price { get; set; }


        [Display(Name = "Price for 50+")]
        [Range(1, 1000)]
        public double Price50 { get; set; }

        [Display(Name = "Price for 100+")]
        [Range(1, 1000)]
        public double Price100 { get; set; }

        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        public string? imageUrl { get; set; }
    }
}
