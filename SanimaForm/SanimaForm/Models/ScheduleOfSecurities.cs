using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SanimaBank.Models
{
    public class PropertyType
    {

        public string Land { get; set; }
        [Display(Name ="Land & Building")]
        public string LandAndBuilding { get; set; }
        [Display(Name ="Cash/Near Cash")]
        public decimal CashOrNearCash { get; set; }
        public string Other { get; set; }
    }
}