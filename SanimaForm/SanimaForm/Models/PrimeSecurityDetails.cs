using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SanimaForm.Models
{
    public class PrimeSecurityDetails
    {
        [Display(Name ="Registered Mortgage over the below mentioned Land/Land & Building Collateral in the favor of Sanima")]
        public SanimaBank.Enums.Status RegisteredMortgage { get; set; }
        [Display(Name ="Internal Loadn Deed & Demand Promissory note covering entire exposure")]
        public SanimaBank.Enums.Status InternalLoanDeed { get; set; }
        public virtual ICollection<PersonalGuarrantee>PersonalGuarranteeOf { get; set; }
        [Display(Name ="Valuation Report")]
        public string ValuationReport { get; set; }
        [Display(Name ="Preliminary Valuation Report")]
        public SanimaBank.Enums.Status PreliminaryValuationReport { get; set; }
        [Display(Name ="Final Valuation Report")]
        public SanimaBank.Enums.Status FinalValuationReport { get; set; }
        [Display(Name ="Internal Deed if below detailed collateral cross collateralized")]
        public SanimaBank.Enums.Status InternalDeed { get; set; }
        [Display(Name ="Corporate Guarantee")]
        public SanimaBank.Enums.Status CorporateGuarantee { get; set; }
        [Display(Name ="Other(If any)")]
        public SanimaBank.Enums.Status Others { get; set; }
    }
}