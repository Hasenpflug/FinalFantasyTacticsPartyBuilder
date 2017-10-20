using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public class WeaponCategory
    {
        [Key]
        public int WeaponCategoryID { get; set; }

        public string Category { get; set; }
    }
}