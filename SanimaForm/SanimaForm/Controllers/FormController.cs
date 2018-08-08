using SanimaBank.Models;
using SanimaForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanimaBank.Controllers
{
    public class FormController : Controller
    {
        
        // GET: Form
        public ActionResult Index()
        {
            var facilityType = new List<TypesOfFacility>()
            {new TypesOfFacility
                {
                Id=1,
                Name="A"
                }
            ,new TypesOfFacility
                {
                Id=2,
                Name="B"
                }
            };
            var risk = new List<RiskGrading>()
            {
                new RiskGrading
                {Id=1,
                Name="A"

                },
                 new RiskGrading
                {Id=2,
                Name="B"

                }
            };
            var form = new Form();
            var data = DateTime.Now;
            form.BasicDetail = new BasicDetails()
            {
                Date = DateTime.Now.Date,
                CreditFacilityNumber="074/075/Branch Code/001(002,A)"
            };
            ViewBag.typeOfFacilities = facilityType.ToList();
            ViewBag.riskGrading = risk.ToList();
            return View(form);
        }
    }
}