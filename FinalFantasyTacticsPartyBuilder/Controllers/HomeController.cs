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
        public const int UNIT_STAT_NORMALIZER = 1638400;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUnitPanelPartial(List<UnitPanelViewModel> units)
        {
            if (units != null)
            {
                int[] hpMultipliers = new int[units.Count];
                int[] mpMultipliers = new int[units.Count];

                using (FFTContext context = new FFTContext())
                {
                    foreach (UnitPanelViewModel item in units)
                    {
                        item.JobName = item.JobName.Contains("Onion") ? "OnionKnight" : item.JobName;
                        item.HpDigits = ((context.Jobs.Single(m => m.JobID == item.JobID).HPMultiplier * item.RawHP) / 1638400).ToString().ToCharArray();
                        item.MpDigits = ((context.Jobs.Single(m => m.JobID == item.JobID).MPMultiplier * item.RawMP) / 1638400).ToString().ToCharArray();
                    }
                }

                return PartialView("~/Views/Home/_UnitOverviewPanelPartial.cshtml", units);
            }

            return PartialView("~/Views/Home/_UnitOverviewPanelPartial.cshtml");
        }

        public ActionResult GetUnitOverviewPartial(UnitOverviewViewModel unit)
        {
            unit.JobName = Enum.GetName(typeof(Jobs), unit.JobID);
            unit.JobPortraitPath = String.Format("/Content/Images/Jobs/{0}_{1}_Portrait.png", unit.JobName.Contains("Onion") ? "OnionKnight" : unit.JobName, unit.GenderName);
            unit.JobName = string.Concat(unit.JobName.Select(m => Char.IsUpper(m) ? " " + m : m.ToString())).Trim();
            unit.GenderName = Enum.GetName(typeof(Gender), unit.Gender);

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

        public ActionResult GetUnitDismissPartial(UnitDismissViewModel unit)
        {
            using (FFTContext context = new FFTContext())
            {
                unit.Quote = context.Quotes.OrderBy(m => Guid.NewGuid()).FirstOrDefault(m => m.Gender == unit.Gender).Text;
            }

            unit.JobName = unit.JobName.Contains("Onion") ? "OnionKnight" : unit.JobName;

            return PartialView("~/Views/Home/_UnitDismissPartial.cshtml", unit);
        }

        public ActionResult GetUnitStatsDetailPartial(UnitDetailsViewModel unit)
        {
            Item weaponItem1 = null, weaponItem2 = null, headItem = null, bodyItem = null, accessoryItem = null;

            unit.Unit.JobName = Enum.GetName(typeof(Jobs), unit.Unit.JobID);
            unit.Unit.JobPortraitPath = String.Format("/Content/Images/Jobs/{0}_{1}_Portrait.png", unit.Unit.JobName.Contains("Onion") ? "OnionKnight" : unit.Unit.JobName, unit.Unit.GenderName);
            unit.Unit.JobName = string.Concat(unit.Unit.JobName.Select(m => Char.IsUpper(m) ? " " + m : m.ToString())).Trim();
            unit.Unit.GenderName = Enum.GetName(typeof(Gender), unit.Unit.Gender);

            unit.Unit.AttributeDigits = new UnitOverviewHpMpViewModel
            {
                HpDigits = unit.Unit.MaxHP.ToString().ToCharArray(),
                MpDigits = unit.Unit.MaxMP.ToString().ToCharArray(),
                ExperienceDigits = unit.Unit.Experience < 10 ? ("0" + unit.Unit.Experience.ToString()).ToCharArray() : unit.Unit.Experience.ToString().ToCharArray(),
                LevelDigits = unit.Unit.Level < 10 ? ("0" + unit.Unit.Level.ToString()).ToCharArray() : unit.Unit.Level.ToString().ToCharArray(),
                PositionDigits = unit.Unit.Position < 10 ? ("0" + unit.Unit.Position.ToString()).ToCharArray() : unit.Unit.Position.ToString().ToCharArray()
            };

            using (FFTContext context = new FFTContext())
            {
                if (unit.WeaponID != default(int))
                {
                    weaponItem1 = context.Items.Single(m => m.ItemID == unit.WeaponID);
                    unit.WeaponRight = new ItemOverviewViewModel
                    {
                        WeaponPower = weaponItem1.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? weaponItem1.AttackPower.Value.ToString("D3") : "000",
                        WeaponHit = weaponItem1.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? weaponItem1.HitPercentage.Value.ToString("D3") : "000",
                        ShieldPhysicalEvade = weaponItem1.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield ? weaponItem1.PhysicalEvade.Value.ToString("D2") : "00",
                        ShieldMagicalEvade = weaponItem1.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield ? weaponItem1.MagicalEvade.Value.ToString("D2") : "00",
                        PhysicalAttackPower = weaponItem1.PhysicalAttackBoost.HasValue ? weaponItem1.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        MagicalAttackPower = weaponItem1.PhysicalAttackBoost.HasValue ? weaponItem1.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        ImagePath = weaponItem1.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? @"/Content/Images/Item_Icons/Weapons/" +
                        weaponItem1.IconFileName : @"/Content/Images/Item_Icons/Armour/" + weaponItem1.IconFileName,
                        Name = weaponItem1.PspName,
                    };
                }

                if (unit.ShieldID != default(int))
                {
                    weaponItem2 = context.Items.FirstOrDefault(m => m.ItemID == unit.ShieldID);
                    unit.WeaponLeft = new ItemOverviewViewModel
                    {
                        WeaponPower = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? weaponItem2.AttackPower.Value.ToString("D3") : "000" : "000",
                        WeaponHit = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? weaponItem2.HitPercentage.Value.ToString("D3") : "000" : "000",
                        ShieldPhysicalEvade = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield ? weaponItem2.PhysicalEvade.Value.ToString("D3") : "00" : "00",
                        ShieldMagicalEvade = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield ? weaponItem2.MagicalEvade.Value.ToString("D3") : "00" : "00",
                        PhysicalAttackPower = weaponItem2 != null ? weaponItem2.PhysicalAttackBoost.HasValue ? weaponItem2.PhysicalAttackBoost.Value.ToString("D2") : "00" : "00",
                        MagicalAttackPower = weaponItem2 != null ? weaponItem2.PhysicalAttackBoost.HasValue ? weaponItem2.PhysicalAttackBoost.Value.ToString("D2") : "00" : "00",
                        ImagePath = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? @"/Content/Images/Item_Icons/Weapons/" +
                        weaponItem2.IconFileName : @"/Content/Images/Item_Icons/Armour/" + weaponItem2.IconFileName : "",
                        Name = weaponItem2 != null ? weaponItem2.PspName : "",
                    };
                }

                if (unit.HeadID != default(int))
                {
                    headItem = context.Items.Single(m => m.ItemID == unit.HeadID);
                    unit.Head = new ItemOverviewViewModel
                    {
                        HPBonus = headItem.HPBonus.HasValue ? headItem.HPBonus.Value : 0,
                        MPBonus = headItem.MPBonus.HasValue ? headItem.MPBonus.Value : 0,
                        PhysicalAttackPower = headItem.PhysicalAttackBoost.HasValue ? headItem.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        MagicalAttackPower = headItem.PhysicalAttackBoost.HasValue ? headItem.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        SpeedBonus = headItem.SpeedBoost.HasValue ? headItem.SpeedBoost.Value : 0,
                        ImagePath = @"/Content/Images/Item_Icons/Armour/" + headItem.IconFileName,
                        Name = headItem.PspName,
                    };
                }

                if (unit.BodyID != default(int))
                {
                    bodyItem = context.Items.Single(m => m.ItemID == unit.BodyID);
                    unit.Body = new ItemOverviewViewModel
                    {
                        HPBonus = bodyItem.HPBonus.HasValue ? bodyItem.HPBonus.Value : 0,
                        MPBonus = bodyItem.MPBonus.HasValue ? bodyItem.MPBonus.Value : 0,
                        PhysicalAttackPower = bodyItem.PhysicalAttackBoost.HasValue ? bodyItem.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        MagicalAttackPower = bodyItem.PhysicalAttackBoost.HasValue ? bodyItem.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        SpeedBonus = bodyItem.SpeedBoost.HasValue ? bodyItem.SpeedBoost.Value : 0,
                        ImagePath = @"/Content/Images/Item_Icons/Armour/" + context.Items.Single(m => m.ItemID == unit.BodyID).IconFileName,
                        Name = context.Items.Single(m => m.ItemID == unit.BodyID).PspName,
                    };
                }

                if (unit.AccessoryID != default(int))
                {
                    accessoryItem = context.Items.Single(m => m.ItemID == unit.AccessoryID);
                    unit.Accessory = new ItemOverviewViewModel
                    {
                        MoveBonus = accessoryItem.MoveBoost.HasValue ? accessoryItem.MoveBoost.Value : 0,
                        JumpBonus = accessoryItem.JumpBoost.HasValue ? accessoryItem.JumpBoost.Value : 0,
                        SpeedBonus = accessoryItem.SpeedBoost.HasValue ? accessoryItem.SpeedBoost.Value : 0,
                        AccessoryPhysicalEvade = accessoryItem.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Accessory ? accessoryItem.PhysicalEvade.HasValue ?
                        accessoryItem.PhysicalEvade.Value.ToString("D3") : "00" : "00",
                        AccessoryMagicalEvade = accessoryItem.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Accessory ? accessoryItem.MagicalEvade.HasValue ?
                        accessoryItem.MagicalEvade.Value.ToString("D3") : "00" : "00",
                        ImagePath = @"~/Content/Images/Item_Icons/Armour/" + context.Items.Single(m => m.ItemID == unit.AccessoryID).IconFileName,
                        Name = context.Items.Single(m => m.ItemID == unit.AccessoryID).PspName,
                    };
                }

                Job unitJob = context.Jobs.Single(m => m.JobID == unit.Unit.JobID);

                unit.Move = (unitJob.BaseMoveLength + (unit.Accessory != null ? unit.Accessory.MoveBonus : 0)).ToString();
                unit.Jump = (unitJob.BaseJumpHeight + (unit.Accessory != null ? unit.Accessory.JumpBonus : 0)).ToString();
                unit.Speed = ((unitJob.SpeedMulitplier * unit.RawSpeed) / UNIT_STAT_NORMALIZER).ToString();
                unit.PhysicalAttackPower = ((unitJob.PhysicalAttackMultiplier * unit.RawPhysicalAttack) / UNIT_STAT_NORMALIZER) + (weaponItem1 != null ? weaponItem1.PhysicalAttackBoost.HasValue ? 
                    weaponItem1.PhysicalAttackBoost.Value : 0 : 0) + (weaponItem2 != null ? weaponItem2.PhysicalAttackBoost.HasValue ? weaponItem2.PhysicalAttackBoost.Value : 0 : 0) + 
                    (headItem != null ? headItem.PhysicalAttackBoost.HasValue ? headItem.PhysicalAttackBoost.Value : 0 : 0) + (bodyItem != null ? bodyItem.PhysicalAttackBoost.HasValue ? bodyItem.PhysicalAttackBoost.Value : 0 : 0) + 
                    (accessoryItem != null ? accessoryItem.PhysicalAttackBoost.HasValue ? accessoryItem.PhysicalAttackBoost.Value : 0 : 0);
                unit.MagicalAttackPower = ((unitJob.MagicalAttackMultiplier * unit.RawMagicalAttack) / UNIT_STAT_NORMALIZER) + (weaponItem1 != null ? weaponItem1.MagicAttackBoost.HasValue ?
                    weaponItem1.MagicAttackBoost.Value : 0 : 0) + (weaponItem2 != null ? weaponItem2.MagicAttackBoost.HasValue ? weaponItem2.MagicAttackBoost.Value : 0 : 0) +
                    (headItem != null ? headItem.MagicAttackBoost.HasValue ? headItem.MagicAttackBoost.Value : 0 : 0) + (bodyItem != null ? bodyItem.MagicAttackBoost.HasValue ? bodyItem.MagicAttackBoost.Value : 0 : 0) +
                    (accessoryItem != null ? accessoryItem.MagicAttackBoost.HasValue ? accessoryItem.MagicAttackBoost.Value : 0 : 0);
            }

            return PartialView("~/Views/Home/_UnitStatDetailsPartial.cshtml", unit);
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
                    GenderID = gender == "Male" ? 0 : 1,
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

        public ActionResult PopulateNewUnitData(int jobID, int gender, int position)
        {
            UnitDetailsViewModel unit;
            Random r = new Random();

            using (FFTContext context = new FFTContext())
            {
                unit = new UnitDetailsViewModel
                {
                    Unit = new UnitOverviewViewModel
                    {
                        MaxHP = context.Jobs.Single(m => m.JobID == jobID).HPMultiplier,
                        MaxMP = context.Jobs.Single(m => m.JobID == jobID).MPMultiplier,
                        UnitName = context.UnitNames.Where(m => m.Gender == gender).OrderBy(m => Guid.NewGuid()).First().Name
                    }
                };

                unit.Unit.JobID = jobID;
                unit.Unit.JobName = Enum.GetName(typeof(Jobs), jobID);
                unit.Unit.Gender = gender;
                unit.Unit.GenderName = Enum.GetName(typeof(Gender), gender);
                unit.Unit.Position = position;
                unit.Unit.Level = 1;
                unit.Unit.Experience = r.Next(0, 99);
                unit.Unit.Brave = r.Next(40, 70);
                unit.Unit.Faith = r.Next(40, 70);
                unit.RawHP = gender == 0 ? r.Next(491520, 524287) : gender == 1 ? r.Next(458752, 491519) : r.Next(573440, 622591);
                unit.RawMP = gender == 0 ? r.Next(229376, 245759) : gender == 1 ? r.Next(245760, 262143) : r.Next(98304, 147455);
                unit.RawPhysicalAttack = gender == 0 ? 81920 : gender == 1 ? 65536 : r.Next(81920, 98303);
                unit.RawMagicalAttack = gender == 0 ? 65536 : gender == 1 ? 81920 : r.Next(81920, 98303);
                unit.RawSpeed = gender == 0 ? 98304 : gender == 1 ? 98304 : 81920;
                unit.Unit.MaxHP = (unit.Unit.MaxHP * unit.RawHP) / 1638400;
                unit.Unit.MaxMP = (unit.Unit.MaxMP * unit.RawMP) / 1638400;

                unit.WeaponID = context.JobItems.FirstOrDefault(c => c.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield && c.JobID == unit.Unit.JobID) != null ? 
                    context.Items.OrderBy(c => c.AttackPower).FirstOrDefault(c => c.ItemCategoryID == context.JobItems.FirstOrDefault(m => m.JobID == unit.Unit.JobID &&
                m.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon).ItemCategoryID).ItemID : 0;
                unit.ShieldID = context.JobItems.FirstOrDefault(c => c.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield && c.JobID == unit.Unit.JobID) != null ?
                    context.Items.OrderBy(c => c.PhysicalEvade).FirstOrDefault(c => c.ItemCategoryID == context.JobItems.FirstOrDefault(m => m.JobID == unit.Unit.JobID &&
                    m.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield).ItemCategoryID).ItemID : 0;
                unit.HeadID = context.JobItems.FirstOrDefault(c => c.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield && c.JobID == unit.Unit.JobID) != null ?
                    context.Items.OrderBy(c => c.HPBonus).FirstOrDefault(c => c.ItemCategoryID == context.JobItems.FirstOrDefault(m => m.JobID == unit.Unit.JobID &&
                m.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Helmet).ItemCategoryID).ItemID : 0;
                unit.BodyID = context.JobItems.FirstOrDefault(c => c.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield && c.JobID == unit.Unit.JobID) != null ? 
                    context.Items.OrderBy(c => c.HPBonus).FirstOrDefault(c => c.ItemCategoryID == context.JobItems.FirstOrDefault(m => m.JobID == unit.Unit.JobID &&
                m.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Armor).ItemCategoryID).ItemID : 0;
            }

            return Json(unit);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}