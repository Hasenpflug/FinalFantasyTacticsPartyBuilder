using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.View_Models
{
    public class ItemDetailsViewModel
    {
        public int ItemID { get; set; }

        public string Name { get; set; }

        public int? AttackPower { get; set; }

        public int? HPBonus { get; set; }

        public int? MPBonus { get; set; }

        public int? HitPercentage { get; set; }

        public int? PhysicalEvade { get; set; }

        public int? MagicalEvade { get; set; }

        public string Description { get; set; }

        public string SpellEffect { get; set; }

        public string HitStatusEffect { get; set; }

        public string RemoveStatusEffect { get; set; }

        public string ImmuneStatusEffect { get; set; }

        public string EquipStatusEffect { get; set; }

        public int? PhysicalAttackBoost { get; set; }

        public int? MagicAttackBoost { get; set; }

        public int? SpeedBoost { get; set; }

        public int? MoveBoost { get; set; }

        public int? JumpBoost { get; set; }

        public string Element { get; set; }

        public string ElementAbsorbed { get; set; }

        public string ElementBoosted { get; set; }

        public string ElementHalved { get; set; }

        public string ElementNegated { get; set; }

        public string ElementWeakness { get; set; }

        public string AcquiredViaMode { get; set; }

        public string AcquiredViaLocation { get; set; }

        public string AcquiredViaPoach { get; set; }

        public string AcquiredViaSteal { get; set; }

        public string AcquiredViaTreasureHunt { get; set; }

        public string AcquiredViaCatch { get; set; }

        public string AcquiredViaInitialEquip { get; set; }

        public string ImagePath { get; set; }

        public int Cost { get; set; }

    }
}