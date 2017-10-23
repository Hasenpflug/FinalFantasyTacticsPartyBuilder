using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public enum WeaponCategoriesList
    {
        Axe, Bag, Book, Bow, Cloth, Crossbow, FellSword, Flail, Gun, Instrument, Katana, Knife, KnightSword,
        NinjaBlade, Pole, Rod, Polearm, Staff, Sword, ThrowingWeapon, Unarmed
    }

    public class WeaponCategory
    {
        [Key]
        public int WeaponCategoryID { get; set; }

        public string Category { get; set; }
    }
}