using FinalFantasyTacticsPartyBuilder.Models;
using FinalFantasyTacticsPartyBuilder.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
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
            unit.JobName = Enum.GetName(typeof(Jobs), unit.JobID);
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

        public ActionResult GetJobOverviewPartial()
        {
            return PartialView("~/Views/Home/_JobOverviewPartial.cshtml");
        }

        public ActionResult GetJobSelectionPartial(string gender)
        {
            List<JobOverviewViewModel> viewModels;
            JobOverviewRangeViewModel rangeViewModel;

            using (FFTContext context = new FFTContext())
            {
                viewModels = context.Jobs.Where(m => gender == "Male" ? !m.IsFemaleOnly : !m.IsMaleOnly).Select(m => new JobOverviewViewModel
                {
                    JobID = m.JobID, 
                    FileName = (m.PspName.Contains("(") ? m.PspName.Remove(m.PspName.IndexOf("(")) : m.PspName).Replace(" ", ""),
                    DisplayName = m.PspName,
                    Gender = gender, 
                    HPMultiplier = m.HPMultiplier,
                    HPGrowthConstant = m.HPGrowthConstant,
                    HPGrowthConstantLabel = m.HPGrowthConstant,
                    MPMultiplier = m.MPMultiplier,
                    MPGrowthConstant = m.MPGrowthConstant,
                    MPGrowthConstantLabel = m.MPGrowthConstant, 
                    SpeedMulitplier = m.SpeedMulitplier,
                    SpeedGrowthConstant = m.SpeedGrowthConstant,
                    SpeedGrowthConstantLabel = m.SpeedGrowthConstant,
                    PhysicalAttackMultiplier = m.PhysicalAttackMultiplier,
                    PhysicalAttackGrowthConstant = m.PhysicalAttackGrowthConstant,
                    PhysicalAttackGrowthConstantLabel = m.PhysicalAttackGrowthConstant, 
                    MagicalAttackMultiplier = m.MagicalAttackMultiplier,
                    MagicalAttackGrowthConstant = m.MagicalAttackGrowthConstant,
                    MagicalAttackGrowthConstantLabel = m.MagicalAttackGrowthConstant,
                    BaseMoveLength = m.BaseMoveLength, 
                    BaseJumpHeight = m.BaseJumpHeight,
                    BaseCombatEvasion = m.BaseCombatEvasion        
                }).ToList();

                rangeViewModel = new JobOverviewRangeViewModel
                {
                    HPGrowthConstantMax = context.Jobs.Max(c => c.HPGrowthConstant),
                    HPGrowthConstantMin = context.Jobs.Min(c => c.HPGrowthConstant),
                    MPGrowthConstantMax = context.Jobs.Max(c => c.MPGrowthConstant),
                    MPGrowthConstantMin = context.Jobs.Min(c => c.MPGrowthConstant),
                    SpeedGrowthConstantMax = context.Jobs.Max(c => c.SpeedGrowthConstant),
                    SpeedGrowthConstantMin = context.Jobs.Min(c => c.SpeedGrowthConstant),
                    PhysicalAttackGrowthConstantMax = context.Jobs.Max(c => c.PhysicalAttackGrowthConstant),
                    PhysicalAttackGrowthConstantMin = context.Jobs.Min(c => c.PhysicalAttackGrowthConstant),
                    MagicalAttackGrowthConstantMax = context.Jobs.Max(c => c.MagicalAttackGrowthConstant),
                    MagicalAttackGrowthConstantMin = context.Jobs.Min(c => c.MagicalAttackGrowthConstant)
                };

                int commonDenominator = (new int[] { rangeViewModel.HPGrowthConstantMax, rangeViewModel.MPGrowthConstantMax, rangeViewModel.SpeedGrowthConstantMax,
                    rangeViewModel.PhysicalAttackGrowthConstantMax, rangeViewModel.MagicalAttackGrowthConstantMax}).Max();
                rangeViewModel.HPGrowthConstantMultiplier = (float)commonDenominator / (float)rangeViewModel.HPGrowthConstantMax;
                rangeViewModel.MPGrowthConstantMultiplier = (float)commonDenominator / (float)rangeViewModel.MPGrowthConstantMax;
                rangeViewModel.SpeedGrowthConstantMultiplier = (float)commonDenominator / (float)rangeViewModel.SpeedGrowthConstantMax;
                rangeViewModel.PhysicalAttackGrowthConstantMultiplier = (float)commonDenominator / (float)rangeViewModel.PhysicalAttackGrowthConstantMax;
                rangeViewModel.MagicalAttackGrowthConstantMultiplier = (float)commonDenominator / (float)rangeViewModel.MagicalAttackGrowthConstantMax;

                foreach (JobOverviewViewModel viewModel in viewModels)
                {
                    viewModel.HPGrowthConstant = (int)((rangeViewModel.HPGrowthConstantMax + rangeViewModel.HPGrowthConstantMin - viewModel.HPGrowthConstant) * 
                        rangeViewModel.HPGrowthConstantMultiplier);
                    viewModel.MPGrowthConstant = (int)((rangeViewModel.MPGrowthConstantMax + rangeViewModel.MPGrowthConstantMin - viewModel.MPGrowthConstant) * 
                        rangeViewModel.MPGrowthConstantMultiplier);
                    viewModel.SpeedGrowthConstant = (int)((rangeViewModel.SpeedGrowthConstantMax + rangeViewModel.SpeedGrowthConstantMin - viewModel.SpeedGrowthConstant) * 
                        rangeViewModel.SpeedGrowthConstantMultiplier);
                    viewModel.PhysicalAttackGrowthConstant = (int)((rangeViewModel.PhysicalAttackGrowthConstantMax + rangeViewModel.PhysicalAttackGrowthConstantMin - 
                        viewModel.PhysicalAttackGrowthConstant) * rangeViewModel.PhysicalAttackGrowthConstantMultiplier);
                    viewModel.MagicalAttackGrowthConstant = (int)((rangeViewModel.MagicalAttackGrowthConstantMax + rangeViewModel.MagicalAttackGrowthConstantMin - 
                        viewModel.MagicalAttackGrowthConstant) * rangeViewModel.MagicalAttackGrowthConstantMultiplier);

                }
            }

            return PartialView("~/Views/Home/_JobSelectionPartial.cshtml", viewModels);
        }

        //public ActionResult PopulateNewUnitData(int jobID)
        //{
            //UnitDetailsViewModel unit = new UnitDetailsViewModel
            //{

            //}

            //return Json.Json.
        //}

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