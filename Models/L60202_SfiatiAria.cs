﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMBListini.Models
{
    [Table("SfiatiAria", Schema = "L6020_2")]
    public class L6020_2SfiatiAria
    {
        [Key]
        public int SfiatiAriaID { get; set; }
        public string SfiatiAriaAcronym { get; set; }
        public string SfiatiAriaDesc { get; set; }
        public int NSfiati { get; set; }
        public decimal SfiatiAriaPrice { get; set; }
        public decimal SfiatiAriaPriceMultiplier { get; set; }
        public Boolean isActive { get; set; }


    }
}