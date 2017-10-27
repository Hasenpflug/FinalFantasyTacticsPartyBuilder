using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public enum AbilityType
    {
        Command, Reaction, Support, Movement
    }

    public class Ability
    {
        [Key]
        public int AbilityID { get; set; }

        public int JobID { get; set; }

        public int AbilityType { get; set; }

        public string PspName { get; set; }

        public string PsxName { get; set; }

        public virtual Job Job { get; set; }
    }
}