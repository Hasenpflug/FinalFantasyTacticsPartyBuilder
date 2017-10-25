using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public enum ItemCategoriesList
    {
        Axe, Bag, Book, Bow, Cloth, Crossbow, FellSword, Flail, Gun, Instrument, Katana, Knife, KnightSword,
        NinjaBlade, Pole, Rod, Polearm, Staff, Sword, ThrowingItem, Unarmed, HeavyArmour, Clothes, HairAdornments,
        Hats, Helmets, Robes,
    }

    public class ItemCategory
    {
        [Key]
        public int ItemCategoryID { get; set; }

        public string Category { get; set; }
    }
}