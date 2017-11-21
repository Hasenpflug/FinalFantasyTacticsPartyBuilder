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

        public int Position { get; set; }

        public int Gender { get; set; }

        public int Job { get; set; }

        public int MaxHP { get; set; }

        public int MaxMP { get; set; }        

        public int RawHP { get; set; }

        public int RawMP { get; set; }

        public int RawSpeed { get; set; }

        public int RawPhysicalAttack { get; set; }

        public int RawMagicalAttack { get; set; }

        public int Level { get; set; }

        public int Experience { get; set; }

        public int Brave { get; set; }

        public int Faith { get; set; }
    }
}