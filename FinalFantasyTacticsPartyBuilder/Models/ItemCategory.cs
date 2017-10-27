using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalFantasyTacticsPartyBuilder.Models
{
    public enum EquipmentCategoriesList
    {
        Weapon, Shield, Helmet, Armor, Accessory, Misc
    }

    public enum ItemCategoriesList
    {
        Axe, Bag, Book, Bow, Cloth, Crossbow, FellSword, Flail, Gun, Instrument, Katana, Knife, KnightSword,
        NinjaBlade, Pole, Rod, Polearm, Staff, Sword, ThrowingItem, Unarmed, HeavyArmour, Clothes, HairAdornment,
        Hat, Helmet, Robe, Shield, Shoe, Armguard, Ring, Cloak, Perfume, LipRouge
    }

    public class ItemCategory
    {
        [Key]
        public int ItemCategoryID { get; set; }
       
        public int EquipmentCategoryID { get; set; }

        public string ItemCategoryName { get; set; }

        public string EquipmentCategoryName { get; set; }
    }
}