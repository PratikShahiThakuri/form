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
        public int CountryOfVisit { get; set; }
        public string NameOfTheCollege { get; set; }
        public string NameOfTheUniversity { get; set; }
        public string NameOfTheCourse { get; set; }
    }
}