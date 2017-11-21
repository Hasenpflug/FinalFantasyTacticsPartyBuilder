using FinalFantasyTacticsPartyBuilder.Models;
using FinalFantasyTacticsPartyBuilder.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalFantasyTacticsPartyBuilder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUnitPanelPartial(List<UnitOverviewHpMpViewModel> units)
        {
            return PartialView("~/Views/Home/_UnitOverviewPanelPartial.cshtml", units);
        }

        public ActionResult GetUnitOverviewPartial(UnitOverviewViewModel unit)
        {
            return PartialView("~/Views/Home/_UnitOverviewStatusPartial.cshtml", unit);
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Item()
        {
            return View();
        }

        public ActionResult Status()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}