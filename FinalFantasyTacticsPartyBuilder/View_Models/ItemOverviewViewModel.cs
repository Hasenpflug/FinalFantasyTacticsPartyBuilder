﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.View_Models
{
    public class ItemOverviewViewModel
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string WeaponPower { get; set; }

        public string WeaponHit { get; set; }

        public string ShieldPhysicalEvade { get; set; }

        public string ShieldMagicalEvade { get; set; }

        public string AccessoryPhysicalEvade { get; set; }

        public string AccessoryMagicalEvade { get; set; }

        public string PhysicalAttackPower { get; set; }

        public string MagicalAttackPower { get; set; }

        public int HPBonus { get; set; }

        public int MPBonus { get; set; }

        public int MoveBonus { get; set; }

        public int JumpBonus { get; set; }

        public int SpeedBonus { get; set; }
    }
}