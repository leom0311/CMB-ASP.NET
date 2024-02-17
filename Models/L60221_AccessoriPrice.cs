﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMBListini.Models
{
    [Table("AccessoriPrice", Schema = "L6022_1")]
    public class L6022_1AccessoriPrice
    {
        [Key]
        public int AccessoriPriceID { get; set; }
        public int AccessoriCategoryID { get; set; }
        public decimal AccessoriPriceAlesaggioLength { get; set; }
        public decimal AccessoriPriceSteloValue { get; set; }
        public decimal AccessoriPrice { get; set; }
        public string AccessoriFilettaturaDesc { get; set; }
        public string AccessoriCode { get; set; }




    }
}