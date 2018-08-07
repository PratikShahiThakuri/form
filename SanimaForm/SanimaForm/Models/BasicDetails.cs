using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SanimaBank.Models
{
    public class BasicDetails
    {
      
        public DateTime Date { get; set; }
        [Display(Name ="Client Code number")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Client Code")]
        public int ClientCodeNumber { get; set; }
        public string UDRN { get; set; }
        [Display(Name ="Type Of Facility")]
        public int TypeOfFacility { get; set; }
        [Display(Name = "Credit Facility Number")]
        public string CreditFacilityNumber { get; set; }
        public  Enums.Set Set  { get; set; }
        [Display(Name ="Risk Category")]
        public int RiskCategory { get; set; }
        public string Group { get; set; }

    }
}