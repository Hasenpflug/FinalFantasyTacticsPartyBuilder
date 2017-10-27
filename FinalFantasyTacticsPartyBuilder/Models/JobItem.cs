using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public class JobItem
    {
        [Key]
        public int JobItemCategoryID { get; set; }

        public int JobID { get; set; }

        public int ItemCategoryID { get; set; }

        public virtual Job Job { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }
    }
}