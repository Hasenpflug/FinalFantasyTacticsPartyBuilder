using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public enum Jobs { Squire = 1, Chemist, Knight, Archer, WhiteMage, BlackMage, Monk, Thief, Mystic, TimeMage, Geomancer, Dragoon, Orator, Summoner, Samurai,
        Ninja, Arithmetician, Dancer, Bard, Mime, DarkKnight, OnionKnightBasic, OnionKnightMastered }

    public class Job
    {
        [Key]
        public int JobID { get; set; }

        public string PspName { get; set; }

        public string PsxName { get; set; }

        public string AbilitySetPsxName { get; set; }

        public string AbilitySetPspName { get; set; }

        public bool IsMaleOnly { get; set; }

        public bool IsFemaleOnly { get; set; }

        public int HPMultiplier { get; set; }

        public int HPGrowthConstant { get; set; }

        public int MPMultiplier { get; set; }

        public int MPGrowthConstant { get; set; }

        public int SpeedMulitplier { get; set; }

        public int SpeedGrowthConstant { get; set; }

        public int PhysicalAttackMultiplier { get; set; }

        public int PhysicalAttackGrowthConstant { get; set; }

        public int MagicalAttackMultiplier { get; set; }

        public int MagicalAttackGrowthConstant { get; set; }

        public int BaseMoveLength { get; set; }

        public int BaseJumpHeight { get; set; }

        public int BaseCombatEvasion { get; set; }

        public virtual ICollection<Ability> Abilities { get; set; }

        public virtual ICollection<JobItem> JobItems { get; set; }

        public virtual ICollection<JobPrerequisites> JobPrerequisites { get; set; }
    }
}