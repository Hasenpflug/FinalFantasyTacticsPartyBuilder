using FinalFantasyTacticsPartyBuilder.Models;
using FinalFantasyTacticsPartyBuilder.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public ActionResult GetUnitPanelPartial(List<UnitOverviewViewModel> units)
        {
            foreach (UnitOverviewViewModel unit in units)
            {
                unit.AttributeDigits = new UnitOverviewHpMpViewModel
                {
                    HpDigits = unit.MaxHP.ToString().ToCharArray(),
                    MpDigits = unit.MaxMP.ToString().ToCharArray()
                };
            }

            return PartialView("~/Views/Home/_UnitOverviewPanelPartial.cshtml", units);
        }

        public ActionResult GetUnitOverviewPartial(UnitOverviewViewModel unit)
        {
            unit.JobName = Enum.GetName(typeof(Jobs), unit.Job);
            unit.GenderName = Enum.GetName(typeof(Gender), unit.Gender);
            unit.JobPortraitPath = String.Format("/Content/Images/Jobs/{0}_{1}_Portrait.png", unit.JobName, unit.GenderName);

            unit.AttributeDigits = new UnitOverviewHpMpViewModel
            {
                HpDigits = unit.MaxHP.ToString().ToCharArray(),
                MpDigits = unit.MaxMP.ToString().ToCharArray(),
                ExperienceDigits = unit.Experience < 10 ? ("0" + unit.Experience.ToString()).ToCharArray() : unit.Experience.ToString().ToCharArray(),
                LevelDigits = unit.Level < 10 ? ("0" + unit.Level.ToString()).ToCharArray() : unit.Level.ToString().ToCharArray(),
                PositionDigits = unit.Position < 10 ? ("0" + unit.Position.ToString()).ToCharArray() : unit.Position.ToString().ToCharArray()
            };

            return PartialView("~/Views/Home/_UnitOverviewStatusPartial.cshtml", unit);
        }

        public ActionResult GetUnitMenuPartial(string unitPositionID)
        {
            return PartialView("~/Views/Home/_UnitOverviewMenuPartial.cshtml", unitPositionID);
        }

        public ActionResult GetJobOverviewPartial(string gender)
        {
            List<JobOverviewViewModel> viewModels;

            using (FFTContext context = new FFTContext())
            {
                viewModels = context.Jobs.Where(m => gender == "Male" ? !m.IsFemaleOnly : !m.IsMaleOnly).Select(m => new JobOverviewViewModel
                {
                    JobID = m.JobID, 
                    Name = (m.PspName.Contains("(") ? m.PspName.Remove(m.PspName.IndexOf("(")) : m.PspName).Replace(" ", ""),
                    Gender = gender, 
                    HPMultiplier = m.HPMultiplier, 
                    HPGrowthConstant = m.HPGrowthConstant, 
                    MPMultiplier = m.MPMultiplier, 
                    MPGrowthConstant = m.MPGrowthConstant, 
                    SpeedMulitplier = m.SpeedMulitplier, 
                    SpeedGrowthConstant = m.SpeedGrowthConstant,
                    PhysicalAttackMultiplier = m.PhysicalAttackMultiplier, 
                    PhysicalAttackGrowthConstant = m.PhysicalAttackGrowthConstant, 
                    MagicalAttackMultiplier = m.MagicalAttackMultiplier,
                    MagicalAttackGrowthConstant = m.MagicalAttackGrowthConstant,
                    BaseMoveLength = m.BaseMoveLength, 
                    BaseJumpHeight = m.BaseJumpHeight,
                    BaseCombatEvasion = m.BaseCombatEvasion        
                }).ToList();
            }

            return PartialView("~/Views/Home/_JobOverviewPartial.cshtml", viewModels);
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