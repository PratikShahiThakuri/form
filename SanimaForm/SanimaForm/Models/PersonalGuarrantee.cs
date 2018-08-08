using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SanimaForm.Models
{
    public class PersonalGuarrantee
    {
        public string Name { get; set; }
        public SanimaBank.Enums.Status Status { get; set; }
    }
}