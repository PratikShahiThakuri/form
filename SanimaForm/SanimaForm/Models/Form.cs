﻿using SanimaForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanimaBank.Models
{
    public class Form
    {
        public virtual BasicDetails BasicDetail{ get; set; }
        public virtual ReportingAsNRBDirectives ReportingAsNRBDirective { get; set; }

        public virtual Legends Legend { get; set; }

        public virtual Proposal Proposals { get; set; }
        public virtual PropertyType PropertyTypes { get; set; }
        public virtual PrimeSecurityDetails PrimeSecurityDetail { get; set; }
        public virtual CreditCheckList_General CreditCheckList_Generals { get; set; }

    }
}