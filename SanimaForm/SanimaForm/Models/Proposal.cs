using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SanimaBank.Models
{
    public class Proposal
    {
        [DataType(DataType.MultilineText)]
        public string Input { get; set; }
        [Display(Name ="Country Of Visit")]
        public string CountryOfVisit { get; set; }
        [Display(Name = "Name Of The College")]

        public string NameOfTheCollege { get; set; }
        [Display(Name = "Name Of The University")]

        public string NameOfTheUniversity { get; set; }
        [Display(Name = "Name Of Course")]

        public string NameOfTheCourse { get; set; }
    }
}