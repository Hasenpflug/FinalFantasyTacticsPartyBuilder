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

        public int RawSpeed { get; set; }

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

        public string Move { get; set; }

        public string Jump { get; set; }

        public string Speed { get; set; }
        
        public ItemOverviewViewModel WeaponRight { get; set; }

        public ItemOverviewViewModel WeaponLeft { get; set; }
        
        public ItemOverviewViewModel Shield { get; set; }
        
        public ItemOverviewViewModel Head { get; set; }
        
        public ItemOverviewViewModel Body { get; set; }
        
        public ItemOverviewViewModel Accessory { get; set; }       

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