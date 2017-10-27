using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public enum Gender
    {
        Male, Female, Monster
    }

    public class Unit
    {
        public int UnitID { get; set; }

        public int Gender { get; set; }

        public int RawHP { get; set; }

        public int RawMP { get; set; }

        public int RawSpeed { get; set; }

        public int RawPhysicalAttack { get; set; }

        public int RawMagicalAttack { get; set; }
    }
}