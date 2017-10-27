using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }

        public string PspName { get; set; }

        public string PsxName { get; set; }

        public bool IsMaleOnly { get; set; }

        public bool IsFemaleOnly { get; set; }

        public int HPMultiplier { get; set; }

        public int MPMultiplier { get; set; }

        public int SpeedMulitplier { get; set; }

        public int PhysicalAttackMultiplier { get; set; }

        public int MagicalAttackMultiplier { get; set; }

        public int BaseMoveLength { get; set; }

        public int BaseJumpHeight { get; set; }

        public int BaseCombatEvasion { get; set; }

        public virtual ICollection<Ability> Abilities { get; set; }

        public virtual ICollection<JobItem> JobItems { get; set; }
    }
}