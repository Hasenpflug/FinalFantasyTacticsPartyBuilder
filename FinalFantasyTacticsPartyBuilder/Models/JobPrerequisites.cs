using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public class JobPrerequisites
    {
        public int JobPrerequisitesID { get; set; }

        public int JobID { get; set; }

        public int JobRequiredID { get; set; }

        public int JobLevelRequiredPsp { get; set; }

        public int JobLevelRequiredPsx { get; set; }

        public virtual Job Job { get; set; }
    }
}