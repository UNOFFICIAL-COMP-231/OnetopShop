﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OneStopShop.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int StoreID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string ProductDescription { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a positive price")]
        public decimal ProductPrice { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public DateTime ProductCreatedDate { get; set; }
        public DateTime ProductModifiedDate { get; set; }
      
        public string ProductImage { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }

    }
}
