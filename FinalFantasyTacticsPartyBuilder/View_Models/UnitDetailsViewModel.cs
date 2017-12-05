using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.View_Models
{
    public class UnitDetailsViewModel
    {
        public int HPGrowthConstant { get; set; }

        public int MPGrowthConstant { get; set; }

        public int SpeedGrowthConstant { get; set; }

        public int PhysicalAttackGrowthConstant { get; set; }

        public int MagicalAttackGrowthConstant { get; set; }

        public int SecondaryAbilityJobID { get; set; }

        public int ReactionAbilityID { get; set; }

        public int SupportAbilityID { get; set; }

        public int MovementAbilityID { get; set; }

        public int WeaponID { get; set; }

        public int ShieldID { get; set; }

        public int HeadID { get; set; }

        public int BodyID { get; set; }

        public int AccessoryID { get; set; }

        public UnitOverviewViewModel Unit { get; set; }
    }
}