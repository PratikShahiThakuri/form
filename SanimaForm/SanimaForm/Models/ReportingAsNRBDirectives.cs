using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SanimaBank.Models
{
    public class ReportingAsNRBDirectives
    {
        [Display(Name ="9.3- Sector Code")]
        public string SectorCode { get; set; }
        [Display(Name ="9.3ka- Product Code")]
        public string ProductCode { get; set; }
        [Display(Name ="9.4-Security Code")]
        public string SecurityCode { get; set; }
        [Display(Name ="New CIB Report Code")]
        public string NewCIBReportCode { get; set; }
        [Display(Name ="Capital Adequacy Code")]
        public string CapitalAdequacyCode { get; set; }
    }
}