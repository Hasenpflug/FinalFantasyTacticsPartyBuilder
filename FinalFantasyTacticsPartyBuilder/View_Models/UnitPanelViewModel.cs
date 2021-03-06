﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.View_Models
{
    public class UnitPanelViewModel
    {
        public int JobID { get; set; }

        public string JobName { get; set; }

        public int MaxHP { get; set; }

        public int MaxMP { get; set; }

        public int Position { get; set; }

        public string Gender { get; set; }

        public char[] HpDigits { get; set; }

        public char[] MpDigits { get; set; }
    }
}