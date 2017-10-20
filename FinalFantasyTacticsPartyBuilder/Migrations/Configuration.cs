namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalFantasyTacticsPartyBuilder.Models.FFTContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalFantasyTacticsPartyBuilder.Models.FFTContext context)
        {
            //context.WeaponCategories.AddOrUpdate(m => m.Category,
            //    new Models.WeaponCategory { Category = "Axe" },
            //    new Models.WeaponCategory { Category = "Bag" },
            //    new Models.WeaponCategory { Category = "Book" },
            //    new Models.WeaponCategory { Category = "Bow" },
            //    new Models.WeaponCategory { Category = "Cloth" },
            //    new Models.WeaponCategory { Category = "Crossbow" },
            //    new Models.WeaponCategory { Category = "Fell Sword" },
            //    new Models.WeaponCategory { Category = "Flail" },
            //    new Models.WeaponCategory { Category = "Gun" },
            //    new Models.WeaponCategory { Category = "Instrument" },
            //    new Models.WeaponCategory { Category = "Katana" },
            //    new Models.WeaponCategory { Category = "Knife" },
            //    new Models.WeaponCategory { Category = "Knight Sword" },
            //    new Models.WeaponCategory { Category = "Ninja Blade" },
            //    new Models.WeaponCategory { Category = "Pole" },
            //    new Models.WeaponCategory { Category = "Rod" },
            //    new Models.WeaponCategory { Category = "Polearm" },
            //    new Models.WeaponCategory { Category = "Staff" },
            //    new Models.WeaponCategory { Category = "Sword" },
            //    new Models.WeaponCategory { Category = "Throwing Weapon" },
            //    new Models.WeaponCategory { Category = "Unarmed" }
            //);

            //context.Weapons.AddOrUpdate(m => m.Name,
            //    new Models.Weapon
            //    {
            //        Name = "Battle Axe",
            //        AttackPower = 9,
            //        HitPercentage = 0,
            //        AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
            //        AcquiredViaPoach = "Wisenkin",
            //        AcquiredViaTreasureHunt = "Fovoham Windflats(rare)",
            //        Description = "A battle axe with a long handle. Designed for two-handed use, it can easily chop off an enemy's limbs."
            //    }







            //);
        }
    }
}
