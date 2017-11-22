using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public enum AbilityType
    {
        Command, Reaction, Support, Movement
    }

    public class Ability
    {
        [Key]
        public int AbilityID { get; set; }

        public int JobID { get; set; }

        public int AbilityType { get; set; }

        public string PspName { get; set; }

        public string PsxName { get; set; }

        public int? MPCost { get; set; }

        public int? Range { get; set; }

        public int? Radius { get; set; }

        public int? Height { get; set; }

        public int? Speed { get; set; }

        public string ItemEquipIDs { get; set; }

        public string Element { get; set; }

        public int? MoveBoost { get; set; }

        public int? JumpBoost { get; set; }

        public string AmountBoost { get; set; }

        public string AmountDamage { get; set; }

        public int JpNeededToLearnPsp { get; set; }

        public int? JpNeededToLearnPsx { get; set; }

        public bool CanBeReflected { get; set; }
        
        public bool UsedWithArithmetics { get; set; }

        public string DamageEquation { get; set; }

        public string HealingEquation { get; set; }

        public string SuccessRateEquation { get; set; }

        public string AddStatusEffect { get; set; }

        public string RemoveStatusEffect { get; set; }

        public int HPRestored { get; set; }

        public int MPRestored { get; set; }

        public string Trigger { get; set; }

        public string Description { get; set; }

        public string Quote { get; set; }

        public virtual Job Job { get; set; }
    }
}