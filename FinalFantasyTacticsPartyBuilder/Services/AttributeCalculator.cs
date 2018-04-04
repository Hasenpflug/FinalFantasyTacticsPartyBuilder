using FinalFantasyTacticsPartyBuilder.Models;
using FinalFantasyTacticsPartyBuilder.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Services
{
    public static class AttributeCalculator
    {
        public const int UNIT_STAT_NORMALIZER = 1638400;

        public static UnitDetailsViewModel CalculateHPAndMP(Item headItem, Item bodyItem, UnitDetailsViewModel unit, Job job)
        {
            unit.Unit.MaxHP = ((job.HPMultiplier * unit.RawHP) / 1638400) + (headItem != null ? headItem.HPBonus ?? 0 : 0) + (bodyItem != null ?
                bodyItem.HPBonus ?? 0 : 0);
            unit.Unit.MaxMP = ((job.MPMultiplier * unit.RawMP) / 1638400) + (headItem != null ? headItem.MPBonus ?? 0 : 0) + (bodyItem != null ?
                bodyItem.MPBonus ?? 0 : 0);
            return unit;
        }

        public static UnitDetailsViewModel CalculateBasicStats(Item weaponItem1, Item weaponItem2, Item headItem, Item bodyItem, Item accessoryItem, UnitDetailsViewModel unit, Job job)
        {
            unit.Move = (job.BaseMoveLength + (unit.Accessory != null ? unit.Accessory.MoveBonus : 0)).ToString();
            unit.Jump = (job.BaseJumpHeight + (unit.Accessory != null ? unit.Accessory.JumpBonus : 0)).ToString();
            unit.Speed = ((job.SpeedMulitplier * unit.RawSpeed) / UNIT_STAT_NORMALIZER).ToString();
            unit.PhysicalAttackPower = (((job.PhysicalAttackMultiplier * unit.RawPhysicalAttack) / UNIT_STAT_NORMALIZER) + (weaponItem1 != null ? weaponItem1.PhysicalAttackBoost ?? 0 : 0) + (weaponItem2 != null ? weaponItem2.PhysicalAttackBoost ?? 0 : 0) +
                (headItem != null ? headItem.PhysicalAttackBoost ?? 0 : 0) + (bodyItem != null ? bodyItem.PhysicalAttackBoost ?? 0 : 0) + (accessoryItem != null ? accessoryItem.PhysicalAttackBoost ?? 0 : 0)).ToString("00");
            unit.MagicalAttackPower = (((job.MagicalAttackMultiplier * unit.RawMagicalAttack) / UNIT_STAT_NORMALIZER) + (weaponItem1 != null ? weaponItem1.MagicAttackBoost ?? 0 : 0) + (weaponItem2 != null ? weaponItem2.MagicAttackBoost ?? 0 : 0) +
                (headItem != null ? headItem.MagicAttackBoost ?? 0 : 0) + (bodyItem != null ? bodyItem.MagicAttackBoost ?? 0 : 0) +
                (accessoryItem != null ? accessoryItem.MagicAttackBoost ?? 0 : 0)).ToString("00");
            return unit;
        }

        public static UnitDetailsViewModel CalculateEvasionStats(Item shieldItem, Item accessoryItem, Job unitJob, UnitDetailsViewModel unit)
        {
            unit.PhysicalCharacterEvade = unitJob.BaseCombatEvasion.ToString("00");
            unit.MagicalCharacterEvade = unitJob.BaseCombatEvasion.ToString("00");
            unit.PhysicalShieldEvade = (shieldItem != null ? shieldItem.PhysicalEvade ?? 0 : 0).ToString("00");
            unit.MagicalShieldEvade = (shieldItem != null ? shieldItem.MagicalEvade ?? 0 : 0).ToString("00");
            unit.PhysicalAccessoryEvade = (accessoryItem != null ? accessoryItem.PhysicalEvade ?? 0 : 0).ToString("00");
            unit.MagicalAccessoryEvade = (accessoryItem != null ? accessoryItem.MagicalEvade ?? 0 : 0).ToString("00");
            return unit;
        }

        public static UnitDetailsViewModel CalculateReistancesAndImmunities(List<Item> characterItems, UnitDetailsViewModel unit)
        {
            foreach (Item item in characterItems)
            {
                unit.Resistances.FireResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Fire") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Fire") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Fire") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Fire") == true ? ResistLevel.Weak : 0];

                unit.Resistances.IceResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Ice") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Ice") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Ice") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Ice") == true ? ResistLevel.Weak : 0];

                unit.Resistances.LightningResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Lightning") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Lightning") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Lightning") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Lightning") == true ? ResistLevel.Weak : 0];

                unit.Resistances.WaterResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Water") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Water") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Water") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Water") == true ? ResistLevel.Weak : 0];

                unit.Resistances.WindResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Wind") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Wind") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Wind") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Wind") == true ? ResistLevel.Weak : 0];

                unit.Resistances.EarthResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Earth") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Earth") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Earth") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Earth") == true ? ResistLevel.Weak : 0];

                unit.Resistances.HolyResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Holy") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Holy") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Holy") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Holy") == true ? ResistLevel.Weak : 0];

                unit.Resistances.DarkResist = UnitResistAndImmunityViewModel.resistLevelDescriptions[item?.ElementAbsorbed?.Contains("Dark") == true ? ResistLevel.Absorbed : item?.ElementNegated?.Contains("Dark") == true ? ResistLevel.Negated :
                    item?.ElementHalved?.Contains("Dark") == true ? ResistLevel.Halved : item?.ElementWeakness?.Contains("Dark") == true ? ResistLevel.Weak : 0];

                unit.Resistances.PhysicalResist = "Normal";
                unit.Resistances.MagicalResist = "Normal";

                unit.Resistances.IsBerserkImmune = item?.ImmuneStatusEffect?.Contains("Berserk") == true ? true : false;
                unit.Resistances.IsBlindImmune = item?.ImmuneStatusEffect?.Contains("Blind") == true ? true : false;
                unit.Resistances.IsCharmImmune = item?.ImmuneStatusEffect?.Contains("Charm") == true ? true : false;
                unit.Resistances.IsConfusedImmune = item?.ImmuneStatusEffect?.Contains("Confused") == true ? true : false;
                unit.Resistances.IsDontActImmune = item?.ImmuneStatusEffect?.Contains("Disable") == true ? true : false;
                unit.Resistances.IsDontMoveImmune = item?.ImmuneStatusEffect?.Contains("Immobilize") == true ? true : false;
                unit.Resistances.IsDoomImmune = item?.ImmuneStatusEffect?.Contains("Doom") == true ? true : false;
                unit.Resistances.IsKOImmune = item?.ImmuneStatusEffect?.Contains("KO") == true ? true : false;
                unit.Resistances.IsPoisonImmune = item?.ImmuneStatusEffect?.Contains("Poison") == true ? true : false;
                unit.Resistances.IsSilenceImmune = item?.ImmuneStatusEffect?.Contains("Silence") == true ? true : false;
                unit.Resistances.IsSleepImmune = item?.ImmuneStatusEffect?.Contains("Sleep") == true ? true : false;
                unit.Resistances.IsSlowImmune = item?.ImmuneStatusEffect?.Contains("Slow") == true ? true : false;
                unit.Resistances.IsStoneImmune = item?.ImmuneStatusEffect?.Contains("Stone") == true ? true : false;
                unit.Resistances.IsStopImmune = item?.ImmuneStatusEffect?.Contains("Stop") == true ? true : false;
                unit.Resistances.IsToadImmune = item?.ImmuneStatusEffect?.Contains("Toad") == true ? true : false;
                unit.Resistances.IsTraitorImmune = item?.ImmuneStatusEffect?.Contains("Traitor") == true ? true : false;
                unit.Resistances.IsUndeadImmune = item?.ImmuneStatusEffect?.Contains("Undead") == true ? true : false;
                unit.Resistances.IsVampireImmune = item?.ImmuneStatusEffect?.Contains("Vampire") == true ? true : false;
            }

            return unit;
        }
    }
}