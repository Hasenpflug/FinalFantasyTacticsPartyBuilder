using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public class UnitName
    {
        [Key]
        public int UnitNameID { get; set; }

        public string Name { get; set; }

        public int Gender { get; set; }
    }
}