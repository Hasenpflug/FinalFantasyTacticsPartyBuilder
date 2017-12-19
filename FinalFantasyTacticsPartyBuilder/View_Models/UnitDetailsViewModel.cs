using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.View_Models
{
    public class UnitDetailsViewModel
    {
        public int RawHP { get; set; }

        public int RawMP { get; set; }

        public int RawSpeedGrowth { get; set; }

        public int RawPhysicalAttack { get; set; }

        public int RawMagicalAttack { get; set; }

        public int SecondaryAbilityJobID { get; set; }

        public int ReactionAbilityID { get; set; }

        public int SupportAbilityID { get; set; }

        public int MovementAbilityID { get; set; }

        public int WeaponID { get; set; }

        public int ShieldID { get; set; }

        public int HeadID { get; set; }

        public int BodyID { get; set; }

        public int AccessoryID { get; set; }

        public int Move { get; set; }

        public int Jump { get; set; }

        public int Speed { get; set; }

        public int WeaponPowerRight { get; set; }

        public int WeaponHitRight { get; set; }

        public int WeaponPowerLeft { get; set; }

        public int WeaponHitLeft { get; set; }

        public int PhysicalAttackPower { get; set; }

        public int MagicalAttackPower { get; set; }

        public int PhysicalCharacterEvade { get; set; }

        public int PhysicalShieldEvade { get; set; }

        public int PhysicalAccessoryEvade { get; set; }

        public int MagicalCharacterEvade { get; set; }

        public int MagicalShieldEvade { get; set; }

        public int MagicalAccessoryEvade { get; set; }

        public UnitOverviewViewModel Unit { get; set; }
    }
}