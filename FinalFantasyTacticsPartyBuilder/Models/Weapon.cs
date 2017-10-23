﻿using System;
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

        public string PsxName { get; set; }

        public string PspName { get; set; }

        public int AttackPower { get; set; }

        public int HitPercentage { get; set; }

        public string Description { get; set; }

        public string SpellEffect { get; set; }

        public string HitStatusEffect { get; set; }

        public string EquipStatusEffect { get; set; }

        public int? MagicAttackBoost { get; set; }    
        
        public int? SpeedBoost { get; set; }    

        public string Element { get; set; }

        public string ElementAbsorbed { get; set; }

        public string ElementBoosted { get; set; }

        public string AcquiredViaMode { get; set; }

        public string AcquiredViaLocation { get; set; }

        public string AcquiredViaPoach { get; set; }

        public string AcquiredViaSteal { get; set; }

        public string AcquiredViaTreasureHunt { get; set; }

        public string AcquiredViaCatch { get; set; }

        public string AcquiredViaInitialEquip { get; set; }

        public string IconFileName { get; set; }

        public int Cost { get; set; }

        public string Note { get; set; }

        public virtual WeaponCategory WeaponCategory { get; set; }
    }
}