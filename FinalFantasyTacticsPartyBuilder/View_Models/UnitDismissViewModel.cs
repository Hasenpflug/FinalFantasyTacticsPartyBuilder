using FinalFantasyTacticsPartyBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.View_Models
{
    public class UnitDismissViewModel
    {
        public int Position { get; set; }

        public string UnitName { get; set; }

        public string JobName { get; set; }

        public Gender Gender { get; set; }

        public string GenderName { get; set; }

        public string Quote { get; set; }

    }
}