using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SanimaBank.Enums
{
    public enum Set
    {
        Retail,
        Microfinance,
        Business,
        Corporate
    }
    public enum Status
    {
        NA,
        [Display(Name ="To be obtained")]
        ToBeObtained,
        Obtained
    }
    public enum Remarks
    {
        Yes,
        No,
        NA
    }
}