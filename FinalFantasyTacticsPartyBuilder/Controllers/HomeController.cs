﻿using FinalFantasyTacticsPartyBuilder.Models;
using FinalFantasyTacticsPartyBuilder.Services;
using FinalFantasyTacticsPartyBuilder.View_Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult GetUnitPanelPartial(List<UnitPanelViewModel> units)
        {
            if (units != null)
            {
                foreach (UnitPanelViewModel unit in units)
                {
                    unit.JobName = Enum.GetName(typeof(Jobs), unit.JobID);
                    unit.JobName = unit.JobName.Contains("Onion") ? "OnionKnight" : unit.JobName;
                    unit.HpDigits = unit.MaxHP.ToString().ToCharArray();
                    unit.MpDigits = unit.MaxMP.ToString().ToCharArray();
                }
            }

            return PartialView("~/Views/Home/_UnitOverviewPanelPartial.cshtml", units);
        }

        public ActionResult GetUnitOverviewPartial(UnitOverviewViewModel unit)
        {
            unit.JobName = Enum.GetName(typeof(Jobs), unit.JobID);
            unit.JobName = unit.JobName.Contains("Onion") ? "Onion Knight" : unit.JobName;
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

            unit.JobName = Enum.GetName(typeof(Jobs), unit.JobID);
            unit.JobName = unit.JobName.Contains("Onion") ? "Onion Knight" : unit.JobName;

            return PartialView("~/Views/Home/_UnitDismissPartial.cshtml", unit);
        }

        public JsonResult GetUnitStatsDetailPartial(UnitDetailsViewModel unit, int? itemID = null)
        {
            Item weaponItem1 = null, weaponItem2 = null, headItem = null, bodyItem = null, accessoryItem = null;
            List<Item> items = new List<Item>();

            unit.Unit.JobName = Enum.GetName(typeof(Jobs), unit.Unit.JobID);
            unit.Unit.JobName = unit.Unit.JobName.Contains("Onion") ? "Onion Knight" : unit.Unit.JobName;
            unit.Unit.JobPortraitPath = String.Format("/Content/Images/Jobs/{0}_{1}_Portrait.png", unit.Unit.JobName.Contains("Onion") ? "OnionKnight" : unit.Unit.JobName, unit.Unit.GenderName);
            unit.Unit.JobName = string.Concat(unit.Unit.JobName.Select(m => Char.IsUpper(m) ? " " + m : m.ToString())).Trim();
            unit.Unit.GenderName = Enum.GetName(typeof(Gender), unit.Unit.Gender);

            using (FFTContext context = new FFTContext())
            {
                if (itemID != null)
                {
                    int categoryListLength = Enum.GetNames(typeof(EquipmentCategoriesList)).Length;
                    Item selectedItem = context.Items.Single(m => m.ItemID == itemID);

                    switch ((EquipmentCategoriesList)selectedItem.ItemCategory.EquipmentCategoryID)
                    {
                        case EquipmentCategoriesList.Weapon:
                            unit.WeaponID = selectedItem.ItemID;
                            break;
                        case EquipmentCategoriesList.Shield:
                            unit.ShieldID = selectedItem.ItemID;
                            break;
                        case EquipmentCategoriesList.Helmet:
                            unit.HeadID = selectedItem.ItemID;
                            break;
                        case EquipmentCategoriesList.Armor:
                            unit.BodyID = selectedItem.ItemID;
                            break;
                        case EquipmentCategoriesList.Accessory:
                            unit.AccessoryID = selectedItem.ItemID;
                            break;
                    }
                }

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
                        MagicalAttackPower = weaponItem1.MagicAttackBoost.HasValue ? weaponItem1.MagicAttackBoost.Value.ToString("D2") : "00",
                        ImagePath = weaponItem1.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? @"/Content/Images/Item_Icons/Weapons/" +
                        weaponItem1.IconFileName : @"/Content/Images/Item_Icons/Armour/" + weaponItem1.IconFileName,
                        Name = weaponItem1.PspName,
                    };

                    items.Add(weaponItem1);
                }

                if (unit.ShieldID != default(int) && !weaponItem1.ItemCategory.IsTwoHandOnly)
                {
                    weaponItem2 = context.Items.FirstOrDefault(m => m.ItemID == unit.ShieldID);
                    unit.WeaponLeft = new ItemOverviewViewModel
                    {
                        WeaponPower = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ?
                            weaponItem2.AttackPower.HasValue ? weaponItem2.AttackPower.Value.ToString("D3") : "000" : "000" : "000",
                        WeaponHit = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ?
                            weaponItem2.HitPercentage.HasValue ? weaponItem2.HitPercentage.Value.ToString("D3") : "000" : "000" : "000",
                        ShieldPhysicalEvade = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield ?
                            weaponItem2.PhysicalEvade.HasValue ? weaponItem2.PhysicalEvade.Value.ToString("D3") : "00" : "00" : "00",
                        ShieldMagicalEvade = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield ?
                            weaponItem2.MagicalEvade.HasValue ? weaponItem2.MagicalEvade.Value.ToString("D3") : "00" : "00" : "00",
                        PhysicalAttackPower = weaponItem2 != null ? weaponItem2.PhysicalAttackBoost.HasValue ? weaponItem2.PhysicalAttackBoost.Value.ToString("D2") : "00" : "00",
                        MagicalAttackPower = weaponItem2 != null ? weaponItem2.MagicAttackBoost.HasValue ? weaponItem2.MagicAttackBoost.Value.ToString("D2") : "00" : "00",
                        ImagePath = weaponItem2 != null ? weaponItem2.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? @"/Content/Images/Item_Icons/Weapons/" +
                        weaponItem2.IconFileName : @"/Content/Images/Item_Icons/Armour/" + weaponItem2.IconFileName : "",
                        Name = weaponItem2 != null ? weaponItem2.PspName : "",
                    };

                    items.Add(weaponItem2);
                }

                if (unit.HeadID != default(int))
                {
                    headItem = context.Items.Single(m => m.ItemID == unit.HeadID);
                    unit.Head = new ItemOverviewViewModel
                    {
                        HPBonus = headItem.HPBonus ?? 0,
                        MPBonus = headItem.MPBonus ?? 0,
                        PhysicalAttackPower = headItem.PhysicalAttackBoost.HasValue ? headItem.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        MagicalAttackPower = headItem.MagicAttackBoost.HasValue ? headItem.MagicAttackBoost.Value.ToString("D2") : "00",
                        SpeedBonus = headItem.SpeedBoost ?? 0,
                        ImagePath = @"/Content/Images/Item_Icons/Armour/" + headItem.IconFileName,
                        Name = headItem.PspName,
                    };

                    items.Add(headItem);
                }

                if (unit.BodyID != default(int))
                {
                    bodyItem = context.Items.Single(m => m.ItemID == unit.BodyID);
                    unit.Body = new ItemOverviewViewModel
                    {
                        HPBonus = bodyItem.HPBonus ?? 0,
                        MPBonus = bodyItem.MPBonus ?? 0,
                        PhysicalAttackPower = bodyItem.PhysicalAttackBoost.HasValue ? bodyItem.PhysicalAttackBoost.Value.ToString("D2") : "00",
                        MagicalAttackPower = bodyItem.MagicAttackBoost.HasValue ? bodyItem.MagicAttackBoost.Value.ToString("D2") : "00",
                        SpeedBonus = bodyItem.SpeedBoost ?? 0,
                        ImagePath = @"/Content/Images/Item_Icons/Armour/" + context.Items.Single(m => m.ItemID == unit.BodyID).IconFileName,
                        Name = context.Items.Single(m => m.ItemID == unit.BodyID).PspName,
                    };

                    items.Add(bodyItem);
                }

                if (unit.AccessoryID != default(int))
                {
                    accessoryItem = context.Items.Single(m => m.ItemID == unit.AccessoryID);
                    unit.Accessory = new ItemOverviewViewModel
                    {
                        ItemCategoryID = accessoryItem.ItemCategoryID,
                        MoveBonus = accessoryItem.MoveBoost ?? 0,
                        JumpBonus = accessoryItem.JumpBoost ?? 0,
                        SpeedBonus = accessoryItem.SpeedBoost ?? 0,
                        PhysicalAttackPower = accessoryItem.PhysicalAttackBoost.HasValue ? accessoryItem.PhysicalAttackBoost.Value.ToString() : "00",
                        MagicalAttackPower = accessoryItem.MagicAttackBoost.HasValue ? accessoryItem.MagicAttackBoost.Value.ToString() : "00",
                        AccessoryPhysicalEvade = accessoryItem.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Accessory ? accessoryItem.PhysicalEvade.HasValue ?
                            accessoryItem.PhysicalEvade.Value.ToString("D3") : "00" : "00",
                        AccessoryMagicalEvade = accessoryItem.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Accessory ? accessoryItem.MagicalEvade.HasValue ?
                            accessoryItem.MagicalEvade.Value.ToString("D3") : "00" : "00",
                        ImagePath = @"/Content/Images/Item_Icons/Accessories/" + context.Items.Single(m => m.ItemID == unit.AccessoryID).IconFileName,
                        Name = context.Items.Single(m => m.ItemID == unit.AccessoryID).PspName,
                    };

                    items.Add(accessoryItem);
                }

                Job unitJob = context.Jobs.Single(m => m.JobID == unit.Unit.JobID);
                unit = AttributeCalculator.CalculateHPAndMP(headItem, bodyItem, unit, unitJob);
                unit = AttributeCalculator.CalculateBasicStats(weaponItem1, weaponItem2, headItem, bodyItem, accessoryItem, unit, unitJob);
                unit = AttributeCalculator.CalculateEvasionStats(weaponItem2, accessoryItem, unitJob, unit);
                unit.PrimaryAbilityJobID = unitJob.JobID;
                unit.PrimaryAbilityName = unitJob.AbilitySetPspName;
            }

            unit.Unit.AttributeDigits = new UnitOverviewHpMpViewModel
            {
                HpDigits = unit.Unit.MaxHP.ToString().ToCharArray(),
                MpDigits = unit.Unit.MaxMP.ToString().ToCharArray(),
                ExperienceDigits = unit.Unit.Experience < 10 ? ("0" + unit.Unit.Experience.ToString()).ToCharArray() : unit.Unit.Experience.ToString().ToCharArray(),
                LevelDigits = unit.Unit.Level < 10 ? ("0" + unit.Unit.Level.ToString()).ToCharArray() : unit.Unit.Level.ToString().ToCharArray(),
                PositionDigits = unit.Unit.Position < 10 ? ("0" + unit.Unit.Position.ToString()).ToCharArray() : unit.Unit.Position.ToString().ToCharArray()
            };

            unit = AttributeCalculator.CalculateResistancesAndImmunities(items, unit);
            return Json(new { View = RenderPartialViewToString("~/Views/Home/_UnitStatDetailsPartial.cshtml", unit), Data = unit });
        }

        public ActionResult GetUnitItemLookupPartial(int jobID, int equipmentCategoryID, bool isFemale)
        {
            List<UnitItemLookupViewModel> items = new List<UnitItemLookupViewModel>();

            using (FFTContext context = new FFTContext())
            {
                if (equipmentCategoryID != (int)EquipmentCategoriesList.Accessory)
                {
                    Job unitJob = context.Jobs.Single(m => m.JobID == jobID);

                    items.AddRange(unitJob.JobItems.Where(m => m.ItemCategory.EquipmentCategoryID == equipmentCategoryID).Select(m => new UnitItemLookupViewModel
                    {
                        ItemCategoryID = m.ItemCategoryID,
                        ItemCategoryName = m.ItemCategory.ItemCategoryName,
                        StartingItemImagePath = m.ItemCategory.StartingItemImagePath
                    }));
                }
                else
                {
                    items.AddRange(context.ItemCategories.Where(m => m.EquipmentCategoryID == equipmentCategoryID && (!isFemale ? m.IsFemaleOnly == false : true)).Select(m => new UnitItemLookupViewModel
                    {
                        ItemCategoryID = m.ItemCategoryID,
                        ItemCategoryName = m.ItemCategoryName,
                        StartingItemImagePath = m.StartingItemImagePath
                    }));
                }
            }

            return PartialView("~/Views/Home/_UnitItemLookupPartial.cshtml", items);
        }

        public ActionResult GetItemSelectionPartial(int itemCategoryID)
        {
            List<ItemOverviewViewModel> items = new List<ItemOverviewViewModel>();

            using (FFTContext context = new FFTContext())
            {
                items.AddRange(context.Items.Where(m => m.ItemCategoryID == itemCategoryID).Select(c => new ItemOverviewViewModel
                {
                    ItemID = c.ItemID,
                    EquipmentCategoryID = c.ItemCategory.EquipmentCategoryID,
                    EquipmentCategoryName = c.ItemCategory.EquipmentCategoryName.ToLower(),
                    ItemCategoryID = itemCategoryID,
                    AccessoryMagicalEvade = (c.ItemCategoryID == (int)ItemCategoriesList.Cloak ? c.MagicalEvade ?? 0 : 0).ToString(),
                    AccessoryPhysicalEvade = (c.ItemCategoryID == (int)ItemCategoriesList.Cloak ? c.PhysicalEvade ?? 0 : 0).ToString(),
                    HPBonus = (c.HPBonus ?? 0),
                    MPBonus = (c.MPBonus ?? 0),
                    MoveBonus = (c.MoveBoost ?? 0),
                    JumpBonus = (c.JumpBoost ?? 0),
                    SpeedBonus = (c.SpeedBoost ?? 0),
                    ShieldPhysicalEvade = (c.ItemCategoryID == (int)ItemCategoriesList.Shield ? c.PhysicalEvade ?? 0 : 0).ToString(),
                    ShieldMagicalEvade = (c.ItemCategoryID == (int)ItemCategoriesList.Shield ? c.MagicalEvade ?? 0 : 0).ToString(),
                    PhysicalAttackPower = (c.PhysicalAttackBoost ?? 0).ToString(),
                    MagicalAttackPower = (c.MagicAttackBoost ?? 0).ToString(),
                    Name = c.PspName,
                    WeaponPower = (c.AttackPower ?? 0).ToString(),
                    WeaponHit = (c.HitPercentage ?? 0).ToString(),
                    ImagePath = (c.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? @"/Content/Images/Item_Icons/Weapons/" : c.ItemCategory.EquipmentCategoryID > (int)EquipmentCategoriesList.Weapon &&
                        c.ItemCategory.EquipmentCategoryID < (int)EquipmentCategoriesList.Accessory ? @"/Content/Images/Item_Icons/Armour/" : @"/Content/Images/Item_Icons/Accessories/") + c.IconFileName
                }));
            }

            if (items.Count > 0)
            {
                switch (items[0].EquipmentCategoryID)
                {
                    case (int)EquipmentCategoriesList.Weapon:
                        return PartialView("~/Views/Home/UnitItemSelectionPartials/_WeaponSelectionPartial.cshtml", items);
                    case (int)EquipmentCategoriesList.Shield:
                        return PartialView("~/Views/Home/UnitItemSelectionPartials/_ShieldSelectionPartial.cshtml", items);
                    case (int)EquipmentCategoriesList.Accessory:
                        switch (items[0].ItemCategoryID)
                        {
                            case (int)ItemCategoriesList.Shoe:
                                return PartialView("~/Views/Home/UnitItemSelectionPartials/_ShoeAccessorySelectionPartial.cshtml", items);
                            case (int)ItemCategoriesList.Cloak:
                                return PartialView("~/Views/Home/UnitItemSelectionPartials/_CloakAccessorySelectionPartial.cshtml", items);
                            case (int)ItemCategoriesList.Armguard:
                                return PartialView("~/Views/Home/UnitItemSelectionPartials/_ArmguardAccessorySelectionPartial.cshtml", items);
                            case (int)ItemCategoriesList.Ring:
                                return PartialView("~/Views/Home/UnitItemSelectionPartials/_RingAccessorySelectionPartial.cshtml", items);
                            case (int)ItemCategoriesList.Armlet:
                                return PartialView("~/Views/Home/UnitItemSelectionPartials/_RingAccessorySelectionPartial.cshtml", items);
                            default:
                                return PartialView("~/Views/Home/UnitItemSelectionPartials/_DefaultAccessorySelectionPartial.cshtml", items);

                        }
                    default:
                        return PartialView("~/Views/Home/UnitItemSelectionPartials/_HelmetBodySelectionPartial.cshtml", items);
                }
            }

            return null;
        }

        public ActionResult GetItemDetailsPartial(int itemID)
        {
            using (FFTContext context = new FFTContext())
            {
                Item item = context.Items.Single(m => m.ItemID == itemID);
                ItemDetailsViewModel itemDetails = new ItemDetailsViewModel
                {
                    ItemID = item.ItemID,
                    AcquiredViaCatch = item.AcquiredViaCatch,
                    AcquiredViaInitialEquip = item.AcquiredViaInitialEquip,
                    AcquiredViaLocation = item.AcquiredViaLocation,
                    AcquiredViaMode = item.AcquiredViaMode,
                    AcquiredViaPoach = item.AcquiredViaPoach,
                    AcquiredViaSteal = item.AcquiredViaSteal,
                    AcquiredViaTreasureHunt = item.AcquiredViaTreasureHunt,
                    AttackPower = item.AttackPower?.ToString("D3") ?? "0",
                    Cost = item.Cost,
                    Description = item.Description,
                    Element = AttributeCalculator.GetElementSVGLocations(item.Element),
                    ElementAbsorbed = AttributeCalculator.GetElementSVGLocations(item.ElementAbsorbed),
                    ElementBoosted = AttributeCalculator.GetElementSVGLocations(item.ElementBoosted),
                    ElementHalved = AttributeCalculator.GetElementSVGLocations(item.ElementHalved),
                    ElementNegated = AttributeCalculator.GetElementSVGLocations(item.ElementNegated),
                    ElementWeakness = AttributeCalculator.GetElementSVGLocations(item.ElementWeakness),
                    EquipStatusEffect = AttributeCalculator.GetEffectSVGLocations(item.EquipStatusEffect),
                    HitPercentage = item.HitPercentage?.ToString("D2") ?? "0",
                    HitStatusEffect = AttributeCalculator.GetEffectSVGLocations(item.HitStatusEffect),
                    HPBonus = item.HPBonus?.ToString() ?? "0",
                    ImagePath = (item.ItemCategory.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon ? @"/Content/Images/Item_Icons/Weapons/" : item.ItemCategory.EquipmentCategoryID > (int)EquipmentCategoriesList.Weapon &&
                        item.ItemCategory.EquipmentCategoryID < (int)EquipmentCategoriesList.Accessory ? @"/Content/Images/Item_Icons/Armour/" : @"/Content/Images/Item_Icons/Accessories/") + item.IconFileName,
                    ImmuneStatusEffect = AttributeCalculator.GetEffectSVGLocations(item.ImmuneStatusEffect),
                    JumpBoost = item.JumpBoost?.ToString() ?? "0",
                    MagicalEvade = item.MagicalEvade?.ToString() ?? "0",
                    MagicAttackBoost = item.MagicAttackBoost?.ToString() ?? "0",
                    MoveBoost = item.MoveBoost?.ToString() ?? "0",
                    MPBonus = item.MPBonus?.ToString() ?? "0",
                    Name = item.PspName,
                    PhysicalAttackBoost = item.PhysicalAttackBoost?.ToString() ?? "0",
                    PhysicalEvade = item.PhysicalEvade?.ToString() ?? "0",
                    RemoveStatusEffect = AttributeCalculator.GetEffectSVGLocations(item.RemoveStatusEffect),
                    SpeedBoost = item.SpeedBoost?.ToString() ?? "0",
                    SpellEffect = AttributeCalculator.GetEffectSVGLocations(item.SpellEffect),
                    ItemCategoryName = item.ItemCategory.ItemCategoryName
                };

                return PartialView("~/Views/Home/_UnitItemDetailsPartial.cshtml", itemDetails);
            }
        }

        public ActionResult GetJobOverviewPartial()
        {
            return PartialView("~/Views/Home/_JobOverviewPartial.cshtml");
        }

        public ActionResult GetJobTreePartial(string gender)
        {
            Dictionary<string, List<JobTreantNodeViewModel>> viewModels = new Dictionary<string, List<JobTreantNodeViewModel>>();
            using (FFTContext context = new FFTContext())
            {
                List<Job> jobs = context.Jobs.ToList();

                foreach (Job job in jobs)
                {
                    viewModels.Add(job.PspName, new List<JobTreantNodeViewModel>
                    {
                        new JobTreantNodeViewModel
                        {
                            RequiredGender = job.IsMaleOnly ? "Male" : job.IsFemaleOnly ? "Female" : "",
                            ImagePath = $"/Content/Images/Jobs/{(Enum.GetName(typeof(Jobs), job.JobID).Contains("Onion") ? "OnionKnight" : Enum.GetName(typeof(Jobs), job.JobID))}_" +
                            $"{(job.PspName.Contains("Dancer") ? "Female" : job.PspName.Contains("Bard") ? "Male" : gender)}_Standing.png",
                            JobName = job.PspName,
                            JobPrerequisiteNames = job.JobPrerequisites.Select(m => (m.JobLevelRequiredPsp > -1 ? $"Level {m.JobLevelRequiredPsp} " : "Mastered ") + $"{jobs.Single(c => c.JobID == m.JobRequiredID).PspName}").ToList()
                        }
                    });
                    if (job.JobPrerequisites.Count > 0)
                    {
                        viewModels.Add(job.PspName + "Pre", job.JobPrerequisites.Select(m => new JobTreantNodeViewModel
                        {
                            ImagePath = $"/Content/Images/Jobs/{(Enum.GetName(typeof(Jobs), m.JobRequiredID).Contains("Onion") ? "OnionKnight" : Enum.GetName(typeof(Jobs), m.JobRequiredID))}_{gender}_Standing.png",
                            JobName = jobs.Single(c => c.JobID == m.JobRequiredID).PspName,
                            RequiredJobLevelPath = m.JobLevelRequiredPsp > 0 ? $"/Content/Images/number_{m.JobLevelRequiredPsp}.png" : $"/Content/Images/star.png",
                            JobPrerequisiteNames = jobs.Single(c => m.JobRequiredID == c.JobID).JobPrerequisites.Select(x => $"Level {x.JobLevelRequiredPsp} {jobs.Single(v => v.JobID == x.JobRequiredID).PspName}").ToList()

                        }).ToList());
                    }
                }
            }

            return PartialView("~/Views/Home/_JobTreePartial.cshtml", viewModels);
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

        public string RenderPartialViewToString(string viewName, object model)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.RouteData.GetRequiredString("action");

            ViewData.Model = model;

            using (StringWriter sw = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);

                return sw.GetStringBuilder().ToString();
            }
        }

        public ActionResult PopulateNewUnitData(int jobID, int gender, int position)
        {
            UnitDetailsViewModel unit;
            Item weaponItem1 = null, weaponItem2 = null, headItem = null, bodyItem = null;
            Random r = new Random();

            using (FFTContext context = new FFTContext())
            {
                Job unitJob = context.Jobs.Single(m => m.JobID == jobID);

                unit = new UnitDetailsViewModel
                {
                    Unit = new UnitOverviewViewModel
                    {
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

                List<ItemCategoryDTO> jobItems = context.JobItems.Where(m => m.JobID == unit.Unit.JobID).Select(m => new ItemCategoryDTO
                {
                    EquipmentCategoryID = m.ItemCategory.EquipmentCategoryID,
                    ItemCategoryID = m.ItemCategoryID
                }).ToList();

                if (jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon))
                {
                    int randomWeaponID = jobItems.FirstOrDefault(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon).ItemCategoryID;
                    weaponItem1 = jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Weapon) ? context.Items.FirstOrDefault(m => m.ItemCategoryID ==
                    randomWeaponID && m.IsStartingItem) : null;
                    unit.WeaponID = weaponItem1 != null ? weaponItem1.ItemID : 0;
                    unit.ShieldID = jobID == (int)Jobs.Ninja ? unit.WeaponID : 0;
                }

                if (jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield))
                {
                    int randomShieldID = jobItems.FirstOrDefault(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield).ItemCategoryID;
                    weaponItem2 = jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Shield) ? context.Items.FirstOrDefault(m => m.ItemCategoryID ==
                    randomShieldID && m.IsStartingItem) : null;
                    unit.ShieldID = weaponItem2 != null ? weaponItem2.ItemID : 0;
                }

                if (jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Helmet))
                {
                    int randomHeadID = jobItems.FirstOrDefault(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Helmet).ItemCategoryID;
                    headItem = jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Helmet) ? context.Items.Where(c => c.ItemCategoryID == randomHeadID)
                        .FirstOrDefault(m => m.IsStartingItem) : null;
                    unit.HeadID = headItem != null ? headItem.ItemID : 0;
                }

                if (jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Armor))
                {
                    int randomBodyID = jobItems.FirstOrDefault(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Armor).ItemCategoryID;
                    bodyItem = jobItems.Any(m => m.EquipmentCategoryID == (int)EquipmentCategoriesList.Armor) ? context.Items.FirstOrDefault(m => m.ItemCategoryID ==
                    randomBodyID && m.IsStartingItem) : null;
                    unit.BodyID = bodyItem != null ? bodyItem.ItemID : 0;
                }

                unit.Resistances = new UnitResistAndImmunityViewModel();
                unit = AttributeCalculator.CalculateHPAndMP(headItem, bodyItem, unit, unitJob);
                unit = AttributeCalculator.CalculateBasicStats(weaponItem1, weaponItem2, headItem, bodyItem, null, unit, unitJob);
                unit = AttributeCalculator.CalculateEvasionStats(weaponItem2, null, unitJob, unit);
                unit = AttributeCalculator.CalculateResistancesAndImmunities(new List<Item> { weaponItem1, weaponItem2, headItem, bodyItem }, unit);
                unit.PrimaryAbilityJobID = unit.Unit.JobID;
                unit.PrimaryAbilityName = unitJob.AbilitySetPspName;
            }

            return Json(unit);
        }
    }
}