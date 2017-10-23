using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public class Weapon
    {
        [Key]
        public int WeaponID { get; set; }

        public int WeaponCategoryID { get; set; }

        public string Name { get; set; }

        public int AttackPower { get; set; }

        public int HitPercentage { get; set; }

        public string Description { get; set; }

        public string SpellEffect { get; set; }

        public string StatusEffect { get; set; }

        public int? MagicAttackBoost { get; set; }

        public string AcquiredViaMode { get; set; }

        public string Element { get; set; }

        public string AcquiredViaLocation { get; set; }

        public string AcquiredViaPoach { get; set; }

        public string AcquiredViaSteal { get; set; }

        public string AcquiredViaTreasureHunt { get; set; }

        public string AcquiredViaCatch { get; set; }

        public string AcquiredViaInitialEquip { get; set; }

        public string IconFileName { get; set; }

        public int Cost { get; set; }

        public virtual WeaponCategory WeaponCategory { get; set; }
    }
}