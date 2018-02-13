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
    }
}