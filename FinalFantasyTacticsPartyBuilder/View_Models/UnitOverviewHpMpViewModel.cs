using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.View_Models
{
    public class UnitOverviewHpMpViewModel
    {
        public char[] HpDigits { get; set; }

        public char[] MpDigits { get; set; }

        public char[] LevelDigits { get; set; }

        public char[] ExperienceDigits { get; set; }

        public char[] PositionDigits { get; set; }
    }
}