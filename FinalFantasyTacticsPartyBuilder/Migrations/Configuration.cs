namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Hosting;

    internal sealed class Configuration : DbMigrationsConfiguration<FFTContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FFTContext context)
        {

            #region Item Categories
            context.ItemCategories.AddOrUpdate(m => m.ItemCategoryName,
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                    ItemCategoryName = "Axe",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Bag,
                    ItemCategoryName = "Bag",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Book,
                    ItemCategoryName = "Book",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Bow,
                    ItemCategoryName = "Bow",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Cloth,
                    ItemCategoryName = "Cloth",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                    ItemCategoryName = "Crossbow",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.FellSword,
                    ItemCategoryName = "Fell Sword",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Flail,
                    ItemCategoryName = "Flail",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Gun,
                    ItemCategoryName = "Gun",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Instrument,
                    ItemCategoryName = "Instrument",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Katana,
                    ItemCategoryName = "Katana",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Knife,
                    ItemCategoryName = "Knife",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                    ItemCategoryName = "Knight Sword",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                    ItemCategoryName = "Ninja Blade",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Pole,
                    ItemCategoryName = "Pole",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Rod,
                    ItemCategoryName = "Rod",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Polearm,
                    ItemCategoryName = "Polearm",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Staff,
                    ItemCategoryName = "Staff",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Sword,
                    ItemCategoryName = "Sword",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.ThrowingItem,
                    ItemCategoryName = "Throwing Item",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Misc,
                    EquipmentCategoryName = "Miscellaneous"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Unarmed,
                    ItemCategoryName = "Unarmed",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Weapon,
                    EquipmentCategoryName = "Weapon"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                    ItemCategoryName = "Heavy Armour",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Armor,
                    EquipmentCategoryName = "Armor"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                    ItemCategoryName = "Clothes",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Armor,
                    EquipmentCategoryName = "Armor"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.HairAdornment,
                    ItemCategoryName = "Hair Adornment",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Helmet,
                    EquipmentCategoryName = "Helmet"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                    ItemCategoryName = "Hat",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Helmet,
                    EquipmentCategoryName = "Helmet"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Helmet,
                    ItemCategoryName = "Helmet",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Helmet,
                    EquipmentCategoryName = "Helmet"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                    ItemCategoryName = "Robe",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Armor,
                    EquipmentCategoryName = "Armor"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Shield,
                    ItemCategoryName = "Shield",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Shield,
                    EquipmentCategoryName = "Shield"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Shoe,
                    ItemCategoryName = "Shoe",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Accessory,
                    EquipmentCategoryName = "Accessory"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Armguard,
                    ItemCategoryName = "Armguard",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Accessory,
                    EquipmentCategoryName = "Accessory"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Ring,
                    ItemCategoryName = "Ring",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Accessory,
                    EquipmentCategoryName = "Accessory"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Cloak,
                    ItemCategoryName = "Cloak",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Accessory,
                    EquipmentCategoryName = "Accessory"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.Perfume,
                    ItemCategoryName = "Perfume",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Accessory,
                    EquipmentCategoryName = "Accessory"
                },
                new ItemCategory
                {
                    ItemCategoryID = (int)ItemCategoriesList.LipRouge,
                    ItemCategoryName = "LipRouge",
                    EquipmentCategoryID = (int)EquipmentCategoriesList.Accessory,
                    EquipmentCategoryName = "Accessory"
                });
            #endregion

            #region Weapons

            #region Axes
            context.Items.AddOrUpdate(m => m.PspName,
                new Item
                {
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                    PspName = "Battle Axe",
                    AttackPower = 9,
                    HitPercentage = 0,
                    AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                    AcquiredViaPoach = "Wisenkin",
                    AcquiredViaTreasureHunt = "Fovoham Windflats",
                    Description = "A battle axe with a long handle. Designed for two-handed use, it can easily chop off an enemy's limbs.",
                    Cost = 1500,
                    IsStartingItem = true,
                    IconFileName = "BattleAxe-fft-psx.gif"
                },
                new Item
                {
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                    PspName = "Giant Axe",
                    AttackPower = 12,
                    HitPercentage = 0,
                    AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                    AcquiredViaPoach = "Wisenkin",
                    Description = "An axe with a large head. Much bigger than the traditional woodman's axe, hence its name.",
                    Cost = 4000,
                    IconFileName = "Giant'sAxe-fft-psx.gif"
                },
                new Item
                {
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                    PspName = "Slasher",
                    AttackPower = 16,
                    HitPercentage = 0,
                    HitStatusEffect = "Slow",
                    AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                    AcquiredViaPoach = "Minotaur",
                    AcquiredViaCatch = "Level 90+ Ninja",
                    Description = "This axe not only has impressive destructive power, but can also slow the actions of its target.",
                    Cost = 12000,
                    IconFileName = "Slasher-fft-psx.gif"
                },
                new Item
                {
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                    PspName = "Francisca",
                    AttackPower = 24,
                    HitPercentage = 0,
                    AcquiredViaMode = "Melee",
                    Description = "This axe's small size belies its incredible destructive power.",
                    Cost = 10,
                    IconFileName = "FFT_Francisca.png"
                },
                new Item
                {
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                    PspName = "Golden Axe",
                    AttackPower = 30,
                    HitPercentage = 0,
                    AcquiredViaMode = "Melee/Rendezvous",
                    Description = "An axe said to have been a gift from spirits inhabiting a spring. Only the righteous may wield it.",
                    Cost = 10,
                    IconFileName = "FFT_Golden_Axe.png"
                });
            #endregion

            #region Bags
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bag,
                PspName = "Croakadile Bag",
                PsxName = "C Bag",
                AttackPower = 10,
                HitPercentage = 0,
                MagicAttackBoost = 1,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaPoach = "Vampire Cat",
                AcquiredViaTreasureHunt = "Monastery Vaults (Second Level)",
                Description = "An expensive designer handbag made of croakadile skin.",
                Cost = 53000,
                IconFileName = "FFT_Croakadile_Bag.gif",
                Note = "Females Only"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bag,
                PspName = "Pantherskin Bag",
                PsxName = "P Bag",
                AttackPower = 12,
                HitPercentage = 0,
                EquipStatusEffect = "Regen",
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Behemoth",
                AcquiredViaTreasureHunt = "Finnath Creek (rare)",
                Description = "The design of this handbag is simple, yet fashionable.",
                Cost = 52000,
                IconFileName = "FFT_Pantherskin_Bag.gif",
                Note = "Females Only"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bag,
                PspName = "Hydrascale Bag",
                PsxName = "H Bag",
                AttackPower = 14,
                HitPercentage = 0,
                SpeedBoost = 1,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaPoach = "Dragon",
                AcquiredViaTreasureHunt = "Limberry Castle Undercroft (rare)",
                Description = "A handbag studded with scales from a hydra.",
                Cost = 58000,
                IconFileName = "FFT_Hydrascale_Bag.gif",
                Note = "Females Only"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bag,
                PspName = "Fallingstar Bag",
                PsxName = "FS Bag",
                AttackPower = 20,
                HitPercentage = 0,
                AcquiredViaPoach = "Wild Boar",
                AcquiredViaMode = "Rendezvous",
                Description = "A custom-made handbag designed for battle.",
                Cost = 60000,
                IconFileName = "FFT_Fallingstar_Bag.gif",
                Note = "Females Only"
            });
            #endregion

            #region Books
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Book,
                PspName = "Battle Folio",
                PsxName = "Battle Dict",
                AttackPower = 7,
                HitPercentage = 15,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Clockwork City of Goug (rare)",
                Description = "A book made for battle.",
                Cost = 3000,
                IsStartingItem = true,
                IconFileName = "FFT_Battle_Folio.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Book,
                PspName = "Bestiary",
                PsxName = "Monster Dict",
                AttackPower = 8,
                HitPercentage = 15,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Description = "A thick book describing various beasts.",
                Cost = 6000,
                IconFileName = "FFT_Bestiary.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Book,
                PspName = "Papyrus Codex",
                PsxName = "Papyrus Plate",
                AttackPower = 9,
                HitPercentage = 15,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaTreasureHunt = "Free City of Bervenia (rare)",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Description = "An ancient text bound in stone.",
                Cost = 10000,
                IconFileName = "FFT_Papyrus_Codex.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Book,
                PspName = "Omnilex",
                PsxName = "Madlemgen",
                AttackPower = 11,
                HitPercentage = 15,
                AcquiredViaPoach = "Greater Malboro",
                AcquiredViaMode = "Rendezvous",
                AcquiredViaCatch = "Level 95+ Ninjas",
                Description = "A book said to contain all words in all languages.",
                Cost = 30000,
                IconFileName = "FFT_Omnilex.gif"
            });

            #endregion

            #region Bows
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Longbow",
                AttackPower = 4,
                HitPercentage = 0,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Brigands' Den (rare)",
                Description = "The most common type of bow. It has a long range and is quite durable.",
                Cost = 800,
                IsStartingItem = true,
                IconFileName = "FFT_Longbow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Silver Bow",
                AttackPower = 5,
                HitPercentage = 0,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                AcquiredViaTreasureHunt = "Fovoham Windflats (rare)",
                Description = "A bow adorned with silver decorations. Thin metal plates help strengthen its wooden frame.",
                Cost = 1500,
                IconFileName = "FFT_Silver_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Ice Bow",
                AttackPower = 5,
                HitPercentage = 0,
                AcquiredViaLocation = "Second battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter (rare)",
                Element = "Ice",
                Description = "A bow that shoots freezing arrows.",
                Cost = 2000,
                IconFileName = "FFT_Ice_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Lightning Bow",
                AttackPower = 6,
                HitPercentage = 0,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Clockwork City of Goug (rare)",
                Element = "Thunder",
                SpellEffect = "Thundara",
                Description = "This bow imbues arrows with the power and speed of lightning.",
                Cost = 3000,
                IconFileName = "FFT_Lightning_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Mythril Bow",
                AttackPower = 7,
                HitPercentage = 0,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Mining Town of Gollund (rare) and Monastery Vaults Second Level (rare)",
                Description = "A bow strengthened by thin plates of mythril.",
                Cost = 5000,
                IconFileName = "FFT_Mythril_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Windslash Bow",
                AttackPower = 8,
                HitPercentage = 0,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Treant",
                AcquiredViaTreasureHunt = "Dugeura Pass (rare)",
                Element = "Wind",
                Description = "Arrows shot by this bow fly at extremely high speeds. The vacuum created by their flight increases their damage.",
                Cost = 8000,
                IconFileName = "FFT_Windslash_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Artemis Bow",
                PsxName = "Ultimus Bow",
                AttackPower = 10,
                HitPercentage = 0,
                AcquiredViaPoach = "Behemoth King",
                AcquiredViaMode = "Melee/Rendezvous",
                Description = "The bow of the goddess of the hunt.",
                Cost = 22000,
                IconFileName = "FFT_Artemis_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Yoichi Bow",
                AttackPower = 12,
                HitPercentage = 0,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaMode = "Rendezvous",
                Description = "The bow of a legendary archer. Its unusual size gives it incredible power.",
                Cost = 10,
                IconFileName = "FFT_Yoichi_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Perseus Bow",
                AttackPower = 16,
                HitPercentage = 0,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaMode = "Rendezvous",
                Description = "The bow of a mythical hero. It is constructed entirely of metal and requires great strength to pull back.",
                Cost = 10,
                IconFileName = "FFT_Perseus_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Bow,
                PspName = "Sagittarius Bow",
                AttackPower = 24,
                HitPercentage = 0,
                AcquiredViaMode = "Rendezvous",
                Description = "An enormous bow that fires meteor-like arrows.",
                Cost = 10,
                IconFileName = "FFT_Sagittarius_Bow.png"
            });

            #endregion

            #region Cloths
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloth,
                PspName = "Damask Cloth",
                PsxName = "Persia",
                AttackPower = 8,
                HitPercentage = 50,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Description = "This cloth is thick and brilliantly colored, making it perfect for use in carpets.",
                Cost = 7000,
                IsStartingItem = true,
                IconFileName = "FFT_Damask_Cloth.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloth,
                PspName = "Cashmere",
                AttackPower = 10,
                HitPercentage = 50,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Lake Poescas (rare)",
                Description = "This warm and flexible woolen fabric is exquisitely soft to the touch.",
                Cost = 15000,
                IconFileName = "FFT_Cashmere.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloth,
                PspName = "Wyrmweave Silk",
                AttackPower = 15,
                HitPercentage = 50,
                AcquiredViaPoach = "Tiamat",
                AcquiredViaMode = "Rendezvous",
                Description = "A special process has been used to make this thin, smooth silk exceptionally durable.",
                Cost = 40000,
                IconFileName = "FFT_Wyrmweave_Silk.gif"
            });

            #endregion

            #region Crossbows
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                PspName = "Bowgun",
                AttackPower = 3,
                HitPercentage = 5,
                AcquiredViaLocation = "Meeting with Dycedarg at Eagrose Castle (Chapter 1)",
                Description = "A crossbow that can be fired with one hand. Uses shorter bolts than a traditional crossbow.",
                Cost = 400,
                IconFileName = "FFT_Bowgun.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                PspName = "Knightslayer",
                PsxName = "Night Killer",
                AttackPower = 3,
                HitPercentage = 5,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                AcquiredViaTreasureHunt = "Fovoham Windflats (rare)",
                HitStatusEffect = "Blind",
                Description = "This crossbow fires specially fashioned bolts that contain a dose of blinding poison.",
                Cost = 1500,
                IconFileName = "FFT_Knightslayer.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                PspName = "Crossbow",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Clockwork City of Goug (rare)",
                Cost = 2000,
                Description = "The firing mechanism of this crossbow has been improved upon, increasing its attack power.",
                IconFileName = "FFT_Crossbow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                PspName = "Poison Bow",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Monastery Vaults Second Level (rare)",
                Cost = 4000,
                HitStatusEffect = "Poison",
                Description = "A crossbow that fires bolts dipped in poison. Includes a mechanism for handling the poisoned bolts.",
                IconFileName = "FFT_Poison_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                PspName = "Hunting Bow",
                AttackPower = 6,
                HitPercentage = 5,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Steelhawk",
                Cost = 8000,
                Description = "A crossbow mainly employed for hunting monsters.",
                IconFileName = "FFT_Hunting_Bow.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                PspName = "Gastrophetes",
                PsxName = "Gastrafitis",
                AttackPower = 10,
                HitPercentage = 5,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Limberry Castle Undercroft (rare)",
                Cost = 20000,
                Description = "The most powerful crossbow ever created. Its unusual size gives it a very strong recoil.",
                IconFileName = "FFT_Gastrophetes.gif"
            });

            #endregion

            #region Fell Swords
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.FellSword,
                PspName = "Chaosbringer",
                AttackPower = 16,
                HitPercentage = 0,
                AcquiredViaMode = "Melee",
                HitStatusEffect = "Blind",
                Element = "Dark",
                Description = "The wielder of this sword bears the sins of his previous lives, robbing him or her of all hope.",
                Cost = 10,
                IconFileName = "FFT_Chaosbringer.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.FellSword,
                PspName = "Deathbringer",
                AttackPower = 20,
                HitPercentage = 0,
                AcquiredViaMode = "Rendezvous",
                HitStatusEffect = "Doom",
                Element = "Dark",
                Description = "This sword brings death to all those who kill in the name of truth and justice.",
                Cost = 10,
                IconFileName = "FFT_Deathbringer.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.FellSword,
                PspName = "Arondight",
                AttackPower = 24,
                HitPercentage = 0,
                AcquiredViaMode = "Melee",
                HitStatusEffect = "Slow",
                Element = "Dark",
                Description = "It is said that a witch bestowed this sword to a knight who died an unnatural death.",
                Cost = 10,
                IconFileName = "FFT_Arondight.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.FellSword,
                PspName = "Balmung",
                AttackPower = 32,
                HitPercentage = 0,
                AcquiredViaMode = "Melee",
                HitStatusEffect = "Stop",
                Element = "Dark",
                Description = "A sword said to have been wielded by a hero from the north. A blue jewel is embedded in its broad handle.",
                Cost = 10,
                IconFileName = "FFT_Balmung.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.FellSword,
                PspName = "Valhalla",
                AttackPower = 40,
                HitPercentage = 0,
                AcquiredViaMode = "Rendezvous",
                HitStatusEffect = "KO",
                Element = "Dark",
                Description = "A tainted blade spoken of in legends about the end of the world, said to feed upon the souls of its victims.",
                Cost = 10,
                IconFileName = "FFT_Valhalla.png"
            });

            #endregion

            #region Flails
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Flail,
                PspName = "Iron Flail",
                PsxName = "Flail",
                AttackPower = 9,
                HitPercentage = 0,
                AcquiredViaLocation = "Balias Swale (Chapter 2)",
                AcquiredViaTreasureHunt = "First battle Mining Town of Gollund (rare)",
                Cost = 1200,
                Description = "A Item comprised of a large iron head attached to a long wooden handle.",
                IsStartingItem = true,
                IconFileName = "FFT_Iron_Flail.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Flail,
                PspName = "Flame Mace",
                PsxName = "Flame Whip",
                AttackPower = 11,
                HitPercentage = 0,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 4000,
                SpellEffect = "Fira",
                Element = "Fire",
                Description = "The head of this large mace is enveloped in flames.",
                IconFileName = "FFT_Flame_Mace.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Flail,
                PspName = "Morning Star",
                AttackPower = 16,
                HitPercentage = 0,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Mount Germinas (rare)",
                Cost = 9000,
                Description = "A large spiked metal ball attached by chain to a wooden pole.",
                IconFileName = "FFT_Morning_Star.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Flail,
                PspName = "Scorpion Tail",
                AttackPower = 23,
                HitPercentage = 0,
                AcquiredViaPoach = "Hydra",
                AcquiredViaMode = "Rendezvous",
                AcquiredViaCatch = "Level 90+ Ninja",
                Cost = 40000,
                Description = "A large morning star with a single spike attached to it.",
                IconFileName = "FFT_Scorpion_Tail.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Flail,
                PspName = "Vesper",
                AttackPower = 36,
                HitPercentage = 0,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Description = "A Item named after the evenstar.",
                IconFileName = "FFT_Vesper.png"
            });

            #endregion

            #region Guns
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Romandan Pistol",
                PsxName = "Romanda Gun",
                AttackPower = 6,
                HitPercentage = 5,
                AcquiredViaLocation = "Clockwork City of Goug (Chapter 2)",
                Cost = 5000,
                Description = "A firearm brought to Ivalice from the northern country of Romanda.",
                IsStartingItem = true,
                IconFileName = "FFT_Romandan_Pistol.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Mythril Gun",
                AttackPower = 8,
                HitPercentage = 5,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                AcquiredViaPoach = "Revenant",
                AcquiredViaTreasureHunt = "Mining Town of Gollund (rare)",
                Cost = 15000,
                Description = "The barrel of this firearm has been fashioned from mythril.",
                IconFileName = "FFT_Mythril_Gun.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Ras Algethi",
                AttackPower = 12,
                HitPercentage = 5,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaInitialEquip = "Balthier",
                Cost = 28000,
                Description = "A firearm named for Ras Algethi, the star that forms the Kneeler's head.",
                IconFileName = "FFT_Ras_Algethi.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Stoneshooter",
                AttackPower = 16,
                HitPercentage = 5,
                AcquiredViaSteal = "Enemies",
                AcquiredViaPoach = "Dark Behemoth",
                EquipStatusEffect = "Stone",
                Cost = 10,
                Description = "A firearm with the power to petrify.",
                IconFileName = "FFT_Stoneshooter.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Fomalhaut",
                AttackPower = 18,
                HitPercentage = 5,
                AcquiredViaMode = "Melee/Rendezvous",
                Cost = 10,
                Description = "A firearm named for the brightest star in the Whale's Maw.",
                IconFileName = "FFT_Fomalhaut.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Glacial Gun",
                PsxName = "Blaze Gun",
                AttackPower = 20,
                HitPercentage = 5,
                AcquiredViaSteal = "Enemies",
                AcquiredViaMode = "Melee/Rendezvous",
                SpellEffect = "Blizzard/Blizzara/Blizzaga",
                Element = "Ice",
                Cost = 10,
                Description = "A firearm that shoots freezing bullets.",
                IconFileName = "FFT_Glacial_Gun.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Blaze Gun",
                PsxName = "Glacier Gun",
                AttackPower = 21,
                HitPercentage = 5,
                AcquiredViaSteal = "Enemies",
                AcquiredViaMode = "Melee/Rendezvous",
                SpellEffect = "Fire/Fira/Firaga",
                Element = "Fire",
                Cost = 10,
                Description = "A firearm that shoots flaming bullets.",
                IconFileName = "FFT_Blaze_Gun.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Gun,
                PspName = "Blaster",
                PsxName = "Blast Gun",
                AttackPower = 22,
                HitPercentage = 5,
                AcquiredViaSteal = "Enemies",
                AcquiredViaMode = "Rendezvous",
                SpellEffect = "Thunder/Thundara/Thundaga.",
                Element = "Thunder",
                Cost = 10,
                Description = "A firearm that shoots electrically charged bullets.",
                IconFileName = "FFT_Blaster.gif"
            });


            #endregion

            #region Instruments
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Instrument,
                PspName = "Lamia's Harp",
                AttackPower = 10,
                HitPercentage = 10,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Clockwork City of Goug (rare)",
                Cost = 5000,
                HitStatusEffect = "Confuse",
                Description = "The strains of this harp can affect one's very soul. Causes confusion in the listener.",
                IsStartingItem = true,
                IconFileName = "FFT_Lamia's_Harp.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Instrument,
                PspName = "Bloodstring Harp",
                PsxName = "Bloody Strings",
                AttackPower = 13,
                HitPercentage = 10,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaTreasureHunt = "Free City of Bervenia (rare)",
                Cost = 10000,
                Note = "Absorbs foe's HP",
                Description = "A harp with a rich timbre and wide tonal range.",
                IconFileName = "FFT_Bloodstring_Harp.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Instrument,
                PspName = "Fairie Harp",
                AttackPower = 15,
                HitPercentage = 10,
                AcquiredViaPoach = "Treant",
                AcquiredViaMode = "Rendezvous",
                HitStatusEffect = "Charm",
                Cost = 30000,
                Note = "Absorbs foe's HP",
                Description = "The pure sound of this harp can charm its user's enemies.",
                IconFileName = "FFT_Faerie_Harp.gif"
            });

            #endregion

            #region Katanas
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Ashura",
                PsxName = "Asura Knife",
                AttackPower = 7,
                HitPercentage = 15,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                Cost = 1600,
                Description = "A katana with a brilliant white blade.",
                IsStartingItem = true,
                IconFileName = "FFT_Ashura.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Kotetsu",
                PsxName = "Koutetsu Knife",
                AttackPower = 8,
                HitPercentage = 15,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                Cost = 3000,
                Description = "A katana whose blade is adorned with a breathtaking carving of a tiger.",
                IconFileName = "FFT_Kotesu.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Osafune",
                PsxName = "Bizen Boat",
                AttackPower = 9,
                HitPercentage = 15,
                AcquiredViaLocation = "Balias Swale (Chapter 2)",
                AcquiredViaTreasureHunt = "Lionel Castle (rare)",
                Cost = 5000,
                Description = "A katana with a blade forged of the finest iron sand by master swordsmith Nagamitsu Osafune.",
                IconFileName = "FFT_Osafune.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Murasame",
                AttackPower = 10,
                HitPercentage = 15,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Monastery Vaults Second Level (rare)",
                Cost = 7000,
                Description = "Referred to as a demon sword, this katana's keen blade showers blood upon the battlefield.",
                IconFileName = "FFT_Murasame.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Ama-no-Murakumo",
                PsxName = "Heaven's Cloud",
                AttackPower = 11,
                HitPercentage = 15,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                AcquiredViaTreasureHunt = "Grogh Heights (rare)",
                Cost = 8000,
                Description = "This katana's design was inspired by a legendary blade said to have been plucked from the tail of a marauding dragon.",
                IconFileName = "FFT_Ama-no-Murakumo.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Kiyomori",
                AttackPower = 12,
                HitPercentage = 15,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                Cost = 10000,
                Description = "This exquisitely crafted katana has a beautifully patterned blade and an incredible cutting edge.",
                IconFileName = "FFT_Kiyomori.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Muramasa",
                AttackPower = 14,
                HitPercentage = 15,
                AcquiredViaLocation = "The Horror of Riovanes (Chapter 4)",
                AcquiredViaTreasureHunt = "Limberry Castle Keep (rare)",
                Cost = 15000,
                Description = "Referred to as a demon sword, this katana was said to drink the blood of countless enemies.",
                IconFileName = "FFT_Muramasa.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Kiku-ichimoji",
                AttackPower = 15,
                HitPercentage = 15,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat North Wall (rare)",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 22000,
                Description = "A katana with a hilt in the shape of a chrysanthemum.",
                IconFileName = "FFT_Kiku-ichimoji.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Masamune",
                AttackPower = 18,
                HitPercentage = 15,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaSteal = "Elmdore (PS1), female Samurai Bremondt's fight (PSP)",
                AcquiredViaCatch = "Level 95 Ninja",
                Cost = 10,
                Description = "This katana's sheath is inlaid with beautiful patterns. It is the life's work of a master swordsmith.",
                IconFileName = "FFT_Masamune.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Katana,
                PspName = "Chirijiraden",
                AttackPower = 25,
                HitPercentage = 15,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaCatch = "Level 96+ Ninja",
                Cost = 10,
                Description = "This katana is decorated with intricate designs.",
                IconFileName = "FFT_Chirijiraden.gif"
            });

            #endregion

            #region Knives
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Dagger",
                AttackPower = 3,
                HitPercentage = 5,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 100,
                Description = "Used for self-defense. Although its blade is longer than that of a normal knife, its attack power is rather low.",
                IsStartingItem = true,
                IconFileName = "FFT_Dagger.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Mythril Knife",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Meeting with Dycedarg at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter and Mining Town of Gollund (rare)",
                Cost = 500,
                Description = "A sturdy, well-balanced knife forged from the featherlight metal known as mythril.",
                IconFileName = "FFT_Mythril_Knife.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Blind Knife",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                HitStatusEffect = "Blind",
                Cost = 800,
                Description = "A knife quenched in an insidious poison that robs its victim of sight.",
                IconFileName = "FFT_Blind_Knife.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Mage Masher",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                AcquiredViaPoach = "Gobbledygook",
                AcquiredViaTreasureHunt = "Windmill Hut (rare)",
                HitStatusEffect = "Silence",
                Cost = 1500,
                Description = "Created especially for the purpose of fighting mages, this knife has the power to silence its target.",
                IconFileName = "FFT_Mage_Masher.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Platinum Dagger",
                AttackPower = 5,
                HitPercentage = 10,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaPoach = "Floating Eye, Malboro",
                Cost = 1800,
                Description = "A knife with a blade made of a lustrous white alloy of mythril and platinum.",
                IconFileName = "FFT_Platinum_Dagger.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Main Gauche",
                AttackPower = 6,
                HitPercentage = 40,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                AcquiredViaPoach = "Gobbledygook, Ghast",
                AcquiredViaTreasureHunt = "Grogh Heights (rare)",
                Cost = 3000,
                Description = "This knife gives the wielder a good chance of blocking attacks, making it useful for both offense and defense.",
                IconFileName = "FFT_Main_Gauche.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Assassin's Dagger",
                AttackPower = 7,
                HitPercentage = 5,
                AcquiredViaLocation = "Outfitters: Walled City of Yardrow (Chapter 3)",
                Cost = 5000,
                HitStatusEffect = "Doom",
                Description = "Popular among assassins, this dagger has the power to doom its victims to certain death.",
                IconFileName = "FFT_Assassin's_Dagger.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Air Knife",
                AttackPower = 10,
                HitPercentage = 5,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaPoach = "Ahriman",
                AcquiredViaTreasureHunt = "Fort Besselat North Wall (rare)",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 8000,
                Element = "Wind",
                Description = "This knife's special wave-shaped blade creates a vacuum when swung through the air, increasing its killing power.",
                IconFileName = "FFT_Air_Knife.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Knife,
                PspName = "Zwill Straightblade",
                PsxName = "Zorlin Shape",
                AttackPower = 12,
                HitPercentage = 10,
                AcquiredViaPoach = "Plague Horror",
                AcquiredViaMode = "Melee",
                AcquiredViaCatch = "Level 95+ Ninja",
                Cost = 12000,
                HitStatusEffect = "Sleep",
                Description = "A knife manufactured in a region renowned for its blades.",
                IconFileName = "FFT_Zwill_Straightblade.gif"
            });

            #endregion

            #region Knight Swords
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                PspName = "Defender",
                AttackPower = 16,
                HitPercentage = 60,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaPoach = "Elder Treant",
                AcquiredViaSteal = "Meliadoul",
                AcquiredViaCatch = "Level 92-94 Ninja",
                Cost = 60000,
                Description = "A broad-bladed knight's sword made from hardened steel. Jewels have been embedded in its rounded pommel.",
                IconFileName = "FFT_Defender.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                PspName = "Save the Queen",
                AttackPower = 18,
                HitPercentage = 30,
                AcquiredViaInitialEquip = "Meliadoul",
                AcquiredViaMode = "Melee/Rendezvous",
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaCatch = "Level 95 Ninja",
                Cost = 10,
                EquipStatusEffect = "Protect",
                Description = "A knight's sword given as a symbol of an oath of fealty.",
                IconFileName = "FFT_Save_the_Queen.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                PspName = "Excalibur",
                AttackPower = 21,
                HitPercentage = 35,
                AcquiredViaInitialEquip = "Orlandeau",
                AcquiredViaMode = "Rendezvous",
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaCatch = "Level 96 Ninja",
                Cost = 10,
                EquipStatusEffect = "Haste",
                ElementAbsorbed = "Holy",
                ElementBoosted = "Holy",
                Description = "It is said that only the true heir to the throne can wield this legendary knight's sword.",
                IconFileName = "FFT_Excalibur.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                PspName = "Ragnarok",
                AttackPower = 24,
                HitPercentage = 20,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaCatch = "Level 97 Ninja",
                Cost = 10,
                EquipStatusEffect = "Shell",
                Description = "This knight's sword is mentioned in tales about the end of the world.",
                IconFileName = "FFT_Ragnarok.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                PspName = "Durandal",
                AttackPower = 26,
                HitPercentage = 40,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                EquipStatusEffect = "Protect, Shell",
                Element = "Holy",
                Description = "A holy knight's sword said to have been forged by spirits.",
                IconFileName = "FFT_Durandal.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                PspName = "Chaos Blade	",
                AttackPower = 40,
                HitPercentage = 20,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaCatch = "Level 98-99 Ninja",
                Cost = 10,
                EquipStatusEffect = "Regen",
                HitStatusEffect = "Stone",
                Description = "This holy knight's sword is said to have been a gift from the gods themselves.",
                IconFileName = "FFT_Chaos_Blade.gif"
            });

            #endregion

            #region Ninja Blades
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Ninja Blade",
                PsxName = "Hidden Knife",
                AttackPower = 8,
                HitPercentage = 5,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                Cost = 3000,
                Description = "A sword specially tailored to the needs of ninjas. Its blade is shorter than that of the average sword.",
                IsStartingItem = true,
                IconFileName = "FFT_Ninja_Blade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Kunai",
                PsxName = "Ninja Knife",
                AttackPower = 9,
                HitPercentage = 5,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                AcquiredViaPoach = "Ghoul",
                AcquiredViaTreasureHunt = "Grogh Heights (rare)",
                Cost = 5000,
                Description = "A multipurpose sword for ninjas.",
                IconFileName = "FFT_Kunai.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Kodachi",
                PsxName = "Short Edge",
                AttackPower = 10,
                HitPercentage = 5,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                Cost = 7000,
                Description = "This sword's short, lightweight blade makes it very easy to carry.",
                IconFileName = "FFT_Kodachi.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Ninja Longblade",
                PsxName = "Ninja Edge",
                AttackPower = 12,
                HitPercentage = 5,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Mount Germinas (rare)",
                Cost = 10000,
                Description = "A sword with a longer blade than that of a normal ninja sword, making it more suitable for use in battle.",
                IconFileName = "FFT_Ninja_Longblade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Spellbinder",
                PsxName = "Spell Edge",
                AttackPower = 13,
                HitPercentage = 5,
                AcquiredViaLocation = "The Horror of Riovanes (Chapter 4)",
                AcquiredViaTreasureHunt = "Limberry Castle Keep (rare)",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 16000,
                HitStatusEffect = "Disable",
                Description = "A sword with the power to stop its targets in their tracks, preventing them from taking any actions.",
                IconFileName = "FFT_Spellbinder.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Sasuke's Blade",
                PsxName = "Sasuke Knife",
                AttackPower = 14,
                HitPercentage = 15,
                AcquiredViaSteal = "Agrias's sidequest",
                AcquiredViaTreasureHunt = "Nelveska Temple",
                AcquiredViaMode = "Rendezvous",
                AcquiredViaCatch = "Level 95 Ninja",
                Cost = 10,
                Description = "A legendary ninja's sword.",
                IconFileName = "FFT_Sasuke's_Blade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Koga Blade",
                AttackPower = 15,
                HitPercentage = 5,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaCatch = "Level 96+ Ninja",
                Cost = 10,
                Description = "A powerful ninja sword that was once used by a secret society.",
                IconFileName = "FFT_Koga_Blade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Iga Blade",
                AttackPower = 15,
                HitPercentage = 10,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                Description = "An exquisitely crafted ninja sword that was once used by a secret society.",
                IconFileName = "FFT_Iga_Blade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Orochi",
                AttackPower = 20,
                HitPercentage = 5,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Note = "Absorbs foe's HP",
                Description = "A katana that strikes like a savage serpent.",
                IconFileName = "FFT_Orochi.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                PspName = "Moonsilk Blade",
                AttackPower = 26,
                HitPercentage = 5,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Description = "The creator of this masterpiece learned the art of swordcraft in a faraway land.",
                IconFileName = "FFT_Moonsilk_Blade.png"
            });

            #endregion

            #region Poles
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Cypress Pole",
                AttackPower = 6,
                HitPercentage = 20,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Castled City of Zaland (rare)",
                Cost = 1000,
                Description = "A pole carved from the wood of a cypress.",
                IsStartingItem = true,
                IconFileName = "FFT_Cypress_Pole.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Battle Bamboo",
                AttackPower = 7,
                HitPercentage = 20,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Balias Swale (rare)",
                Cost = 1400,
                Description = "A thin and supple bamboo pole that bends lithely when swung through the air.",
                IconFileName = "FFT_Battle_Bamboo.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Musk Pole",
                AttackPower = 8,
                HitPercentage = 20,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Monastery Vaults Second Level (rare)",
                Cost = 2400,
                Description = "A pole crafted from wood that emits a musky scent. It is in the shape of a large ladle.",
                IconFileName = "FFT_Musk_Pole.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Iron Fan",
                AttackPower = 9,
                HitPercentage = 20,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 4000,
                Description = "The ribs of this enormous fan are made of iron. When folded up, it may be employed as a pole in battle.",
                IconFileName = "FFT_Iron_Fan.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Gokuu Pole",
                AttackPower = 10,
                HitPercentage = 20,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaTreasureHunt = "Free City of Bervenia (rare)",
                Cost = 7500,
                HitStatusEffect = "Atheist",
                Description = "One strike from this pole can cause the target to lose his faith.",
                IconFileName = "FFT_Gokuu_Pole.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Ivory Pole",
                AttackPower = 11,
                HitPercentage = 20,
                AcquiredViaPoach = "Sekhret",
                AcquiredViaCatch = "Level 95 Ninja",
                Cost = 10000,
                Description = "A pole made from specially treated ivory. It is surprisingly strong, despite its fragile appearance.",
                IconFileName = "FFT_Ivory_Pole.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Eight-fluted Pole",
                AttackPower = 12,
                HitPercentage = 20,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Limberry Castle Undercroft (rare)",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 20000,
                RemoveStatusEffect = "Blind, Silence, Oil, Toad, Poison, Slow, Stop, Immobilize, Disable",
                Description = "A shaft of boxwood, carved into a hexagonal shape and reinforced with metal plates.",
                IconFileName = "FFT_Eight-fluted_Pole.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Pole,
                PspName = "Whale Whisker",
                AttackPower = 16,
                HitPercentage = 20,
                AcquiredViaPoach = "Tiamat",
                AcquiredViaMode = "Melee",
                AcquiredViaCatch = "Level 96+ Ninja",
                Cost = 37000,
                Description = "A pole made from a dark material that is neither wood nor metal. Some say it is a dire whale's whisker.",
                IconFileName = "FFT_Whale_Whisker.gif"
            });

            #endregion

            #region Rods
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Rod",
                AttackPower = 3,
                HitPercentage = 20,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 200,
                Description = "A rod fashioned from evergreen wood.",
                IsStartingItem = true,
                IconFileName = "FFT_Rod.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Thunder Rod",
                AttackPower = 3,
                HitPercentage = 20,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                Cost = 400,
                ElementBoosted = "Thunder",
                SpellEffect = "Thunder",
                Element = "Thunder",
                Description = "A rod imbued with the power of thunder.",
                IconFileName = "FFT_Thunder_Rod.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Flame Rod",
                AttackPower = 3,
                HitPercentage = 20,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                AcquiredViaPoach = "Bomb",
                AcquiredViaTreasureHunt = "Brigands' Den (rare)",
                Cost = 400,
                ElementBoosted = "Fire",
                SpellEffect = "Fire",
                Element = "Fire",
                Description = "A rod imbued with the power of fire.",
                IconFileName = "FFT_Flame_Rod.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Ice Rod",
                AttackPower = 3,
                HitPercentage = 20,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                AcquiredViaTreasureHunt = "Brigands' Den (rare)",
                Cost = 400,
                ElementBoosted = "Ice",
                SpellEffect = "Ice",
                Element = "Ice",
                Description = "A rod imbued with the power of ice.",
                IconFileName = "FFT_Ice_Rod.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Poison Rod",
                AttackPower = 3,
                HitPercentage = 20,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Zeirchele Falls (rare)",
                Cost = 500,
                HitStatusEffect = "Poison",
                Description = "A rod with a poisoned tip.",
                IconFileName = "FFT_Poison_Rod.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Wizard's Rod",
                AttackPower = 4,
                MagicAttackBoost = 2,
                HitPercentage = 20,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Dark Behemoth, Treant",
                AcquiredViaTreasureHunt = "Dugeura Pass (rare)",
                Cost = 8000,
                Description = "A rod that enhances the magickal potency of its wielder.",
                IconFileName = "FFT_Wizard's_Rod.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Dragon Rod",
                AttackPower = 5,
                HitPercentage = 20,
                AcquiredViaPoach = "Blue Dragon",
                AcquiredViaMode = "Rendezvous",
                Cost = 12000,
                Description = "A rod wielded by a dragon master. Its tip is made from carved dragon bone.",
                IconFileName = "FFT_Dragon_Rod.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Rod of Faith",
                AttackPower = 5,
                HitPercentage = 20,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                EquipStatusEffect = "Faith",
                HitStatusEffect = "Faith",
                Description = "This rod purges doubt from those it touches, turning them into pillars of faith.",
                IconFileName = "FFT_Rod_of_Faith.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Stardust Rod",
                AttackPower = 5,
                HitPercentage = 20,
                MagicAttackBoost = 3,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                SpellEffect = "Gravity",
                Description = "A rod tipped with a meteorite fragment.",
                IconFileName = "FFT_Stardust_Rod.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Rod,
                PspName = "Crown Sceptre",
                AttackPower = 5,
                HitPercentage = 20,
                MagicAttackBoost = 4,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "A magicked rod wielded by members of the royal guard.",
                IconFileName = "FFT_Crown_Sceptre.png"
            });

            #endregion

            #region Polearms
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Javelin",
                AttackPower = 8,
                HitPercentage = 10,
                AcquiredViaLocation = "Second battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Balias Swale (rare)",
                Cost = 1000,
                Description = "A light and inexpensive spear. Allows the wielder to attack enemies within a range of two tiles.",
                IsStartingItem = true,
                IconFileName = "FFT_Javelin_1.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Spear",
                AttackPower = 9,
                HitPercentage = 10,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "First battle Mining Town of Gollund (rare)",
                Cost = 2000,
                Description = "The most commonly used type of spear. Distinguished by its especially long reach.",
                IconFileName = "FFT_Spear.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Mythril Spear",
                AttackPower = 10,
                HitPercentage = 10,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                Cost = 4500,
                Description = "The tip of this spear is made from the valuable metal known as mythril.",
                IconFileName = "FFT_Mythril_Spear.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Partisan",
                AttackPower = 11,
                HitPercentage = 10,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Bonesnatch",
                AcquiredViaTreasureHunt = "Free City of Bervenia (rare)",
                Cost = 7000,
                Description = "A polearm tipped with a broad, double-edged blade. Its design increases the damage it causes.",
                IconFileName = "FFT_Partisan.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Obelisk",
                PsxName = "Oberisk",
                AttackPower = 12,
                HitPercentage = 10,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Limberry Castle Undercroft (rare)",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 10000,
                Description = "A hefty spear fitted with an obelisk-shaped head.",
                IconFileName = "FFT_Obelisk.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Holy Lance",
                AttackPower = 14,
                HitPercentage = 10,
                AcquiredViaPoach = "Sekhret",
                AcquiredViaMode = "Rendezvous",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 18000,
                SpellEffect = "Holy",
                Element = "Holy",
                Description = "This sacred Item shines a brilliant blue.",
                IconFileName = "FFT_Holy_Lance.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Dragon Whisker",
                AttackPower = 17,
                HitPercentage = 10,
                AcquiredViaPoach = "Red Dragon",
                AcquiredViaMode = "Melee/Rendezvous",
                AcquiredViaCatch = "Level 96 Ninja",
                Cost = 44000,
                Description = "A spear made from a mysterious material that is neither wood nor metal. Some say it is a dragon's whisker.",
                IconFileName = "FFT_Dragon_Whisker.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Gae Bolg",
                AttackPower = 24,
                HitPercentage = 15,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Description = "A spear said to have been wielded by a child of the gods. Merely lifting it requires great strength.",
                IconFileName = "FFT_Gae_Bolg.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Gungnir",
                AttackPower = 29,
                HitPercentage = 15,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Element = "Thunder",
                Description = "A spear with the power to pierce anything.",
                IconFileName = "FFT_Gungnir.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Polearm,
                PspName = "Javelin 'II'",
                AttackPower = 30,
                HitPercentage = 10,
                AcquiredViaTreasureHunt = "Nelveska Temple",
                AcquiredViaCatch = "Level 97+ Ninja",
                Cost = 1000,
                Description = "This spear has unmatched attack power.",
                IconFileName = "FFT_Javelin_2.gif"
            });

            #endregion

            #region Staves
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Oak Staff",
                AttackPower = 3,
                HitPercentage = 15,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 120,
                Description = "A staff made from sturdy oak.",
                IsStartingItem = true,
                IconFileName = "FFT_Oak_Staff.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "White Staff",
                AttackPower = 3,
                HitPercentage = 15,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                AcquiredViaTreasureHunt = "Brigands' Den (rare)",
                Cost = 800,
                RemoveStatusEffect = "Doom",
                Description = "A staff carried by members of the clergy.",
                IconFileName = "FFT_White_Staff.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Mage's Staff",
                PsxName = "Wizard Staff",
                AttackPower = 4,
                HitPercentage = 15,
                MagicAttackBoost = 1,
                AcquiredViaLocation = "Balias Swale (Chapter 3)",
                AcquiredViaTreasureHunt = "First battle Mining Town of Gollund (rare)",
                Cost = 4000,
                Description = "This cypress staff increases the magick power of its owner.",
                IconFileName = "FFT_Mage's_Staff.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Healing Staff",
                AttackPower = 4,
                HitPercentage = 15,
                AcquiredViaInitialEquip = "Alma",
                AcquiredViaPoach = "Dryad",
                AcquiredViaTreasureHunt = "First battle Mining Town of Gollund (rare)",
                AcquiredViaMode = "Rendezvous",
                Cost = 4000,
                Note = "Heals target.",
                Description = "A staff imbued with the power of spirits. Has the power to restore HP to those it hits.",
                IconFileName = "FFT_Healing_Staff.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Serpent Staff",
                PsxName = "Rainbow Staff",
                AttackPower = 5,
                HitPercentage = 15,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Castled City of Zaland (rare)",
                Cost = 2200,
                Description = "A staff with a giant serpent scale embedded in its tip.",
                IconFileName = "FFT_Serpent_Staff.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Nirvana",
                AttackPower = 5,
                HitPercentage = 15,
                MagicAttackBoost = 3,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Element = "Holy",
                Description = "A staff that can only be mastered by the enlightened.",
                IconFileName = "FFT_Nirvana.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Dreamwaker",
                AttackPower = 5,
                HitPercentage = 15,
                MagicAttackBoost = 4,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "A powerful staff said to give life to its owner's dreams.",
                IconFileName = "FFT_Dreamwaker.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Golden Staff",
                AttackPower = 6,
                HitPercentage = 15,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Treant",
                AcquiredViaTreasureHunt = "Dugeura Pass (rare)",
                Cost = 7000,
                Description = "A shiny staff decorated with gold.",
                IconFileName = "FFT_Golden_Staff.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Zeus Mace",
                AttackPower = 6,
                HitPercentage = 15,
                MagicAttackBoost = 1,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                Note = "Physical Attack +2.",
                Description = "A staff that increases the strength of its user.",
                IconFileName = "FFT_Zeus_Mace.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Staff,
                PspName = "Staff of the Magi",
                PsxName = "Sage Staff",
                AttackPower = 7,
                HitPercentage = 15,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                Description = "An ordinary wooden staff that one might find anywhere.",
                IconFileName = "FFT_Staff_of_the_Magi.gif"
            });

            #endregion

            #region Swords
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Nagnarok",
                PsxName = "Nagrarok",
                AttackPower = 1,
                HitPercentage = 50,
                AcquiredViaPoach = "Swine",
                AcquiredViaMode = "Rendezvous",
                AcquiredViaCatch = "Level 95 Ninja",
                Cost = 10,
                HitStatusEffect = "Toad",
                Description = "This dark blade is mentioned in legends about the end of the world.",
                IconFileName = "FFT_Nagrarok.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Broadsword",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 200,
                Description = "This broad-bladed sword is suited for large slashing strokes. It is inexpensive, but not particularly powerful.",
                IsStartingItem = true,
                IconFileName = "FFT_Broadsword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Longsword",
                AttackPower = 5,
                HitPercentage = 10,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter (rare)",
                Cost = 900,
                Description = "This straight and sharp double-edged blade can be used for either stabbing or slashing.",
                IconFileName = "FFT_Long_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Iron Sword",
                AttackPower = 6,
                HitPercentage = 5,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                Cost = 900,
                Description = "This sword has a broad and sturdy blade, but its iron construction makes it very heavy.",
                IconFileName = "FFT_Iron_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Mythril Sword",
                AttackPower = 7,
                HitPercentage = 8,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                AcquiredViaTreasureHunt = "Fovoham Windflats (rare), Mining Town of Gollund (rare)",
                Cost = 1600,
                Description = "A sword forged from the metal known as mythril. Its brilliantly shining blade is incredibly lightweight.",
                IconFileName = "FFT_Mythril_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Coral Sword",
                AttackPower = 8,
                HitPercentage = 5,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaPoach = "Minotaur",
                Cost = 3300,
                Element = "Thunder",
                Description = "The handle of this single-edged sword has been decorated with intricate coral piecework.",
                IconFileName = "FFT_Coral_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Blood Sword",
                AttackPower = 8,
                HitPercentage = 5,
                AcquiredViaSteal = "Gaffgarion at Golgollada Gallows",
                AcquiredViaTreasureHunt = "Eagrose Castle (rare)",
                AcquiredViaPoach = "Hydra",
                AcquiredViaMode = "Melee",
                Cost = 3300,
                Note = "Absorbs foe's HP.",
                Description = "The blade of this sword is a deep crimson, as if it were drenched in blood. It is cruelly sharp.",
                IconFileName = "FFT_Blood_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Ancient Sword",
                AttackPower = 9,
                HitPercentage = 5,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaPoach = "Gobbledygook",
                Cost = 5000,
                HitStatusEffect = "Immobilize",
                Description = "A sword constructed using ancient techniques that have long since perished from the world.",
                IconFileName = "FFT_Ancient_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Sleep Blade",
                PsxName = "Sleep Sword",
                AttackPower = 9,
                HitPercentage = 5,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                AcquiredViaPoach = "Squidraken",
                AcquiredViaTreasureHunt = "Grogh Heights (rare)",
                Cost = 5000,
                HitStatusEffect = "Sleep",
                Description = "A wide-bladed sword with a midnight blue handle.",
                IconFileName = "FFT_Sleep_Blade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Diamond Sword",
                AttackPower = 10,
                HitPercentage = 10,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Treant",
                AcquiredViaTreasureHunt = "Dugeura Pass (rare)",
                Cost = 8000,
                Description = "The countless tiny diamonds embedded into this sword's blade saw into its victims, causing great damage.",
                IconFileName = "FFT_Diamond_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Materia Blade",
                AttackPower = 10,
                HitPercentage = 10,
                AcquiredViaTreasureHunt = "Bervenia Volcano",
                AcquiredViaMode = "Melee/Rendezvous",
                AcquiredViaCatch = "Level 96+ Ninja",
                Cost = 10,
                Description = "A sword of extraplanar origin.",
                IconFileName = "FFT_Materia_Blade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Platinum Sword",
                AttackPower = 12,
                HitPercentage = 10,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Mount Germinas (rare)",
                Cost = 11000,
                Description = "A shining sword made of a lustrous white alloy of mythril and platinum. Its broad blade is wickedly sharp.",
                IconFileName = "FFT_Platinum_Sword.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Icebrand",
                AttackPower = 13,
                HitPercentage = 10,
                AcquiredViaLocation = "The Horror of Riovanes (Chapter 4)",
                AcquiredViaInitialEquip = "Luso",
                Cost = 14000,
                SpellEffect = "Blizzara",
                Element = "Ice",
                Description = "A sword with a transparent blade that resembles ice.",
                IconFileName = "FFT_Icebrand.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Runeblade",
                AttackPower = 14,
                HitPercentage = 15,
                MagicAttackBoost = 2,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat North Wall (rare)",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 20000,
                Description = "A sword inscribed with ancient runes.",
                IconFileName = "FFT_Runeblade.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Moonblade",
                AttackPower = 20,
                HitPercentage = 15,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                EquipStatusEffect = "Haste",
                Description = "A sword that glitters cruelly like a crescent moon.",
                IconFileName = "FFT_Moonblade.png"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Sword,
                PspName = "Onion Sword",
                AttackPower = 50,
                HitPercentage = 15,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Note = "Onion Knight only.",
                Description = "A blade forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.",
                IconFileName = "FFT_Onion_Sword.png"
            });

            #endregion

            #region Throwing Items
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.ThrowingItem,
                PspName = "Shuriken",
                AttackPower = 4,
                HitPercentage = 0,
                AcquiredViaLocation = "Second battle Merchant City of Dorter (Chapter 2)",
                Cost = 50,
                Description = "A throwing Item for ninjas. It spins in the air before hitting its target.",
                IconFileName = "FFT_Shuriken.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.ThrowingItem,
                PspName = "Fuma Shuriken",
                PsxName = "Magic Shuriken",
                AttackPower = 7,
                HitPercentage = 0,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 300,
                Description = "A pinwheel-shaped throwing star that flies at very high speeds.",
                IconFileName = "FFT_Fuma_Shuriken.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.ThrowingItem,
                PspName = "Yagyu Darkrood",
                PsxName = "Yagyu Darkness",
                AttackPower = 10,
                HitPercentage = 0,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 1000,
                Description = "A cross-shaped throwing star used by a famous ninja school. Its blades are serrated for maximum damage.",
                IconFileName = "FFT_Yagyu_Darkrood.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.ThrowingItem,
                PspName = "Flameburst Bomb",
                PsxName = "Fire Ball",
                AttackPower = 8,
                HitPercentage = 0,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                Cost = 250,
                Element = "Fire",
                Description = "An explosive sphere that deals fire damage when thrown.",
                IconFileName = "FFT_Flameburst_Bomb.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.ThrowingItem,
                PspName = "Snowmelt Bomb",
                PsxName = "Water Ball",
                AttackPower = 8,
                HitPercentage = 0,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaPoach = "Bomb",
                Cost = 250,
                Element = "Water",
                Description = "An explosive sphere that deals water damage when thrown.",
                IconFileName = "FFT_Snowmelt_Bomb.gif"
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.ThrowingItem,
                PspName = "Spark Bomb",
                PsxName = "Lightning Ball",
                AttackPower = 8,
                HitPercentage = 0,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                Cost = 250,
                Element = "Lightning",
                Description = "An explosive sphere that deals lightning damage when thrown.",
                IconFileName = "FFT_Spark_Bomb.gif"
            });

            #endregion

            #endregion

            #region Armour

            #region Heavy Armour
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Leather Armor",
                PsxName = "Leather Outfit",
                HPBonus = 10,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter",
                Cost = 200,
                Description = "Armor made from layers of tanned leather.",
                IsStartingItem = true,
                IconFileName = "FFT_Leather_Armor.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Linen Cuirass",
                HPBonus = 20,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                Cost = 600,
                Description = "Linen armor with a bronze breastplate.",
                IconFileName = "FFT_Linen_Cuirass.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Bronze Armor",
                HPBonus = 30,
                AcquiredViaLocation = "Duke Larg meeting at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Lenalian Plateau",
                Cost = 800,
                Description = "Simply fashioned bronze armor.",
                IconFileName = "FFT_Bronze_Armor.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Chainmail",
                HPBonus = 40,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                Cost = 1300,
                Description = "Armor fashioned from countless interlocking metal rings.",
                IconFileName = "FFT_Chainmail.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Mythril Armor",
                HPBonus = 50,
                AcquiredViaLocation = "2nd battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Araguay Woods, Mining Town of Gollund",
                Cost = 2000,
                Description = "Armor made from the valuable metal known as mythril. It is surprisingly light and sturdy.",
                IconFileName = "FFT_Mythril_Armor.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Plate Mail",
                HPBonus = 60,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Balias Tor",
                Cost = 3000,
                Description = "The unique design of this mythril armor greatly increases its protective qualities.",
                IconFileName = "FFT_Plate_Mail.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Golden Armor",
                HPBonus = 70,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Lionel Castle",
                Cost = 3600,
                Description = "Improved plate mail that has been decorated with gold.",
                IconFileName = "FFT_Golden_Armor.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Diamond Armor",
                HPBonus = 80,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 6000,
                Description = "Armor that has been reinforced with incredibly hard gemstones.",
                IconFileName = "FFT_Diamond_Armor.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Platinum Armor",
                PsxName = "Platina Armor",
                HPBonus = 90,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Lake Poescas",
                Cost = 9000,
                Description = "Brilliantly shining armor made of a lustrous white alloy of mythril and platinum.",
                IconFileName = "FFT_Platinum_Armor.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Carabineer Mail",
                PsxName = "Carabini Mail",
                HPBonus = 100,
                AcquiredViaLocation = "The Horror of Riovanes (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat South Wall",
                Cost = 13000,
                Description = "Thick mythril armor designed to withstand even the most intense shocks.",
                IconFileName = "FFT_Caribineer_Mail.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Mirror Mail",
                PsxName = "Reflect Mail",
                HPBonus = 130,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                Cost = 18000,
                EquipStatusEffect = "Reflect",
                Description = "Armor with the power to reflect magick used on the wearer.",
                IconFileName = "FFT_Mirror_Mail.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Crystal Armor",
                PsxName = "Crystal Mail",
                HPBonus = 110,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat Sluice",
                Cost = 19000,
                Description = "Platinum armor reinforced in places with crystalline gemstones found deep within the earth.",
                IconFileName = "FFT_Crystal_Mail.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Genji Armor",
                HPBonus = 150,
                AcquiredViaSteal = "Elmdore",
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "Red enameled armor made by foreign craftsmen. It completely protects the torso and back.",
                IconFileName = "FFT_Genji_Armor.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Grand Armor",
                HPBonus = 170,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                EquipStatusEffect = "Reraise, Regen",
                Description = "Legendary armor given by the gods to a knight in honor of his service. Confers divine protection to the wearer.",
                IconFileName = "FFtactics_grand_armor.png",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Maximillian",
                HPBonus = 200,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                Description = "Top-grade armor made with advanced techniques. The materials and design make it exceedingly strong.",
                IconFileName = "FFT_Maximillian.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                PspName = "Onion Armor",
                HPBonus = 250,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                EquipStatusEffect = "Regen, Reraise, Protect, Shell",
                Note = "Onion Knight Only",
                Description = "Armor forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.",
                IconFileName = "FFtactics_onion_armor.png",
            });

            #endregion

            #region Clothes
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Clothing",
                HPBonus = 5,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter",
                Cost = 150,
                Description = "Made for use in battle, this is sturdier than normal clothing.",
                IsStartingItem = true,
                IconFileName = "FFT_Clothing.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Leather Clothing",
                HPBonus = 10,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                Cost = 300,
                Description = "Leather clothing made for battle.",
                IconFileName = "FFT_Leather_Clothing.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Leather Plate",
                PsxName = "Leather Vest",
                HPBonus = 18,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                AcquiredViaTreasureHunt = "Windmill Hut",
                Cost = 500,
                Description = "The many layers of leather used in this battle clothing make it very sturdy.",
                IconFileName = "FFT_Leather_Plate.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Ringmail",
                PsxName = "Chain Vest",
                HPBonus = 24,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                Cost = 900,
                Description = "A shirt made of countless interlocking metal rings.",
                IconFileName = "FFT_Ringmail.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Mythril Vest",
                HPBonus = 30,
                AcquiredViaLocation = "2nd battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Araguay Woods, Mining Town of Gollund",
                Cost = 1500,
                Description = "A vest with many small mythril plates sewn into it.",
                IconFileName = "FFT_Mythril_Vest.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Adamant Vest",
                PsxName = "Adaman Vest",
                HPBonus = 36,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Balias Tor",
                Cost = 1600,
                Description = "A vest with plates of an incredibly hard metal sewn into it.",
                IconFileName = "FFT_Adamant_Vest.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Wizard Clothing",
                PsxName = "Wizard Outfit",
                HPBonus = 42,
                MPBonus = 15,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Lionel Castle",
                Cost = 1900,
                Description = "A hooded outfit often worn by mages.",
                IconFileName = "FFT_Wizard_Clothing.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Brigandine",
                HPBonus = 50,
                AcquiredViaLocation = "Balias Swale (Chapter 2)",
                Cost = 2500,
                Description = "A cloth garment reinforced with plates of a mythril and platinum alloy.",
                IconFileName = "FFT_Brigandine.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Jujitsu Gi",
                PsxName = "Judo Outfit",
                HPBonus = 60,
                PhysicalAttackBoost = 1,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 4000,
                ImmuneStatusEffect = "KO",
                Description = "A singlet created by foreign craftsmen and favored by practitioners of the martial arts.",
                IconFileName = "FFT_Jujitsu_Gi.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Power Garb",
                PsxName = "Power Sleeve",
                HPBonus = 70,
                PhysicalAttackBoost = 2,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaTreasureHunt = "Finnath Creek",
                Cost = 7000,
                Description = "A supportive garment that enhances the wearer's fighting capabilities.",
                IconFileName = "FFT_Power_Garb.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Gaia Gear",
                PsxName = "Earth Clothes",
                HPBonus = 85,
                MPBonus = 10,
                AcquiredViaLocation = "The Horror of Riovanes (Chapter 4)",
                AcquiredViaTreasureHunt = "Limberry Castle Gate",
                Cost = 10000,
                ElementAbsorbed = "Earth",
                ElementBoosted = "Earth",
                Description = "Clothing made from brilliantly patterned material. It confers the protection of the earth to the wearer.",
                IconFileName = "FFT_Gaia_Gear.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Black Garb",
                PsxName = "Black Costume",
                HPBonus = 100,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                Cost = 12000,
                ImmuneStatusEffect = "Stop",
                Description = "Pitch-black clothing made for battle.",
                IconFileName = "FFT_Black_Garb.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Ninja Gear",
                PsxName = "Secret Clothes",
                HPBonus = 20,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaSteal = "Disorder in the Order",
                Cost = 10,
                SpeedBoost = 2,
                EquipStatusEffect = "Invisible",
                Description = "This ninja clothing is suited to covert missions.",
                IconFileName = "FFT_Ninja_Gear.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Mirage Vest",
                HPBonus = 120,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaInitialEquip = "Balthier",
                Cost = 10,
                SpeedBoost = 1,
                ImmuneStatusEffect = "Sleep, Poison, Stone",
                Description = "A vest designed to increase the user's mobility. Prevents several status ailments.",
                IconFileName = "FFT_Mirage_Vest.png",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Minerva Bustier",
                HPBonus = 120,
                AcquiredViaMode = "Melee",
                Cost = 10,
                ElementHalved = "Ice, Water, Earth, Holy",
                ElementNegated = "Fire, Lightning, Wind, Dark",
                Note = "Females only",
                Description = "Clothing blessed by a goddess. It provides protection against various elemental magicks.",
                IconFileName = "FFtactics_minerva_bustier.png",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Rubber Suit",
                HPBonus = 150,
                MPBonus = 50,
                AcquiredViaMode = "Melee/Rendezvous",
                AcquiredViaPoach = "Greater Hydra",
                Cost = 46000,
                ElementNegated = "Lightning",
                Description = "Clothing made from an unusual resin that perfectly fits the contours of the wearer's body.",
                IconFileName = "FFT_Rubber_Costume.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Clothes,
                PspName = "Brave Suit",
                HPBonus = 160,
                MPBonus = 40,
                AcquiredViaMode = "Melee",
                Cost = 10,
                EquipStatusEffect = "Regen, Reraise",
                Description = "This battle garb is rumored to prevent its wearer from defeat as long as he or she has the will to fight.",
                IconFileName = "FFtactics_brave_suit.png",
            });

            #endregion

            #region Hair Adornments
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HairAdornment,
                PspName = "Cachusha",
                HPBonus = 20,
                AcquiredViaPoach = "Pig",
                AcquiredViaMode = "Melee/Rendezvous",
                Cost = 20000,
                ImmuneStatusEffect = "Doom, Undead, Blind, Silence, Toad, Poison, Slow, Immobilize, Disable",
                Note = "Females only",
                Description = "A hairband that prevents an array of status effects.",
                IconFileName = "FFT_Cachusha.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HairAdornment,
                PspName = "Barette",
                HPBonus = 20,
                AcquiredViaPoach = "Red Chocobo",
                AcquiredViaMode = "Rendezvous",
                Cost = 20000,
                ImmuneStatusEffect = "KO, Stone, Traitor, Confuse, Vampire, Berserk, Stop, Charm, Sleep",
                Note = "Females only",
                Description = "A hairpin that prevents an array of status effects.",
                IconFileName = "FFT_Barette.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.HairAdornment,
                PspName = "Ribbon",
                HPBonus = 10,
                AcquiredViaPoach = "Wild Boar",
                AcquiredViaMode = "Melee/Rendezvous",
                Cost = 30000,
                ImmuneStatusEffect = "KO, Undead, Stone, Traitor, Blind, Confuse, Silence, Vampire, Berserk, Toad, Poison, Slow, Stop, Charm, Sleep, Immobilize, Doom, Disable",
                Note = "Females only",
                Description = "A ribbon that protects against status effects.",
                IconFileName = "FFT_Ribbon.gif",
            });

            #endregion

            #region Hats
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Leather Cap",
                HPBonus = 8,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                Cost = 150,
                Description = "A hat crafted from tanned leather.",
                IsStartingItem = true,
                IconFileName = "FFT_Leather_Cap.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Plumed Hat",
                PsxName = "Feather Cap",
                HPBonus = 16,
                MPBonus = 5,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                Cost = 350,
                Description = "A sturdy hat adorned with a fluffy white feather.",
                IconFileName = "FFT_Plumed_Hat.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Red Hood",
                HPBonus = 24,
                MPBonus = 8,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                AcquiredViaTreasureHunt = "Lenalian Plateau",
                Cost = 800,
                Description = "A hat made from deep red cloth.",
                IconFileName = "FFT_Red_Hood.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Headgear",
                HPBonus = 32,
                AcquiredViaLocation = "2nd battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Araguay Woods",
                Cost = 1200,
                PhysicalAttackBoost = 1,
                Description = "A leather hood that protects the wearer's head and ears.",
                IconFileName = "FFT_Headgear.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Wizard's Hat",
                PsxName = "Triangle Hat",
                HPBonus = 40,
                MPBonus = 12,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Balias Tor",
                Cost = 1800,
                MagicAttackBoost = 1,
                Description = "A hat adorned with a magick symbol.",
                IconFileName = "FFT_Headgear.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Green Beret",
                HPBonus = 48,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Golgollada Gallows",
                Cost = 3000,
                SpeedBoost = 1,
                Description = "A beret worn by units assigned to special missions.",
                IconFileName = "FFT_Green_Beret.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Headband",
                PsxName = "Twist Headband",
                HPBonus = 56,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Monastery Vaults Third Level",
                Cost = 5000,
                PhysicalAttackBoost = 2,
                Description = "Headgear made from a twisted towel. It seems to strengthen the wearer's resolve.",
                IconFileName = "FFT_Headband.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Celebrant's Miter",
                PsxName = "Holy Miter",
                HPBonus = 64,
                MPBonus = 20,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 6000,
                MagicAttackBoost = 1,
                Description = "An elaborately decorated hat employed by the clergy in religious ceremonies.",
                IconFileName = "FFT_Celebrant's_Miter.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Black Cowl",
                PsxName = "Black Hood",
                HPBonus = 72,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaTreasureHunt = "Finnath Creek",
                Cost = 7000,
                Description = "A pitch-black cloth hat.",
                IconFileName = "FFT_Black_Cowl.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Gold Hairpin",
                HPBonus = 80,
                MPBonus = 50,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Fort Besselat South Wall",
                Cost = 12000,
                ImmuneStatusEffect = "Silence",
                Description = "A hairpin beautifully decorated with gold inlay.",
                IconFileName = "FFT_Gold_Hairpin.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Lambent Hat",
                PsxName = "Flash Hat",
                HPBonus = 88,
                MPBonus = 15,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat Sluice",
                Cost = 16000,
                MagicAttackBoost = 1,
                SpeedBoost = 1,
                Description = "The crystals decorating this hat increase the wearer's agility and magickal attack power.",
                IconFileName = "FFT_Lambent_Hat.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Thief's Cap",
                PsxName = "Thief Hat",
                HPBonus = 100,
                AcquiredViaLocation = "Various (Chapter 4)",
                AcquiredViaTreasureHunt = "Eagrose Castle",
                Cost = 35000,
                SpeedBoost = 2,
                ImmuneStatusEffect = "Disable, Immobilize",
                Description = "A hat that increases agility and protects against certain status ailments.",
                IconFileName = "FFT_Thief's_Cap.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Brass Coronet",
                HPBonus = 60,
                MPBonus = 100,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                MagicAttackBoost = 3,
                ImmuneStatusEffect = "Silence",
                Description = "A crown that boosts the potency of the wearer's magicks.",
                IconFileName = "FF_tactics_brass_coronet.png",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Hat,
                PspName = "Acacia Hat",
                HPBonus = 120,
                MPBonus = 20,
                AcquiredViaMode = "Melee",
                Cost = 10,
                SpeedBoost = 2,
                ImmuneStatusEffect = "Confuse, Berserk, Charm",
                Description = "A hat that increases agility and protects against certain status effects.",
                IconFileName = "FF_tactics_acacia_hat.png",
            });

            #endregion

            #region Helmets
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Leather Helm",
                HPBonus = 10,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                Cost = 200,
                Description = "This leather helm has been treated with a special resin, making it sturdy yet flexible.",
                IsStartingItem = true,
                IconFileName = "FFT_Leather_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Bronze Helm",
                HPBonus = 20,
                AcquiredViaLocation = "Dycedarg meting at Eagrose Castle (Chapter 1)",
                Cost = 500,
                Description = "An ordinary bronze helm.",
                IconFileName = "FFT_Bronze_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Iron Helm",
                HPBonus = 30,
                AcquiredViaLocation = "Duke Larg meeting at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Lenalian Plateau",
                Cost = 1000,
                Description = "A sturdy iron helm.",
                IconFileName = "FFT_Iron_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Barbut",
                PsxName = "Barbuta",
                HPBonus = 40,
                AcquiredViaLocation = "2nd battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter",
                Cost = 1500,
                Description = "This helm covers the entire head, save for a T-shaped cutout for the wearer's face.",
                IconFileName = "FFT_Barbut.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Mythril Helm",
                HPBonus = 50,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Castled City of Zaland, Mining Town of Gollund",
                Cost = 2100,
                Description = "A helm made from the valuable metal known as mythril. It is very sturdy and surprisingly lightweight.",
                IconFileName = "FFT_Mythril_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Golden Helm",
                HPBonus = 60,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Golgollada Gallows",
                Cost = 2800,
                Description = "A mythril helm with gold accents.",
                IconFileName = "FFT_Golden_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Close Helmet",
                PsxName = "Cross Helm",
                HPBonus = 70,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "1st battle in Mining Town of Gollund",
                Cost = 4000,
                Description = "This helm completely protects the head and neck, and its front guard protects the face as well.",
                IconFileName = "FFT_Close_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Diamond Helm",
                HPBonus = 80,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 6000,
                Description = "A close helmet adorned with magickal jewels of extraordinary hardness.",
                IconFileName = "FFT_Diamond_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Platinum Helm",
                HPBonus = 90,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Lake Poescas",
                Cost = 8000,
                Description = "This brilliant helm has been forged from a lustrous white alloy of mythril and platinum.",
                IconFileName = "FFT_Platinum_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Circlet",
                HPBonus = 100,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Lake Poescas",
                Cost = 10000,
                Description = "Jewels have been embedded around the front of this helm. The design exposes the wearer's ears, making it lighter.",
                IconFileName = "FFT_Circlet.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Crystal Helm",
                HPBonus = 120,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat Sluice",
                Cost = 14000,
                Description = "This platinum helm has been inlaid with crystalline jewels discovered deep within the earth.",
                IconFileName = "FFT_Crystal_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Genji Helm",
                HPBonus = 130,
                AcquiredViaSteal = "Elmdore",
                Cost = 10,
                Description = "A helm forged by foreign craftsmen. It is made of iron and has a unique shape.",
                IconFileName = "FFT_Genji_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Grand Helm",
                HPBonus = 150,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                ImmuneStatusEffect = "Blind, Sleep",
                Description = "A helm that wards off certain status ailments.",
                IconFileName = "FFT_Grand_Helm.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Vanguard Helm",
                HPBonus = 150,
                MPBonus = 20,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "A helm passed down from one veteran warrior to the next. Every pit and scratch recalls a pitched battle.",
                IconFileName = "FF_tactics_vanguard_helm.png",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Helmet,
                PspName = "Onion Helm",
                HPBonus = 200,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Note = "Onion Knight only",
                Description = "A helm forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.",
                IconFileName = "FF_tactics_onion_helm.png",
            });

            #endregion

            #region Robes
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Hempen Robe",
                PsxName = "Linen Robe",
                HPBonus = 10,
                MPBonus = 10,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                AcquiredViaTreasureHunt = "Windmill Hut",
                Cost = 1200,
                Description = "A simple robe made from a single sheet of linen cloth.",
                IsStartingItem = true,
                IconFileName = "FFT_Hempen_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Silken Robe",
                PsxName = "Silk Robe",
                HPBonus = 20,
                MPBonus = 16,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                Cost = 2400,
                Description = "A smooth robe made from layers of silk cloth.",
                IconFileName = "FFT_Silken_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Wizard's Robe",
                HPBonus = 30,
                MPBonus = 22,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Lionel Castle",
                Cost = 4000,
                MagicAttackBoost = 2,
                Description = "A hooded robe that completely covers the wearer's body.",
                IconFileName = "FFT_Wizard's_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Chameleon Robe",
                HPBonus = 40,
                MPBonus = 28,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 5000,
                ElementAbsorbed = "Holy",
                ImmuneStatusEffect = "KO",
                Description = "A robe dyed with pigments made from shining green stones.",
                IconFileName = "FFT_Chameleon_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "White Robe",
                HPBonus = 50,
                MPBonus = 34,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                Cost = 9000,
                ElementHalved = "Fire, Ice, Lightning",
                Description = "These pure white vestments halve damage taken from the primary elements.",
                IconFileName = "FFT_White_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Black Robe",
                HPBonus = 60,
                MPBonus = 30,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Limberry Castle Gate",
                Cost = 13000,
                ElementBoosted = "Fire, Ice, Lightning",
                Description = "These pitch-black vestments increase damage inflicted by magicks of the primary elements.",
                IconFileName = "FFT_Black_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Luminous Robe",
                PsxName = "Light Robe",
                HPBonus = 75,
                MPBonus = 50,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                Cost = 30000,
                Description = "The material in this robe has been woven from threads that glow faintly with magick.",
                IconFileName = "FFT_Luminous_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Lordly Robe",
                PsxName = "Robe of Lords",
                HPBonus = 100,
                MPBonus = 80,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                PhysicalAttackBoost = 2,
                MagicAttackBoost = 1,
                EquipStatusEffect = "Protect, Shell",
                Description = "Luxurious robe worn by high-ranking nobles.",
                IconFileName = "FFT_Lordly_Robe.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Robe,
                PspName = "Sage's Robe",
                HPBonus = 120,
                MPBonus = 100,
                AcquiredViaMode = "Melee",
                Cost = 10,
                ElementHalved = "Fire, Ice, Lightning, Water, Wind, Earth, Holy, Dark",
                Description = "A robe woven from threads that shimmer in all colors of the rainbow. Halves damage taken from elemental magick.",
                IconFileName = "FF_tactics_sages_robe.png",
            });

            #endregion

            #region Shields
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Escutcheon",
                PhysicalEvade = 10,
                MagicalEvade = 3,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                Cost = 400,
                Description = "The most inexpensive shield available. As expected, its defensive abilities are lacking.",
                IsStartingItem = true,
                IconFileName = "FFT_Escutcheon_1.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Buckler",
                PhysicalEvade = 13,
                MagicalEvade = 3,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                AcquiredViaTreasureHunt = "Lenalian Plateau",
                Cost = 700,
                Description = "A small shield for close-quarters fighting. Though easy to use, its ability to block attacks is lacking.",
                IconFileName = "FFT_Buckler.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Bronze Shield",
                PhysicalEvade = 16,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                Cost = 1200,
                Description = "This bronze shield is rather small, allowing the user to deftly block his opponent's attacks.",
                IconFileName = "FFT_Bronze_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Round Shield",
                PhysicalEvade = 19,
                AcquiredViaLocation = "2nd battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter",
                Cost = 1600,
                Description = "The surface of this small, sturdy shield has been inlaid with a complex ornamental design.",
                IconFileName = "FFT_Round_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Mythril Shield",
                PhysicalEvade = 22,
                MagicalEvade = 5,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Castled City of Zaland, Mining Town of Gollund",
                Cost = 2500,
                Description = "A shield constructed of the featherlight metal known as mythril. It is surprisingly light and easy to wield.",
                IconFileName = "FFT_Mythril_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Golden Shield",
                PsxName = "Gold Shield",
                PhysicalEvade = 25,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Golgollada Gallows",
                Cost = 3500,
                Description = "This mythril shield has been decorated with gold accents and provides excellent protection against physical attacks.",
                IconFileName = "FFT_Golden_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Ice Shield",
                PhysicalEvade = 28,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Monastery Vaults Third Level",
                Cost = 6000,
                ElementAbsorbed = "Ice",
                ElementHalved = "Fire",
                ElementWeakness = "Lightning",
                Description = "This mythril shield is inlaid with pale blue gemstones that seem to emit a frigid aura.",
                IconFileName = "FFT_Ice_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Flame Shield",
                PhysicalEvade = 30,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                Cost = 6500,
                ElementAbsorbed = "Fire",
                ElementHalved = "Ice",
                ElementWeakness = "Water",
                Description = "This mythril shield is inlaid with deep crimson gemstones that seem to dance with the power of flame.",
                IconFileName = "FFT_Flame_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Aegis Shield",
                PhysicalEvade = 10,
                MagicalEvade = 50,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 10000,
                MagicAttackBoost = 1,
                Description = "This shield resembles a breastplate worn by a god. It enhances the user's magickal capabilities.",
                IconFileName = "FFT_Aegis_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Diamond Shield",
                PhysicalEvade = 34,
                MagicalEvade = 15,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaTreasureHunt = "Finnath Creek",
                Cost = 12000,
                Description = "A shield adorned with brilliant, incredibly hard gems that help protect the user from magicks.",
                IconFileName = "FFT_Diamond_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Platinum Shield",
                PsxName = "Platina Shield",
                PhysicalEvade = 37,
                MagicalEvade = 10,
                AcquiredViaLocation = "The Horror of Riovanes (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat South Wall",
                Cost = 16000,
                Description = "This brilliant shield has been forged from a lustrous white alloy of mythril and platinum.",
                IconFileName = "FFT_Platinum_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Crystal Shield",
                PhysicalEvade = 40,
                MagicalEvade = 15,
                AcquiredViaLocation = "Battle of Fort Besselat (Chapter 4)",
                AcquiredViaTreasureHunt = "Fort Besselat Sluice",
                Cost = 21000,
                Description = "This shield has been inlaid with crystalline jewels discovered deep within the earth.",
                IconFileName = "FFT_Crystal_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Genji Shield",
                PhysicalEvade = 43,
                AcquiredViaSteal = "Elmdore",
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "A pitch-black shield made by foreign craftsmen. It is made of iron and has a unique shape.",
                IconFileName = "FFT_Genji_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Kaiser Shield",
                PsxName = "Kaiser Plate",
                PhysicalEvade = 46,
                MagicalEvade = 20,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaSteal = "Disorder in the Order",
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                ElementBoosted = "Fire, Ice, Lightning",
                Description = "A shield bearing the name of an ancient emperor. It boosts the damage dealt by certain elemental magicks.",
                IconFileName = "FFT_Kaiser_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Venetian Shield",
                PhysicalEvade = 50,
                MagicalEvade = 25,
                AcquiredViaSteal = "Disorder in the Order",
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                ElementHalved = "Fire, Ice, Lightning",
                Description = "A shield that has been brilliantly colored using special dyes and pigments. It halves damage from the primary elements.",
                IconFileName = "FFT_Venetian_Shield.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Reverie Shield",
                PhysicalEvade = 50,
                MagicalEvade = 25,
                AcquiredViaMode = "Melee",
                Cost = 10,
                ElementHalved = "Fire, Ice, Lightning, Water, Wind, Earth, Holy, Dark",
                Description = "A shield imbued with resistance to various attacks.",
                IconFileName = "FF_tactics_reverie_shield.png",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Escutcheon (II)",
                PhysicalEvade = 75,
                MagicalEvade = 50,
                AcquiredViaTreasureHunt = "Nelveska Temple",
                Cost = 10,
                Description = "This shield's blocking capabilities are nearly unrivaled.",
                IconFileName = "FFT_Escutcheon_2.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shield,
                PspName = "Onion Shield",
                PhysicalEvade = 80,
                MagicalEvade = 75,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Note = "Onion Knight only",
                Description = "A shield forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.",
                IconFileName = "FF_tactics_onion_shield.png",
            });

            #endregion

            #endregion

            #region Accessories

            #region Shoes
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Battle Boots",
                MoveBoost = 1,
                AcquiredViaLocation = "1st battle Merchant City of Dorter (Chapter 1)",
                Cost = 1000,
                Description = "Battle boots made from layers of leather.",
                IconFileName = "FFT_Battle_Boots.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Spiked Boots",
                PsxName = "Spike Shoes",
                JumpBoost = 1,
                AcquiredViaLocation = "2nd battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Araguay Woods",
                Cost = 1200,
                Description = "The spikes along the bottoms of these boots improve the wearer's footing, allowing him or her to jump farther.",
                IconFileName = "FFT_Spike_Boots.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Rubber Boots",
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle",
                AcquiredViaTreasureHunt = "Lionel Castle",
                Cost = 1500,
                ImmuneStatusEffect = "Immobilize",
                ElementNegated = "Lightning",
                Description = "These resin boots conform perfect to the shape of the wearer's feet, negating lightning-based magick damage.",
                IconFileName = "FFT_Rubber_Boots.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Winged Boots",
                PsxName = "Feather Boots",
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle",
                AcquiredViaTreasureHunt = "Monastery Vaults (First Level)",
                Cost = 2500,
                EquipStatusEffect = "Float",
                Description = "Lightweight boots decorated with fluffy feathers.",
                IconFileName = "FFT_Winged_Boots.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Germinas Boots",
                MoveBoost = 1,
                JumpBoost = 1,
                AcquiredViaLocation = "Royal City of Lesalia",
                Cost = 5000,
                Description = "Boots that fit the feet perfectly, increasing the wearer's mobility.",
                IconFileName = "FFT_Germinas_Boots.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Hermes Shoes",
                PsxName = "Sprint Shoes",
                SpeedBoost = 1,
                AcquiredViaLocation = "Walled City of Yardrow",
                AcquiredViaTreasureHunt = "Limberry Castle (Gate)",
                Cost = 7000,
                Description = "Expensive shoes made by a famous cobbler.",
                IconFileName = "FFT_Hermes_Shoes.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Red Shoes",
                MagicAttackBoost = 1,
                MoveBoost = 1,
                AcquiredViaLocation = "Battle of Fort Besselat",
                AcquiredViaInitialEquip = "Alma",
                Cost = 10000,
                Description = "Shoes that have been dyed a deep crimson.",
                IconFileName = "FFT_Red_Shoes.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Shoe,
                PspName = "Gaius Caligae",
                MoveBoost = 2,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "Military sandals bearing the name of an ancient emperor.",
                IconFileName = "Ff_tactics_gaius_caligae.png",
            });

            #endregion

            #region Armguards
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Armguard,
                PspName = "Power Gauntlet",
                PsxName = "Power Wrist",
                PhysicalAttackBoost = 1,
                AcquiredViaLocation = "Zeirchele Falls",
                Cost = 5000,
                Description = "A sturdy glove that increases weapon attack power.",
                IconFileName = "FFT_Power_Gauntlet.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Armguard,
                PspName = "Magepower Glove",
                PsxName = "Magic Gauntlet",
                MagicAttackBoost = 2,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle",
                Cost = 20000,
                Description = "A glove that boosts the wearer's magickal attack power.",
                IconFileName = "FFT_Magepower_Glove.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Armguard,
                PspName = "Bracer",
                PhysicalAttackBoost = 3,
                AcquiredViaLocation = "Walled City of Yardrow",
                AcquiredViaTreasureHunt = "Limberry Castle (Gate)",
                Cost = 50000,
                Description = "A thin leather bracer.",
                IconFileName = "FFT_Bracer.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Armguard,
                PspName = "Genji Glove",
                PhysicalAttackBoost = 2,
                MagicAttackBoost = 2,
                AcquiredViaSteal = "Elmdore",
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "A vermillion glove made by a foreign craftsman.",
                IconFileName = "FFT_Genji_Glove.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Armguard,
                PspName = "Brigand's Gloves",
                SpeedBoost = 1,
                AcquiredViaLocation = "Various Outfitters",
                AcquiredViaMode = "Rendezvous",
                Cost = 30000,
                EquipStatusEffect = "Haste",
                Description = "Gloves that increase the wearer's mobility.",
                IconFileName = "FF_tactics_brigands_glove.png",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Armguard,
                PspName = "Onion Gloves",
                AcquiredViaMode = "Melee",
                Cost = 10,
                Note = "Onion Knight only",
                ImmuneStatusEffect = "KO, Undead, Stone, Traitor, Blind, Confuse, Silence, Vampire, Berserk, Toad, Poison, Slow, Stop, Charm, Sleep, Immobilize, Disable, Doom",
                Description = "Gloves forged for swordsmen who have mastered every technique and achieved knighthood's most exalted rank.",
                IconFileName = "FF_tactics_onion_glove.png",
            });

            #endregion

            #region Rings
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Ring,
                PspName = "Protect Ring",
                PsxName = "Defense Ring",
                AcquiredViaLocation = "Various Outfitters",
                AcquiredViaTreasureHunt = "Lionel Castle",
                ImmuneStatusEffect = "Sleep, Doom",
                Cost = 5000,
                Description = "A ring forged from a metal imbued with magick.",
                IconFileName = "FFT_Protect_Ring.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Ring,
                PspName = "Magick Ring",
                PsxName = "Magic Ring",
                AcquiredViaLocation = "Various Outfitters",
                ImmuneStatusEffect = "Silence, Berserk",
                Cost = 10000,
                Description = "A ring inlaid with a magickal gemstone.",
                IconFileName = "FFT_Magick_Ring.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Ring,
                PspName = "Reflect Ring",
                AcquiredViaLocation = "Various Outfitters",
                AcquiredViaTreasureHunt = "Monastery Vaults (First Level)",
                EquipStatusEffect = "Reflect",
                Cost = 10000,
                Description = "A ring engraved with arcane symbols that can reflect magick cast upon the wearer.",
                IconFileName = "FFT_Magick_Ring.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Ring,
                PspName = "Angel Ring",
                AcquiredViaTreasureHunt = "Fort Besselat (North Wall)",
                ImmuneStatusEffect = "Blind",
                EquipStatusEffect = "Reraise",
                Cost = 20000,
                Description = "A ring that bestows an angel's aegis upon its owner.",
                IconFileName = "FFT_Angel_Ring.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Ring,
                PspName = "Cursed Ring",
                PhysicalAttackBoost = 1,
                MagicAttackBoost = 1,
                SpeedBoost = 1,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                ImmuneStatusEffect = "Traitor",
                EquipStatusEffect = "Undead",
                Cost = 10,
                Description = "A ring forged from metal inhabited by spirits.",
                IconFileName = "FFT_Cursed_Ring.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Ring,
                PspName = "Sage's Ring",
                AcquiredViaMode = "Rendezvous",
                ElementBoosted = "Fire, Ice, Lightning, Water, Wind, Earth, Holy, Dark",
                ElementAbsorbed = "Fire, Ice, Lightning, Water, Wind, Earth, Holy, Dark",
                Cost = 10,
                Description = "A ring bearing a magickal jewel.",
                IconFileName = "FF_tactics_sages_ring.png",
            });

            #endregion

            #region Cloaks
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloak,
                PspName = "Shoulder Cape",
                PsxName = "Small Mantle",
                PhysicalEvade = 10,
                MagicalEvade = 10,
                AcquiredViaLocation = "Zeklaus Desert",
                AcquiredViaTreasureHunt = "Windmill Hut",
                Cost = 300,
                Description = "A small woolen cape.",
                IconFileName = "FFT_Shoulder_Cape.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloak,
                PspName = "Leather Cloak",
                PsxName = "Leather Mantle",
                PhysicalEvade = 15,
                MagicalEvade = 15,
                AcquiredViaLocation = "2nd battle at Merchant City of Dorter",
                Cost = 800,
                Description = "A sturdy leather cloak.",
                IconFileName = "FFT_Leather_Cloak.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloak,
                PspName = "Mage's Cloak",
                PsxName = "Wizard Mantle",
                PhysicalEvade = 18,
                MagicalEvade = 18,
                MagicAttackBoost = 1,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle",
                AcquiredViaTreasureHunt = "Lionel Castle",
                Cost = 2000,
                Description = "A hooded cloak often worn by mages.",
                IconFileName = "FFT_Mage's_Cloak.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloak,
                PspName = "Elven Cloak",
                PsxName = "Elf Mantle",
                PhysicalEvade = 25,
                MagicalEvade = 25,
                AcquiredViaLocation = "Royal City of Lesalia",
                Cost = 8000,
                Description = "A short cloak made of thin material that has been imbued with a magickal power.",
                IconFileName = "FFT_Elven_Cloak.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloak,
                PspName = "Vampire Cape",
                PsxName = "Dracula Mantle",
                PhysicalEvade = 28,
                MagicalEvade = 28,
                AcquiredViaLocation = "Walled City of Yardrow",
                AcquiredViaTreasureHunt = "Limberry Castle Keep",
                Cost = 15000,
                Description = "The outside of this cloak is black, while the inside is deep crimson.",
                IconFileName = "FFT_Vampire_Cape.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloak,
                PspName = "Featherweave Cloak",
                PsxName = "Feather Mantle",
                PhysicalEvade = 40,
                MagicalEvade = 30,
                AcquiredViaLocation = "Battle of Fort Besselat",
                AcquiredViaTreasureHunt = "Eagrose Castle",
                Cost = 20000,
                Description = "This cloak is as light and soft as a feather.",
                IconFileName = "FFT_Featherwave_Cloak.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Cloak,
                PspName = "Invisibility Cloak",
                PsxName = "Vanish Mantle",
                PhysicalEvade = 35,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaTreasureHunt = "Mount Germinas",
                Cost = 10,
                EquipStatusEffect = "Invisble",
                Description = "This cloak makes the wearer invisible - until he or she is discovered.",
                IconFileName = "FFT_Invisibility_Cloak.gif",
            });

            #endregion

            #region Perfume
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Perfume,
                PspName = "Cherche",
                AcquiredViaPoach = "Behemoth King",
                AcquiredViaMode = "Melee",
                Cost = 30000,
                Note = "Females only",
                EquipStatusEffect = "Float, Reflect",
                Description = "A perfume with a refreshing fragrance.",
                IconFileName = "FFT_Cherche.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Perfume,
                PspName = "Sortilége",
                PsxName = "Salty Rage",
                AcquiredViaPoach = "Red Dragon",
                AcquiredViaMode = "Rendezvous",
                Cost = 30000,
                Note = "Females only",
                EquipStatusEffect = "Protect, Shell",
                Description = "A perfume with a rich redolence.",
                IconFileName = "FFT_Sortilege.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Perfume,
                PspName = "Chantage",
                AcquiredViaPoach = "Swine",
                AcquiredViaMode = "Melee/Rendezvous",
                AcquiredViaSteal = "Meliadoul",
                Cost = 30000,
                Note = "Females only",
                EquipStatusEffect = "Reraise, Regen",
                Description = "A perfume with a soothing scent.",
                IconFileName = "FFT_Sortilege.gif",
            },
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.Perfume,
                PspName = "Septième",
                PsxName = "Setiemson",
                MagicAttackBoost = 1,
                AcquiredViaPoach = "Swine",
                Cost = 30000,
                Note = "Females only",
                EquipStatusEffect = "Haste, Invisible",
                Description = "A perfume with an otherworldly aroma.",
                IconFileName = "FFT_Septieme.gif",
            });

            #endregion

            #region Lip Rouge
            context.Items.AddOrUpdate(m => m.PspName,
            new Item
            {
                ItemCategoryID = (int)ItemCategoriesList.LipRouge,
                PspName = "Tynar Rouge",
                PhysicalAttackBoost = 3,
                MagicAttackBoost = 3,
                AcquiredViaPoach = "Behemoth King",
                AcquiredViaMode = "Melee",
                Cost = 10,
                Note = "PSP Exclusive Event, Females only",
                ElementBoosted = "Holy",
                EquipStatusEffect = "Protect, Shell, Haste",
                Description = "Magickal lip rouge from the popular Feyforge brand. It is a limited-edition product, making it difficult for even the richest noblewomen to obtain.",
                IconFileName = "FF_tactics_tynar_rouge.png",
            });

            #endregion

            #endregion

            #region Jobs

            #region Squire 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Squire,
                    PspName = "Squire",
                    HPMultiplier = 100,
                    HPGrowthConstant = 11,
                    MPMultiplier = 75,
                    MPGrowthConstant = 15,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 90,
                    PhysicalAttackGrowthConstant = 60,
                    MagicalAttackMultiplier = 80,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 4,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                });

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Squire,
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Squire,
                    ItemCategoryID = (int)ItemCategoriesList.Sword,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Squire,
                    ItemCategoryID = (int)ItemCategoriesList.Knife,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Squire,
                    ItemCategoryID = (int)ItemCategoriesList.Flail,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Squire,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Squire,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Chemist

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Chemist,
                    PspName = "Chemist",
                    HPMultiplier = 80,
                    HPGrowthConstant = 12,
                    MPMultiplier = 75,
                    MPGrowthConstant = 16,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 75,
                    PhysicalAttackGrowthConstant = 75,
                    MagicalAttackMultiplier = 80,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Chemist,
                    ItemCategoryID = (int)ItemCategoriesList.Gun,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Chemist,
                    ItemCategoryID = (int)ItemCategoriesList.Knife,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Chemist,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Chemist,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Knight

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Knight,
                    PspName = "Knight",
                    HPMultiplier = 120,
                    HPGrowthConstant = 10,
                    MPMultiplier = 80,
                    MPGrowthConstant = 15,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 120,
                    PhysicalAttackGrowthConstant = 40,
                    MagicalAttackMultiplier = 80,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 10,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Knight,
                    JobRequiredID = (int)Jobs.Squire,
                    JobLevelRequiredPsp = 2
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Knight,
                    ItemCategoryID = (int)ItemCategoriesList.Sword,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Knight,
                    ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Knight,
                    ItemCategoryID = (int)ItemCategoriesList.Shield,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Knight,
                    ItemCategoryID = (int)ItemCategoriesList.Helmet,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Knight,
                    ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Knight,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Archer

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Archer,
                    PspName = "Archer",
                    HPMultiplier = 100,
                    HPGrowthConstant = 11,
                    MPMultiplier = 65,
                    MPGrowthConstant = 16,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 110,
                    PhysicalAttackGrowthConstant = 45,
                    MagicalAttackMultiplier = 80,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 10,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Archer,
                    JobRequiredID = (int)Jobs.Squire,
                    JobLevelRequiredPsp = 2
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Archer,
                    ItemCategoryID = (int)ItemCategoriesList.Bow,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Archer,
                    ItemCategoryID = (int)ItemCategoriesList.Crossbow,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Archer,
                    ItemCategoryID = (int)ItemCategoriesList.Shield,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Archer,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Archer,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region White Mage

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.WhiteMage,
                    PspName = "White Mage",
                    HPMultiplier = 80,
                    HPGrowthConstant = 10,
                    MPMultiplier = 120,
                    MPGrowthConstant = 10,
                    SpeedMulitplier = 110,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 90,
                    PhysicalAttackGrowthConstant = 50,
                    MagicalAttackMultiplier = 110,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.WhiteMage,
                    JobRequiredID = (int)Jobs.Chemist,
                    JobLevelRequiredPsp = 2
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.WhiteMage,
                    ItemCategoryID = (int)ItemCategoriesList.Staff,
                },
                new JobItem
                {
                    JobID = (int)Jobs.WhiteMage,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.WhiteMage,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                },
                new JobItem
                {
                    JobID = (int)Jobs.WhiteMage,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Black Mage

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.BlackMage,
                    PspName = "Black Mage",
                    HPMultiplier = 75,
                    HPGrowthConstant = 12,
                    MPMultiplier = 120,
                    MPGrowthConstant = 9,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 60,
                    PhysicalAttackGrowthConstant = 60,
                    MagicalAttackMultiplier = 150,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.BlackMage,
                    JobRequiredID = (int)Jobs.Chemist,
                    JobLevelRequiredPsp = 2
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.BlackMage,
                    ItemCategoryID = (int)ItemCategoriesList.Rod,
                },
                new JobItem
                {
                    JobID = (int)Jobs.BlackMage,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.BlackMage,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                },
                new JobItem
                {
                    JobID = (int)Jobs.BlackMage,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Monk

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Monk,
                    PspName = "Monk",
                    HPMultiplier = 135,
                    HPGrowthConstant = 9,
                    MPMultiplier = 80,
                    MPGrowthConstant = 13,
                    SpeedMulitplier = 110,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 129,
                    PhysicalAttackGrowthConstant = 48,
                    MagicalAttackMultiplier = 80,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 4,
                    BaseCombatEvasion = 20,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Monk,
                    JobRequiredID = (int)Jobs.Knight,
                    JobLevelRequiredPsx = 2,
                    JobLevelRequiredPsp = 3
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Monk,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Thief 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Thief,
                    PspName = "Thief",
                    HPMultiplier = 90,
                    HPGrowthConstant = 11,
                    MPMultiplier = 50,
                    MPGrowthConstant = 16,
                    SpeedMulitplier = 110,
                    SpeedGrowthConstant = 90,
                    PhysicalAttackMultiplier = 100,
                    PhysicalAttackGrowthConstant = 50,
                    MagicalAttackMultiplier = 60,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 4,
                    BaseJumpHeight = 4,
                    BaseCombatEvasion = 25,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Thief,
                    JobRequiredID = (int)Jobs.Archer,
                    JobLevelRequiredPsx = 2,
                    JobLevelRequiredPsp = 3
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Thief,
                    ItemCategoryID = (int)ItemCategoriesList.Knife,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Thief,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Thief,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Mystic

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Mystic,
                    PspName = "Mystic",
                    HPMultiplier = 75,
                    HPGrowthConstant = 12,
                    MPMultiplier = 110,
                    MPGrowthConstant = 10,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 50,
                    PhysicalAttackGrowthConstant = 60,
                    MagicalAttackMultiplier = 120,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Mystic,
                    JobRequiredID = (int)Jobs.WhiteMage,
                    JobLevelRequiredPsx = 2,
                    JobLevelRequiredPsp = 3
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Mystic,
                    ItemCategoryID = (int)ItemCategoriesList.Pole,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Mystic,
                    ItemCategoryID = (int)ItemCategoriesList.Rod,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Mystic,
                    ItemCategoryID = (int)ItemCategoriesList.Staff,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Mystic,
                    ItemCategoryID = (int)ItemCategoriesList.Book,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Mystic,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Mystic,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Mystic,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Time Mage

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.TimeMage,
                    PspName = "Time Mage",
                    HPMultiplier = 75,
                    HPGrowthConstant = 12,
                    MPMultiplier = 120,
                    MPGrowthConstant = 10,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 50,
                    PhysicalAttackGrowthConstant = 65,
                    MagicalAttackMultiplier = 130,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.TimeMage,
                    JobRequiredID = (int)Jobs.BlackMage,
                    JobLevelRequiredPsx = 2,
                    JobLevelRequiredPsp = 3
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.TimeMage,
                    ItemCategoryID = (int)ItemCategoriesList.Staff,
                },
                new JobItem
                {
                    JobID = (int)Jobs.TimeMage,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.TimeMage,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                },
                new JobItem
                {
                    JobID = (int)Jobs.TimeMage,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Geomancer 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Geomancer,
                    PspName = "Geomancer",
                    HPMultiplier = 110,
                    HPGrowthConstant = 10,
                    MPMultiplier = 95,
                    MPGrowthConstant = 11,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 110,
                    PhysicalAttackGrowthConstant = 45,
                    MagicalAttackMultiplier = 105,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 4,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 10,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Geomancer,
                    JobRequiredID = (int)Jobs.Monk,
                    JobLevelRequiredPsx = 3,
                    JobLevelRequiredPsp = 4
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Geomancer,
                    ItemCategoryID = (int)ItemCategoriesList.Sword,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Geomancer,
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Geomancer,
                    ItemCategoryID = (int)ItemCategoriesList.Shield,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Geomancer,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Geomancer,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Geomancer,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Dragoon 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Dragoon,
                    PspName = "Dragoon",
                    HPMultiplier = 120,
                    HPGrowthConstant = 10,
                    MPMultiplier = 50,
                    MPGrowthConstant = 15,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 120,
                    PhysicalAttackGrowthConstant = 40,
                    MagicalAttackMultiplier = 50,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 4,
                    BaseCombatEvasion = 15,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Dragoon,
                    JobRequiredID = (int)Jobs.Thief,
                    JobLevelRequiredPsx = 3,
                    JobLevelRequiredPsp = 4
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Dragoon,
                    ItemCategoryID = (int)ItemCategoriesList.Polearm,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Dragoon,
                    ItemCategoryID = (int)ItemCategoriesList.Shield,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Dragoon,
                    ItemCategoryID = (int)ItemCategoriesList.Helmet,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Dragoon,
                    ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Dragoon,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Orator 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Orator,
                    PspName = "Orator",
                    HPMultiplier = 80,
                    HPGrowthConstant = 11,
                    MPMultiplier = 70,
                    MPGrowthConstant = 18,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 75,
                    PhysicalAttackGrowthConstant = 55,
                    MagicalAttackMultiplier = 75,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Orator,
                    JobRequiredID = (int)Jobs.Mystic,
                    JobLevelRequiredPsx = 2,
                    JobLevelRequiredPsp = 3
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Orator,
                    ItemCategoryID = (int)ItemCategoriesList.Knife,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Orator,
                    ItemCategoryID = (int)ItemCategoriesList.Gun,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Orator,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Orator,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Orator,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Summoner

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Summoner,
                    PspName = "Summoner",
                    HPMultiplier = 70,
                    HPGrowthConstant = 13,
                    MPMultiplier = 125,
                    MPGrowthConstant = 8,
                    SpeedMulitplier = 90,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 50,
                    PhysicalAttackGrowthConstant = 70,
                    MagicalAttackMultiplier = 125,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Summoner,
                    JobRequiredID = (int)Jobs.TimeMage,
                    JobLevelRequiredPsp = 3
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Summoner,
                    ItemCategoryID = (int)ItemCategoriesList.Rod,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Summoner,
                    ItemCategoryID = (int)ItemCategoriesList.Staff,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Summoner,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Summoner,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Samurai 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Samurai,
                    PspName = "Samurai",
                    HPMultiplier = 75,
                    HPGrowthConstant = 12,
                    MPMultiplier = 75,
                    MPGrowthConstant = 14,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 128,
                    PhysicalAttackGrowthConstant = 45,
                    MagicalAttackMultiplier = 90,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 20,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Samurai,
                    JobRequiredID = (int)Jobs.Knight,
                    JobLevelRequiredPsp = 4,
                    JobLevelRequiredPsx = 3
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Samurai,
                    JobRequiredID = (int)Jobs.Monk,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Samurai,
                    JobRequiredID = (int)Jobs.Dragoon,
                    JobLevelRequiredPsp = 2,
                    JobLevelRequiredPsx = 2
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Samurai,
                    ItemCategoryID = (int)ItemCategoriesList.Katana,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Samurai,
                    ItemCategoryID = (int)ItemCategoriesList.Helmet,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Samurai,
                    ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Samurai,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Ninja 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Ninja,
                    PspName = "Ninja",
                    HPMultiplier = 70,
                    HPGrowthConstant = 12,
                    MPMultiplier = 50,
                    MPGrowthConstant = 13,
                    SpeedMulitplier = 120,
                    SpeedGrowthConstant = 80,
                    PhysicalAttackMultiplier = 120,
                    PhysicalAttackGrowthConstant = 43,
                    MagicalAttackMultiplier = 75,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 4,
                    BaseJumpHeight = 4,
                    BaseCombatEvasion = 30,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Ninja,
                    JobRequiredID = (int)Jobs.Archer,
                    JobLevelRequiredPsp = 4,
                    JobLevelRequiredPsx = 3
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Ninja,
                    JobRequiredID = (int)Jobs.Thief,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Ninja,
                    JobRequiredID = (int)Jobs.Geomancer,
                    JobLevelRequiredPsp = 2,
                    JobLevelRequiredPsx = 2
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Ninja,
                    ItemCategoryID = (int)ItemCategoriesList.Knife,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Ninja,
                    ItemCategoryID = (int)ItemCategoriesList.NinjaBlade,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Ninja,
                    ItemCategoryID = (int)ItemCategoriesList.Flail,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Ninja,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Ninja,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Arithmetician 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Arithmetician,
                    PspName = "Arithmetician",
                    HPMultiplier = 65,
                    HPGrowthConstant = 14,
                    MPMultiplier = 80,
                    MPGrowthConstant = 10,
                    SpeedMulitplier = 50,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 50,
                    PhysicalAttackGrowthConstant = 70,
                    MagicalAttackMultiplier = 70,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Arithmetician,
                    JobRequiredID = (int)Jobs.WhiteMage,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Arithmetician,
                    JobRequiredID = (int)Jobs.BlackMage,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Arithmetician,
                    JobRequiredID = (int)Jobs.Mystic,
                    JobLevelRequiredPsp = 4,
                    JobLevelRequiredPsx = 3
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Arithmetician,
                    JobRequiredID = (int)Jobs.TimeMage,
                    JobLevelRequiredPsp = 4,
                    JobLevelRequiredPsx = 3
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Arithmetician,
                    ItemCategoryID = (int)ItemCategoriesList.Pole,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Arithmetician,
                    ItemCategoryID = (int)ItemCategoriesList.Book,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Arithmetician,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Arithmetician,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Arithmetician,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                }
            );

            #endregion

            #region Dancer 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Dancer,
                    PspName = "Dancer",
                    IsFemaleOnly = true,
                    HPMultiplier = 60,
                    HPGrowthConstant = 20,
                    MPMultiplier = 50,
                    MPGrowthConstant = 20,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 110,
                    PhysicalAttackGrowthConstant = 50,
                    MagicalAttackMultiplier = 95,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Dancer,
                    JobRequiredID = (int)Jobs.Geomancer,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Dancer,
                    JobRequiredID = (int)Jobs.Dragoon,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Dancer,
                    ItemCategoryID = (int)ItemCategoriesList.Knife,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Dancer,
                    ItemCategoryID = (int)ItemCategoriesList.Cloth,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Dancer,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Dancer,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Bard 

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Bard,
                    PspName = "Bard",
                    IsMaleOnly = true,
                    HPMultiplier = 55,
                    HPGrowthConstant = 20,
                    MPMultiplier = 50,
                    MPGrowthConstant = 20,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 30,
                    PhysicalAttackGrowthConstant = 80,
                    MagicalAttackMultiplier = 115,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Bard,
                    JobRequiredID = (int)Jobs.Summoner,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Bard,
                    JobRequiredID = (int)Jobs.Orator,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.Bard,
                    ItemCategoryID = (int)ItemCategoriesList.Instrument,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Bard,
                    ItemCategoryID = (int)ItemCategoriesList.Hat,
                },
                new JobItem
                {
                    JobID = (int)Jobs.Bard,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Mime

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.Mime,
                    PspName = "Mime",
                    HPMultiplier = 140,
                    HPGrowthConstant = 6,
                    MPMultiplier = 50,
                    MPGrowthConstant = 30,
                    SpeedMulitplier = 120,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 120,
                    PhysicalAttackGrowthConstant = 35,
                    MagicalAttackMultiplier = 115,
                    MagicalAttackGrowthConstant = 40,
                    BaseMoveLength = 4,
                    BaseJumpHeight = 4,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Mime,
                    JobRequiredID = (int)Jobs.Squire,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 8
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Mime,
                    JobRequiredID = (int)Jobs.Chemist,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 8
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Mime,
                    JobRequiredID = (int)Jobs.Geomancer,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Mime,
                    JobRequiredID = (int)Jobs.Dragoon,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Mime,
                    JobRequiredID = (int)Jobs.Orator,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.Mime,
                    JobRequiredID = (int)Jobs.Summoner,
                    JobLevelRequiredPsp = 5,
                    JobLevelRequiredPsx = 4
                }
            );

            #endregion

            #region Dark Knight

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.DarkKnight,
                    PspName = "Dark Knight",
                    HPMultiplier = 80,
                    HPGrowthConstant = 12,
                    MPMultiplier = 90,
                    MPGrowthConstant = 20,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 140,
                    PhysicalAttackGrowthConstant = 40,
                    MagicalAttackMultiplier = 80,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 0,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.DarkKnight,
                    JobRequiredID = (int)Jobs.Knight,
                    JobLevelRequiredPsp = -1
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.DarkKnight,
                    JobRequiredID = (int)Jobs.BlackMage,
                    JobLevelRequiredPsp = -1
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.DarkKnight,
                    JobRequiredID = (int)Jobs.Geomancer,
                    JobLevelRequiredPsp = 8
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.DarkKnight,
                    JobRequiredID = (int)Jobs.Dragoon,
                    JobLevelRequiredPsp = 8
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.DarkKnight,
                    JobRequiredID = (int)Jobs.Samurai,
                    JobLevelRequiredPsp = 8
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.DarkKnight,
                    JobRequiredID = (int)Jobs.Ninja,
                    JobLevelRequiredPsp = 8
                }
            );

            context.JobItems.AddOrUpdate(m => m.JobItemCategoryID,
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.Sword,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.FellSword,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.Axe,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.KnightSword,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.Flail,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.Shield,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.Helmet,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.HeavyArmour,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.Robe,
                },
                new JobItem
                {
                    JobID = (int)Jobs.DarkKnight,
                    ItemCategoryID = (int)ItemCategoriesList.Clothes,
                }
            );

            #endregion

            #region Onion Knight Basic

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.OnionKnightBasic,
                    PspName = "Onion Knight (1 - 7)",
                    HPMultiplier = 50,
                    HPGrowthConstant = 13,
                    MPMultiplier = 50,
                    MPGrowthConstant = 13,
                    SpeedMulitplier = 100,
                    SpeedGrowthConstant = 100,
                    PhysicalAttackMultiplier = 50,
                    PhysicalAttackGrowthConstant = 80,
                    MagicalAttackMultiplier = 50,
                    MagicalAttackGrowthConstant = 50,
                    BaseMoveLength = 3,
                    BaseJumpHeight = 3,
                    BaseCombatEvasion = 5,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.OnionKnightBasic,
                    JobRequiredID = (int)Jobs.Squire,
                    JobLevelRequiredPsp = 6
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.OnionKnightBasic,
                    JobRequiredID = (int)Jobs.Chemist,
                    JobLevelRequiredPsp = 6
                }
            );

            #endregion

            #region Onion Knight Mastered

            context.Jobs.AddOrUpdate(m => m.PspName,
                new Job
                {
                    JobID = (int)Jobs.OnionKnightMastered,
                    PspName = "Onion Knight (8)",
                    HPMultiplier = 150,
                    HPGrowthConstant = 6,
                    MPMultiplier = 140,
                    MPGrowthConstant = 8,
                    SpeedMulitplier = 120,
                    SpeedGrowthConstant = 80,
                    PhysicalAttackMultiplier = 130,
                    PhysicalAttackGrowthConstant = 35,
                    MagicalAttackMultiplier = 120,
                    MagicalAttackGrowthConstant = 40,
                    BaseMoveLength = 4,
                    BaseJumpHeight = 4,
                    BaseCombatEvasion = 30,
                }
            );

            context.JobPrerequisites.AddOrUpdate(m => m.JobPrerequisitesID,
                new JobPrerequisites
                {
                    JobID = (int)Jobs.OnionKnightMastered,
                    JobRequiredID = (int)Jobs.Squire,
                    JobLevelRequiredPsp = 6
                },
                new JobPrerequisites
                {
                    JobID = (int)Jobs.OnionKnightMastered,
                    JobRequiredID = (int)Jobs.Chemist,
                    JobLevelRequiredPsp = 6
                }
            );

            #endregion

            #endregion

            #region Abilities

            #region White Mage

            context.Abilities.AddOrUpdate(m => new { m.JobID, m.PspName },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Cure",
                AbilityType = (int)AbilityType.Command,
                MPCost = 6,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 25,
                JpNeededToLearnPsp = 50,
                Description = "White Magick that soothes injuries, restoring HP.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                HealingEquation = "(14 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Life's refreshing breeze, blow in energy! Cure!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Cura",
                PsxName = "Cure 2",
                AbilityType = (int)AbilityType.Command,
                MPCost = 10,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 20,
                JpNeededToLearnPsp = 180,
                Description = "White Magick that soothes injuries, restoring HP.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                HealingEquation = "(20 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Life's refreshing breeze, heal from the sky! Cure2!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Curaga",
                PsxName = "Cure 3",
                AbilityType = (int)AbilityType.Command,
                MPCost = 16,
                Range = 4,
                Radius = 2,
                Height = 2,
                Speed = 15,
                JpNeededToLearnPsp = 450,
                Description = "White Magick that soothes injuries, restoring HP.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                HealingEquation = "(30 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Blessing breeze, blow in energy! Cure3!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Curaja",
                PsxName = "Cure 4",
                AbilityType = (int)AbilityType.Command,
                MPCost = 20,
                Range = 4,
                Radius = 2,
                Height = 3,
                Speed = 10,
                JpNeededToLearnPsp = 800,
                JpNeededToLearnPsx = 700,
                Description = "White Magick that soothes injuries, restoring HP.",
                CanBeReflected = false,
                UsedWithArithmetics = false,
                HealingEquation = "(40 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Mighty breeze, heal from the sky! Cure4!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Raise",
                AbilityType = (int)AbilityType.Command,
                MPCost = 10,
                Range = 4,
                Radius = 1,
                Speed = 25,
                JpNeededToLearnPsp = 200,
                JpNeededToLearnPsx = 180,
                Description = "White Magick to fetch a warrior from the brink of death.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                HealingEquation = "Restores 50% of Max HP.",
                SuccessRateEquation = "(180 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                RemoveStatusEffect = "KO",
                Quote = "Spirits of life, return to us! Raise!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Arise",
                PsxName = "Raise 2",
                AbilityType = (int)AbilityType.Command,
                MPCost = 20,
                Range = 4,
                Radius = 1,
                Speed = 10,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 500,
                Description = "White Magick to fetch a warrior from the brink of death and fully restore HP as well.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                HealingEquation = "Restores 100% of Max HP.",
                SuccessRateEquation = "(160 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                RemoveStatusEffect = "KO",
                Quote = "Spirits of life, give a new life to the soul! Raise2!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Reraise",
                AbilityType = (int)AbilityType.Command,
                MPCost = 16,
                Range = 3,
                Radius = 1,
                Speed = 15,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 800,
                Description = "White Magick that endows a unit with a protective force that will revive him or her only once after being KO'd.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Reraise",
                SuccessRateEquation = "(140 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Inject life's energy! Reraise!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Regen",
                AbilityType = (int)AbilityType.Command,
                MPCost = 8,
                Range = 3,
                Radius = 2,
                Height = 0,
                Speed = 25,
                JpNeededToLearnPsp = 350,
                JpNeededToLearnPsx = 300,
                Description = "White Magick that invigorates the life force, gradually restoring HP as long as its protection is in effect.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Regen",
                SuccessRateEquation = "(170 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Share lives with all things in nature.... Regen!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Protect",
                AbilityType = (int)AbilityType.Command,
                MPCost = 6,
                Range = 3,
                Radius = 2,
                Height = 0,
                Speed = 25,
                JpNeededToLearnPsp = 70,
                Description = "White Magick that conjures up invisible armor made of air to protect the body from direct blows.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Protect",
                SuccessRateEquation = "(200 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Precious light, be our armor to protect us! Protect!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Protectja",
                PsxName = "Protect 2",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 3,
                Radius = 2,
                Height = 3,
                Speed = 15,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 500,
                Description = "White Magick that conjures up invisible armor made of air to protect the body from direct blows.",
                CanBeReflected = false,
                UsedWithArithmetics = false,
                AddStatusEffect = "Protect",
                SuccessRateEquation = "(120 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Shining light, shield from all directions! Protect2!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Shell",
                AbilityType = (int)AbilityType.Command,
                MPCost = 6,
                Range = 3,
                Radius = 2,
                Height = 0,
                Speed = 25,
                JpNeededToLearnPsp = 70,
                Description = "White Magick that conjures up invisible, mystical veil to protect the body from magick.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Shell",
                SuccessRateEquation = "(200 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Silent light, shield from evil! Shell!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Shellja",
                PsxName = "Shell 2",
                AbilityType = (int)AbilityType.Command,
                MPCost = 20,
                Range = 3,
                Radius = 2,
                Height = 3,
                Speed = 15,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 500,
                Description = "White Magick that conjures up invisible, mystical veil to protect the body from magick.",
                CanBeReflected = false,
                UsedWithArithmetics = false,
                AddStatusEffect = "Shell",
                SuccessRateEquation = "(120 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Enduring light, shield from roaring magic! Shell2!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Wall",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 3,
                Radius = 1,
                Height = 0,
                Speed = 25,
                JpNeededToLearnPsp = 400,
                JpNeededToLearnPsx = 380,
                Description = "White Magick that conjures up an invisible barrier to protect the body from physical and magickal blows.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Protect, Shell",
                SuccessRateEquation = "(140 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Ancient light, rise and revive! Wall!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Esuna",
                AbilityType = (int)AbilityType.Command,
                MPCost = 18,
                Range = 3,
                Radius = 2,
                Height = 2,
                Speed = 34,
                JpNeededToLearnPsp = 300,
                JpNeededToLearnPsx = 280,
                Description = "White Magick that removes negative status effects.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                RemoveStatusEffect = "Stone, Blind, Confuse, Silence, Berserk, Toad, Poison, Sleep, Immobilize, Disable",
                SuccessRateEquation = "(190 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Heavenly wind, carry us to a fountain of power! Esuna!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Holy",
                AbilityType = (int)AbilityType.Command,
                MPCost = 56,
                Range = 5,
                Radius = 1,
                Height = 0,
                Speed = 17,
                JpNeededToLearnPsp = 600,
                Description = "White Magick that attacks the target with sacred light.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                Element = "Holy",
                SuccessRateEquation = "(50 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Bright light, shine down on bloody impurity! Holy!"
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Regenerate",
                PsxName = "Regenerator",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 400,
                Description = "Receive the blessing of HP regeneration.",
                Trigger = "HP Loss",
                AddStatusEffect = "Regen",
            },
            new Ability
            {
                JobID = (int)Jobs.WhiteMage,
                PspName = "Arcane Defense",
                PsxName = "Magic DefendUP",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                Description = "Take less damage from magickal attacks.",
            });

            #endregion

            #region Squire

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Focus",
                PsxName = "Accumulate",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                Description = "Increase physical attack power.",
                AmountBoost = "+1 Physical Attack"
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Rush",
                PsxName = "Dash",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                JpNeededToLearnPsp = 80,
                Description = "Attack by ramming into the enemy's body.",
                DamageEquation = "Physical Attack x (Random: 1 to 4)"
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Stone",
                PsxName = "Throw Stone",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = -1,
                JpNeededToLearnPsp = 90,
                Description = "Lob a stone at a far-off foe.",
                DamageEquation = "Physical Attack x (Random: 1 to 2)"
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Salve",
                PsxName = "Heal",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 2,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "Remove several status ailments.",
                RemoveStatusEffect = "Blind, Silence, Poison"
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Counter Tackle",
                AbilityType = (int)AbilityType.Reaction,
                Trigger = "Physical Attack",
                JpNeededToLearnPsp = 180,
                Description = "Counterattack with a tackle."
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Equip Axes",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 170,
                ItemEquipIDs = ItemCategoriesList.Axe.ToString(),
                Description = "Equip axes, regardless of job."
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Beastmaster",
                PsxName = "Monster Skill",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 200,
                Description = "Add an ability to all monsters in neighboring tiles with an elevation difference of 3h or less."
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Defend",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 50,
                Description = "Defend oneself against an attack. Adds the Defend command."
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "JP Boost",
                PsxName = "Gained JP Up",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 250,
                Description = "Increase the amount of JP earned in battle."
            },
            new Ability
            {
                JobID = (int)Jobs.Squire,
                PspName = "Move +1",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 200,
                MoveBoost = 1,
                Description = "Increase Move by 1."
            });

            #endregion

            #region Chemist 

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Potion",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 30,
                HPRestored = 30,
                Description = "Use a potion to restore HP or inflict damage on the undead.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Hi-Potion",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                HPRestored = 70,
                Description = "Use a Hi-Potion to restore HP. A more potent draught than a Potion.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "X-Potion",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                HPRestored = 150,
                Description = "Use an X-Potion to restore HP. A more potent draught than a Hi-Potion.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Ether",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                MPRestored = 20,
                Description = "Use an ether to restore MP.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Hi-Ether",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 400,
                MPRestored = 50,
                Description = "Use a Hi-Ether to restore MP. A more potent draught than an Ether.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Elixir",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 900,
                Description = "Use an elixir to fully restore HP and MP.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Antidote",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 70,
                RemoveStatusEffect = "Poison",
                Description = "Use an antidote to nullify poison.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Eye Drops",
                PsxName = "Eye Drop",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 80,
                RemoveStatusEffect = "Blind",
                Description = "Use eye drops when vision has been magickally compromised.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Echo Herbs",
                PsxName = "Echo Grass",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 80,
                RemoveStatusEffect = "Silence",
                Description = "Use echo herbs to restore a unit's power of speech, permitting them to cast magicks once again.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Maiden's Kiss",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                RemoveStatusEffect = "Toad",
                Description = "Use a maiden's kiss to change a unit that has been transformed into a toad back to its original form.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Gold Needle",
                PsxName = "Soft",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 250,
                RemoveStatusEffect = "Stone",
                Description = "Use a gold needle to change a petrified unit back to normal. Breaks after one use.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Holy Water",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 400,
                RemoveStatusEffect = "Undead, Vampire",
                Description = "Use holy water to lift the curse of undeath from a unit.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Remedy",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 700,
                RemoveStatusEffect = "Poison, Blind, Silence, Toad, Stone, Confuse, Oil, Sleep",
                Description = "Use a remedy to cure various status effects.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Phoenix Down",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 90,
                RemoveStatusEffect = "KO",
                Description = "Use phoenix down to restore life to a fallen unit. Vanishes after one use.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Auto Potion",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 400,
                Trigger = "HP Loss",
                Description = "Use a Potion to restore HP.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Throw Items",
                PsxName = "Throw Item",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 350,
                Description = "Throw items within an increased radius, even if not a Chemist.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Safeguard",
                PsxName = "Maintenance",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 250,
                Description = "Prevent equipment from being destroyed or stolen.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Reequip",
                PsxName = "Equip Change",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 0,
                Description = "Change equipment mid-battle. Adds the Reequip command.",
            },
            new Ability
            {
                JobID = (int)Jobs.Chemist,
                PspName = "Treasure Hunter",
                PsxName = "Move-Find Item",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 100,
                Description = "Discover items hidden on tiles upon moving to them.",
            });

            #endregion

            #region Knight

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend Helm",
                PsxName = "Head Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                AddStatusEffect = "Destroy Headgear",
                SuccessRateEquation = "45 + Physical Attack + Weapon Strength",
                Description = "A technique that destroys the item equipped on the target's head.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend Armor",
                PsxName = "Armor Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 400,
                AddStatusEffect = "Destroy Armor",
                SuccessRateEquation = "40 + Physical Attack + Weapon Strength",
                Description = "A technique that destroys the item equipped on the target's body.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend Shield",
                PsxName = "Shield Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                AddStatusEffect = "Destroy Shield",
                SuccessRateEquation = "55 + Physical Attack + Weapon Strength",
                Description = "A technique that destroys the target's equipped shield.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend Weapon",
                PsxName = "Weapon Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 400,
                AddStatusEffect = "Destroy Weapon",
                SuccessRateEquation = "30 + Physical Attack + Weapon Strength",
                Description = "A technique that destroys the target's equipped weapon.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend MP",
                PsxName = "Magic Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 250,
                AmountDamage = "50% of Target's Max MP",
                SuccessRateEquation = "50 + Physical Attack",
                Description = "A technique that reduces the target's MP.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend Speed",
                PsxName = "Speed Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 250,
                AmountDamage = "-2 Speed",
                SuccessRateEquation = "50 + Physical Attack",
                Description = "A technique that reduces the target's Speed.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend Power",
                PsxName = "Power Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 250,
                AmountDamage = "-3 Physical Attack",
                SuccessRateEquation = "50 + Physical Attack",
                Description = "A technique that reduces the target's physical attack power.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Rend Magick",
                PsxName = "Mind Break",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 250,
                AmountDamage = "-3 Magic Attack",
                SuccessRateEquation = "50 + Physical Attack",
                Description = "A technique that reduces the target's magickal attack power.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Parry",
                PsxName = "Weapon Guard",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 200,
                Trigger = "Physical Attack",
                Description = "Block physical attacks with the equipped weapon.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Equip Heavy Armor",
                PsxName = "Equip Armor",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 500,
                ItemEquipIDs = String.Format("{0}, {1}", ItemCategoriesList.HeavyArmour, ItemCategoriesList.Helmet),
                Description = "Equip helms and armor, regardless of job.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Equip Shields",
                PsxName = "Equip Shield",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 250,
                ItemEquipIDs = ItemCategoriesList.Shield.ToString(),
                Description = "Equip shields, regardless of job.",
            },
            new Ability
            {
                JobID = (int)Jobs.Knight,
                PspName = "Equip Swords",
                PsxName = "Equip Sword",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                ItemEquipIDs = ItemCategoriesList.Sword.ToString(),
                Description = "Equip swords, regardless of job.",
            });

            #endregion

            #region Archer 

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +1",
                PsxName = "Charge +1",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +2",
                PsxName = "Charge +2",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +3",
                PsxName = "Charge +3",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +4",
                PsxName = "Charge +4",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 250,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +5",
                PsxName = "Charge +5",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +7",
                PsxName = "Charge +7",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 400,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +10",
                PsxName = "Charge +10",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 700,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Aim +20",
                PsxName = "Charge +20",
                AbilityType = (int)AbilityType.Command,
                Range = -1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 1200,
                Description = "Carefully aim to strike for increased damage. Attack power increases with longer charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Adrenaline Rush",
                PsxName = "Speed Save",
                AbilityType = (int)AbilityType.Reaction,
                Trigger = "HP Loss",
                JpNeededToLearnPsp = 900,
                Description = "Increase Speed.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Archer's Bane",
                PsxName = "Arrow Guard",
                AbilityType = (int)AbilityType.Reaction,
                Trigger = "Bow/Crossbow Attack",
                JpNeededToLearnPsp = 450,
                Description = "Dodge arrow and bolt attacks.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Equip Crossbows",
                AbilityType = (int)AbilityType.Support,
                ItemEquipIDs = ItemCategoriesList.Crossbow.ToString(),
                JpNeededToLearnPsp = 350,
                Description = "Equip crossbows, regardless of job.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Concentrate",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                Description = "	Make attacks unblockable. If an enemy is in the targeted tile, it will always be a hit.",
            },
            new Ability
            {
                JobID = (int)Jobs.Archer,
                PspName = "Jump +1",
                AbilityType = (int)AbilityType.Movement,
                JumpBoost = 1,
                JpNeededToLearnPsp = 200,
                Description = "Increase Jump by 1.",
            });

            #endregion

            #region Black Mage

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Fire",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 25,
                MPCost = 6,
                CanBeReflected = true,
                UsedWithArithmetics = true,
                Element = "Fire",
                DamageEquation = "(14 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Destruction of nature, gather in flame! Fire!",
                JpNeededToLearnPsp = 50,
                Description = "Black magick that envelops targets in ferocious flames.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Fira",
                PsxName = "Fire 2",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 2,
                Speed = 20,
                MPCost = 12,
                CanBeReflected = true,
                UsedWithArithmetics = true,
                Element = "Fire",
                DamageEquation = "(18 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Out of the ground, raze all greenery with flame! Fire2!",
                JpNeededToLearnPsp = 200,
                Description = "Black magick that envelops targets in ferocious flames.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Firaga",
                PsxName = "Fire 3",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 3,
                Speed = 15,
                MPCost = 24,
                CanBeReflected = true,
                UsedWithArithmetics = true,
                Element = "Fire",
                DamageEquation = "(24 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Star fire, awaken and deliver your judgment! Fire3!",
                JpNeededToLearnPsp = 500,
                Description = "Black magick that envelops targets in ferocious flames.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Firaja",
                PsxName = "Fire 4",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 3,
                Height = 3,
                Speed = 10,
                MPCost = 48,
                Element = "Fire",
                DamageEquation = "(32 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Smoldering flames far below, punish the wicked! Fire4!",
                JpNeededToLearnPsp = 900,
                JpNeededToLearnPsx = 850,
                Description = "Black magick that envelops targets in ferocious flames.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Thunder",
                PsxName = "Bolt",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 25,
                MPCost = 6,
                CanBeReflected = true,
                UsedWithArithmetics = true,
                Element = "Lightning",
                DamageEquation = "(14 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Strip away the ground with glistening blades! Bolt!",
                JpNeededToLearnPsp = 50,
                Description = "Black magick that strikes targets with lightning.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Thundara",
                PsxName = "Bolt 2",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 2,
                Speed = 20,
                MPCost = 10,
                CanBeReflected = true,
                UsedWithArithmetics = true,
                Element = "Lightning",
                DamageEquation = "(18 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Swirling bolts, gather and strike with power! Bolt2!",
                JpNeededToLearnPsp = 200,
                Description = "Black magick that strikes targets with lightning.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Thundaga",
                PsxName = "Bolt 3",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 3,
                Speed = 15,
                MPCost = 24,
                CanBeReflected = true,
                UsedWithArithmetics = true,
                Element = "Lightning",
                DamageEquation = "(24 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Heavenly bolts, come bring God's judgement! Bolt3!",
                JpNeededToLearnPsp = 500,
                Description = "Black magick that strikes targets with lightning.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Thundaja",
                PsxName = "Bolt 4",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 3,
                Height = 3,
                Speed = 10,
                MPCost = 48,
                Element = "Lightning",
                DamageEquation = "(32 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Angry spirits of the world strike now! Bolt4!",
                JpNeededToLearnPsp = 900,
                JpNeededToLearnPsx = 850,
                Description = "Black magick that strikes targets with lightning.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Blizzard",
                PsxName = "Ice",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 25,
                MPCost = 6,
                UsedWithArithmetics = true,
                CanBeReflected = true,
                Element = "Ice",
                DamageEquation = "(14 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Scatter your chilly sharp blades! Ice!",
                JpNeededToLearnPsp = 50,
                Description = "Black magick that conjures forth bone-chilling icicles.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Blizzara",
                PsxName = "Ice 2",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 2,
                Speed = 20,
                MPCost = 12,
                UsedWithArithmetics = true,
                CanBeReflected = true,
                JpNeededToLearnPsp = 200,
                Element = "Ice",
                DamageEquation = "(18 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Drifting breeze, come down with fury! Ice2!",
                Description = "Black magick that conjures forth bone-chilling icicles.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Blizzaga",
                PsxName = "Ice 3",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 3,
                Speed = 15,
                MPCost = 24,
                UsedWithArithmetics = true,
                CanBeReflected = true,
                JpNeededToLearnPsp = 500,
                Element = "Ice",
                DamageEquation = "(24 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Freezing wind, speak of forgotten truths! Ice3!",
                Description = "Black magick that conjures forth bone-chilling icicles.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Blizzaja",
                PsxName = "Ice 4",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 3,
                Height = 3,
                Speed = 10,
                MPCost = 48,
                JpNeededToLearnPsp = 900,
                JpNeededToLearnPsx = 850,
                Element = "Ice",
                DamageEquation = "(32 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Effortless water, break your silence, attack! Ice4!",
                Description = "Black magick that conjures forth bone-chilling icicles.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Poison",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 2,
                Height = 0,
                Speed = 34,
                MPCost = 6,
                UsedWithArithmetics = true,
                CanBeReflected = true,
                JpNeededToLearnPsp = 150,
                AddStatusEffect = "Poison",
                SuccessRateEquation = "(160 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Filthy blood of revenge, inject! Poison!",
                Description = "Black magick that induces poisoning within the body, causing a gradual loss of HP.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Toad",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Speed = 20,
                MPCost = 12,
                UsedWithArithmetics = true,
                CanBeReflected = true,
                JpNeededToLearnPsp = 500,
                AddStatusEffect = "Toad",
                SuccessRateEquation = "(120 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Know, live, become a frog! Frog!",
                Description = "Black magick that turns its target into a toad, or reverts a toad to its natural form.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Death",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Height = 0,
                Speed = 10,
                MPCost = 24,
                UsedWithArithmetics = true,
                CanBeReflected = true,
                JpNeededToLearnPsp = 500,
                AddStatusEffect = "KO",
                SuccessRateEquation = "(100 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Death gods carving life, take their souls! Death!",
                Description = "Black magick that offers up the target's soul to the spirits of the dead for an instant KO.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Flare",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 1,
                Height = 0,
                Speed = 15,
                MPCost = 60,
                UsedWithArithmetics = true,
                CanBeReflected = true,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 900,
                SuccessRateEquation = "(46 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Inscript the dark god into a rotting body! Flare!",
                Description = "Black magick that converts energy into heat, scorching the battlefield with searing temperatures.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Magick Counter",
                PsxName = "Counter Magic",
                AbilityType = (int)AbilityType.Reaction,
                Trigger = "Magick",
                JpNeededToLearnPsp = 800,
                Description = "Counterattack using the same magick with which the user was attacked.",
            },
            new Ability
            {
                JobID = (int)Jobs.BlackMage,
                PspName = "Arcane Strength",
                PsxName = "Magic AttackUP",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                MagicAttackModifier = true,
                Description = "Inflict greater damage with magickal attacks.",
            });

            #endregion

            #region Monk

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Cyclone",
                PsxName = "Spin Fist",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 2,
                Height = 0,
                Speed = -1,
                DamageEquation = "0.5 x Physical Attack x (Physical Attack)",
                JpNeededToLearnPsp = 150,
                Description = "Turn in a circle, attacking with backhand blows.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Pummel",
                PsxName = "Repeating Fist",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                Quote = "Fight for justice... fists of fury! Repeated Fist!",
                DamageEquation = "3.0 x Physical Attack x (Random: 1 to 9)",
                Description = "Strike many times in quick succession.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Aurablast",
                PsxName = "Wave Fist",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                DamageEquation = "0.5 x Physical Attack x (Physical Attack + 2)",
                Quote = "Burning anger rising... Burst! Wave Fist!",
                Description = "Employ one's martial spirit to strike a distant foe.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Shockwave",
                PsxName = "Earth Slash",
                AbilityType = (int)AbilityType.Command,
                Range = 8,
                Radius = -1,
                Speed = -1,
                Height = 2,
                Element = "Earth",
                JpNeededToLearnPsp = 600,
                DamageEquation = "0.5 x Physical Attack x (Physical Attack)",
                Quote = "Earth's anger running through my arms! Earth Slash!",
                Description = "Release spiritual energy mighty enough to rend the earth.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Doom Fist",
                PsxName = "Secret Fist",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                SuccessRateEquation = "50 + Magic Attack",
                AddStatusEffect = "Doom",
                Quote = "Cast down to hell with your fingers! Secret Fist!",
                Description = "Invite slow, certain death with blows to pressure points.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Purification",
                PsxName = "Stigma Magic",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 2,
                Speed = -1,
                Height = 0,
                JpNeededToLearnPsp = 200,
                SuccessRateEquation = "120 + Physical Attack",
                RemoveStatusEffect = "Stone, Blind, Confuse, Silence, Berserk, Toad, Poison, Sleep, Immobilize, Disable",
                Description = "Release positive energy to remove status ailments.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Chakra",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 2,
                Speed = -1,
                Height = 0,
                JpNeededToLearnPsp = 350,
                HealingEquation = "5 x Physical Attack",
                EnergizeEquation = "5 x Physical Attack / 2",
                Description = "Draw out the energy within the body's chakra points to restore HP and MP.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Revive",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Speed = -1,
                Height = 0,
                JpNeededToLearnPsp = 500,
                RemoveStatusEffect = "KO",
                HealingEquation = "Restores 20% of Max HP",
                SuccessRateEquation = "70 + Physical Attack",
                Description = "Calls back dead units with a loud cry.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Critical: Recover HP",
                PsxName = "HP Restore",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 500,
                Trigger = "Critical",
                Description = "Recover HP when critically wounded.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Counter",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 300,
                Trigger = "Physical Attack",
                Description = "Counterattack with a physical strike.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "First Strike",
                PsxName = "Hamedo",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 1300,
                JpNeededToLearnPsx = 1200,
                Trigger = "Physical Attack",
                Description = "Attack preemptively before being attacked.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Brawler",
                PsxName = "Martial Arts",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 200,
                Description = "Deliver more powerful unarmed attacks, even if not a monk.",
            },
            new Ability
            {
                JobID = (int)Jobs.Monk,
                PspName = "Lifefont",
                PsxName = "Move-HP Up",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 300,
                Description = "Recover HP upon moving.",
            });

            #endregion

            #region Thief

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal Gil",
                PsxName = "Gil Taking",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                AmountDamage = "Level x Speed",
                SuccessRateEquation = "200 + Speed",
                JpNeededToLearnPsp = 10,
                Description = "Pilfer gil from the target.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal Heart",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = -1,
                Speed = -1,
                AddStatusEffect = "Charm",
                SuccessRateEquation = "50 + Magic Attack",
                JpNeededToLearnPsp = 150,
                Description = "Capture the target's heart, enthralling them.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal Helmet",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                SuccessRateEquation = "40 + Speed",
                JpNeededToLearnPsp = 350,
                Description = "Purloin the target's equipped helmet.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal Armor",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                SuccessRateEquation = "35 + Speed",
                JpNeededToLearnPsp = 450,
                Description = "Purloin the target's equipped armor.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal Shield",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                SuccessRateEquation = "35 + Speed",
                JpNeededToLearnPsp = 350,
                Description = "Purloin the target's equipped shield.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal Weapon",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                SuccessRateEquation = "30 + Speed",
                JpNeededToLearnPsp = 600,
                Description = "Purloin the target's equipped weapon.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal Accessory",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                SuccessRateEquation = "40 + Speed",
                JpNeededToLearnPsp = 500,
                Description = "Purloin the target's equipped accessory.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Steal EXP",
                PsxName = "Steal Exp",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 1,
                Height = 1,
                Speed = -1,
                AmountDamage = "5 + Speed",
                SuccessRateEquation = "70 + Speed",
                JpNeededToLearnPsp = 250,
                Description = "Filch experience points from the target.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Vigilance",
                PsxName = "Caution",
                AbilityType = (int)AbilityType.Reaction,
                AddStatusEffect = "Defending",
                JpNeededToLearnPsp = 200,
                Trigger = "HP Loss",
                Description = "Assume a defensive stance.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Gil Snapper",
                PsxName = "Gilgame Heart",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 200,
                Trigger = "HP Loss",
                Description = "Receive gil equal to the amount of damage taken.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Sticky Fingers",
                PsxName = "Catch",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 200,
                Trigger = "Throw",
                Description = "Catch thrown items and add them to the party inventory.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Poach",
                PsxName = "Secret Hunt",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 200,
                Description = "Deliver slain monsters' remains to a poachers' den.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Move +2",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 560,
                JpNeededToLearnPsx = 520,
                MoveBoost = 2,
                Description = "Increase Move by 2.",
            },
            new Ability
            {
                JobID = (int)Jobs.Thief,
                PspName = "Jump +2",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 500,
                JpNeededToLearnPsx = 480,
                JumpBoost = 2,
                Description = "Increase Jump by 2.",
            });

            #endregion

            #region Mystic

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Umbra",
                PsxName = "Blind",
                AbilityType = (int)AbilityType.Command,
                MPCost = 4,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 50,
                JpNeededToLearnPsp = 100,
                Description = "Rob targets of sight, reducing the success rate of their physical attacks.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Blind",
                SuccessRateEquation = "(200 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "All light fall into darkness! Bound darkness!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Empowerment",
                PsxName = "Spell Absorb",
                AbilityType = (int)AbilityType.Command,
                MPCost = 2,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 50,
                JpNeededToLearnPsp = 200,
                Description = "Absorb MP from the target.",
                MpDrainedEquation = "Absorb 33% of Target's Max MP",
                SuccessRateEquation = "(160 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Guiding light, shed magic power from above! Spell Absorb!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Invigoration",
                PsxName = "Life Drain",
                AbilityType = (int)AbilityType.Command,
                MPCost = 16,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 50,
                JpNeededToLearnPsp = 350,
                Description = "Absorb HP from the target.",
                HealthDrainedEquation = "Absorb 25% of Target's Max HP",
                SuccessRateEquation = "(160 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Lost energy... raise the heartrate! Life Drain!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Belief",
                PsxName = "Pray Faith",
                AbilityType = (int)AbilityType.Command,
                MPCost = 6,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 25,
                JpNeededToLearnPsp = 400,
                Description = "Fill the target's soul with a zealous fervor.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Faith",
                SuccessRateEquation = "(150 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "God is watching...have faith! Pray Faith!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Disbelief",
                PsxName = "Doubt Faith",
                AbilityType = (int)AbilityType.Command,
                MPCost = 6,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 25,
                JpNeededToLearnPsp = 400,
                Description = "Drain the target's soul of piety.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Atheist",
                SuccessRateEquation = "(150 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Seek the true tone to form our will... Doubt Faith!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Corruption",
                PsxName = "Zombie",
                AbilityType = (int)AbilityType.Command,
                MPCost = 20,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 20,
                JpNeededToLearnPsp = 300,
                Description = "Transform the target into one of the walking dead.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Undead",
                SuccessRateEquation = "(100 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Great tree of life, inject rotten extract! Zombie!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Quiescence",
                PsxName = "Silence Song",
                AbilityType = (int)AbilityType.Command,
                MPCost = 16,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 34,
                JpNeededToLearnPsp = 300,
                Description = "Rob targets of speech, rendering them unable to cast magicks.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Silence",
                SuccessRateEquation = "(180 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Conjurors, seek truth in silence... Silence Song!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Fervor",
                PsxName = "Blind Rage",
                AbilityType = (int)AbilityType.Command,
                MPCost = 16,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 20,
                JpNeededToLearnPsp = 400,
                Description = "Impart a thirst for destruction, rendering the target mad for blood.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Berserk",
                SuccessRateEquation = "(120 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Reason with confusion, judge with recklessness... Brave Insanity!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Trepidation",
                PsxName = "Foxbird",
                AbilityType = (int)AbilityType.Command,
                MPCost = 20,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 25,
                JpNeededToLearnPsp = 200,
                Description = "Reduce the target's Bravery.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AmountDamage = "-30 Bravery",
                SuccessRateEquation = "(140 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Cowards, weak, those rushing to die! Foxbird!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Delirium",
                PsxName = "Confusion Song",
                AbilityType = (int)AbilityType.Command,
                MPCost = 20,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 20,
                JpNeededToLearnPsp = 400,
                Description = "Cause the target to become delirious and act irrationally.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Confuse",
                SuccessRateEquation = "(130 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Smash all who hunger for destruction... Confusion Song!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Harmony",
                PsxName = "Dispel Magic",
                AbilityType = (int)AbilityType.Command,
                MPCost = 34,
                Range = 4,
                Radius = 1,
                Height = -1,
                Speed = 34,
                JpNeededToLearnPsp = 800,
                Description = "Neutralize beneficial status effects on the target.",
                UsedWithArithmetics = true,
                RemoveStatusEffect = "Float, Reraise, Invisible, Regen, Protect, Shell, Haste, Faith, Reflect",
                SuccessRateEquation = "(200 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Illusions, lies, to heaven! Dispel Magic!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Hesitation",
                PsxName = "Paralyze",
                AbilityType = (int)AbilityType.Command,
                MPCost = 10,
                Range = 4,
                Radius = 2,
                Height = 0,
                Speed = 20,
                JpNeededToLearnPsp = 100,
                Description = "Render the target incapable of action.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Disable",
                SuccessRateEquation = "(185 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Mindless, spiritless, hear the immutable beat... Paralyze!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Repose",
                PsxName = "Sleep",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 17,
                JpNeededToLearnPsp = 350,
                Description = "Put the target into a deep slumber.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Sleep",
                SuccessRateEquation = "(170 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Lose conscious, wash away into the silent sea... Sleep!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Induration",
                PsxName = "Petrify",
                AbilityType = (int)AbilityType.Command,
                MPCost = 16,
                Range = 4,
                Radius = 1,
                Height = 1,
                Speed = 10,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 580,
                Description = "Turn the target's body into stone.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Stone",
                SuccessRateEquation = "(120 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Suffering spirits, to eternity! Break Seal!",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Absorb MP",
                PsxName = "Absorb Used MP",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 250,
                Description = "Recover MP equal to the amount used by the opponent.",
                Trigger = "Magick",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Defense Boost",
                PsxName = "Defense UP",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                Description = "Take less damage from physical attacks.",
                PhysicalDefenceModifier = true,
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Ignore Weather",
                PsxName = "Any Weather",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 200,
                Description = "Traverse any marsh, swamp, or poisonous fen unimpeded by weather conditions.",
            },
            new Ability
            {
                JobID = (int)Jobs.Mystic,
                PspName = "Manafont",
                PsxName = "Move-MP Up",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 350,
                Description = "Recover MP upon moving.",
            });

            #endregion

            #region Time Mage

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Haste",
                AbilityType = (int)AbilityType.Command,
                MPCost = 8,
                Range = 3,
                Radius = 2,
                Height = 0,
                Speed = 50,
                JpNeededToLearnPsp = 100,
                Description = "Time magick that hastens the passage of time for its targets, effectively boosting their Speed.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Haste",
                SuccessRateEquation = "(180 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Layer upon layer make your mark now... Haste!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Hasteja",
                PsxName = "Haste 2",
                AbilityType = (int)AbilityType.Command,
                MPCost = 30,
                Range = 3,
                Radius = 2,
                Height = 3,
                Speed = 15,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 550,
                Description = "Time magick that hastens the passage of time for its targets, effectively boosting their Speed.",
                AddStatusEffect = "Haste",
                SuccessRateEquation = "(240 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Times current, place me in your whirlpool! Haste2!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Slow",
                AbilityType = (int)AbilityType.Command,
                MPCost = 8,
                Range = 3,
                Radius = 2,
                Height = 0,
                Speed = 50,
                JpNeededToLearnPsp = 80,
                Description = "Time magick that inhibits the passage of time for its targets, effectively reducing their Speed.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Slow",
                SuccessRateEquation = "(180 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Time, rest and give your kindness to the worthy! Slow!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Slowja",
                PsxName = "Slow 2",
                AbilityType = (int)AbilityType.Command,
                MPCost = 30,
                Range = 3,
                Radius = 2,
                Height = 3,
                Speed = 15,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 520,
                Description = "Time magick that inhibits the passage of time for its targets, effectively reducing their Speed.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Slow",
                SuccessRateEquation = "(240 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Obey the sky's will, slow time down! Slow2!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Stop",
                AbilityType = (int)AbilityType.Command,
                MPCost = 14,
                Range = 3,
                Radius = 2,
                Height = 0,
                Speed = 15,
                JpNeededToLearnPsp = 350,
                JpNeededToLearnPsx = 330,
                Description = "Time magick that halts the passage of time for its targets, preventing them from receiving turns.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Stop",
                SuccessRateEquation = "(110 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Spirits of time, Hide us from the judging hand of God! Stop!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Immobilize",
                PsxName = "Don't Move",
                AbilityType = (int)AbilityType.Command,
                MPCost = 10,
                Range = 3,
                Radius = 2,
                Height = 1,
                Speed = 34,
                JpNeededToLearnPsp = 100,
                Description = "Time magick that creates an anomaly in space to prevent its targets from moving.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Immobilize",
                SuccessRateEquation = "(190 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Land of all lives, suppress all rebels! Don't Move!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Float",
                AbilityType = (int)AbilityType.Command,
                MPCost = 8,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 50,
                JpNeededToLearnPsp = 200,
                Description = "Time magick that warps space, allowing its targets to float a height of 1h above the ground.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Float",
                SuccessRateEquation = "(140 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Land of mercy, loosen tight fists! Float!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Reflect",
                AbilityType = (int)AbilityType.Command,
                MPCost = 12,
                Range = 4,
                Radius = 1,
                Height = 0,
                Speed = 50,
                JpNeededToLearnPsp = 300,
                Description = "Time magick that creates a magick-reflecting field.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AddStatusEffect = "Reflect",
                SuccessRateEquation = "(180 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Spell break, turn into a avenging light! Reflect!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Quick",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 4,
                Radius = 1,
                Height = 0,
                Speed = 25,
                JpNeededToLearnPsp = 900,
                JpNeededToLearnPsx = 800,
                Description = "Time magick that hastens the localized passage of time, causing the target's turn to come more quickly.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                SuccessRateEquation = "(140 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Restore lost time in the spiral line... Quick!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Gravity",
                PsxName = "Demi",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 4,
                Radius = 2,
                Height = 1,
                Speed = 17,
                JpNeededToLearnPsp = 250,
                Description = "Time magick that conjures up a supermassive field, inflicting damage with powerful gravitational forces.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AmountDamage = "25% of target's Max HP",
                SuccessRateEquation = "(190 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Revenge with dark-evil spell! Demi!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Graviga",
                PsxName = "Demi 2",
                AbilityType = (int)AbilityType.Command,
                MPCost = 50,
                Range = 4,
                Radius = 2,
                Height = 3,
                Speed = 12,
                JpNeededToLearnPsp = 550,
                Description = "Time magick that conjures up a supermassive field, inflicting damage with powerful gravitational forces.",
                CanBeReflected = true,
                UsedWithArithmetics = true,
                AmountDamage = "50% of target's Max HP",
                SuccessRateEquation = "(120 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Black sheep of evil times, cover our light! Demi2!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Meteor",
                AbilityType = (int)AbilityType.Command,
                MPCost = 70,
                Range = 4,
                Radius = 4,
                Height = 3,
                Speed = 8,
                JpNeededToLearnPsp = 1500,
                Description = "Time magick that warps space-time, causing an enormous meteor to fall on the battlefield.",
                DamageEquation = "(40 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Time has come... crash down on the wicked! Meteor!",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Critical: Quick",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 800,
                JpNeededToLearnPsx = 700,
                Description = "Receive an immediate turn when critically wounded.",
                Trigger = "Critical"
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Mana Shield",
                PsxName = "MP Switch",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 400,
                Description = "Damage is dealt to MP rather than HP.",
                Trigger = "HP Loss"
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Swiftness",
                PsxName = "Short Charge",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 800,
                Description = "Shorten charge time.",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Teleport",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 650,
                JpNeededToLearnPsx = 600,
                Description = "Warp instantly to destination tiles. May fail when attempting to travel to distant locations.",
            },
            new Ability
            {
                JobID = (int)Jobs.TimeMage,
                PspName = "Levitate",
                PsxName = "Float",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 540,
                Description = "Move while floating a height of 1h above the ground.",
            });

            #endregion

            #region Geomancer 

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Sinkhole",
                PsxName = "Pitfall",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage by opening rifts in space-time.",
                Terrain = "Soil, Wasteland, Road",
                AddStatusEffect = "Immobilize",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Torrent",
                PsxName = "Water Ball",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of water.",
                Terrain = "Canal, River, Lake, Ocean, Waterfall",
                Element = "Water",
                AddStatusEffect = "Toad",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Tanglevine",
                PsxName = "Hell's Ivy",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of plants.",
                Terrain = "Grassland, Underbrush, Vines",
                AddStatusEffect = "Stop",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Contortion",
                PsxName = "Carve Model",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of stone.",
                Terrain = "Gravel, Flagstone, Stone Wall, Earthen Wall, Gravestone",
                AddStatusEffect = "Stone",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Tremor",
                PsxName = "Local Quake",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of rock.",
                Terrain = "Stone Outcropping, Basalt",
                Element = "Earth",
                AddStatusEffect = "Confuse",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Wind Slash",
                PsxName = "Kamaitachi",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of air.",
                Terrain = "Book, Tree, Brick, Bridge, Furnishings, Iron Plate, Moss, Coffin",
                Element = "Wind",
                AddStatusEffect = "Disable",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Will-o'-the-Wisp",
                PsxName = "Demon Fire",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of the surrounding terrain.",
                Terrain = "Wooden Floor, Carpet, Coffer, Stairs, Wooden Deck",
                Element = "Fire",
                AddStatusEffect = "Sleep",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Quicksand",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of water.",
                Terrain = "Marsh, Swamp, Poisonous Fen",
                Element = "Water",
                AddStatusEffect = "Doom",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Sandstorm",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of dust.",
                Terrain = "Sand, Stalactite, Salt Flat",
                Element = "Wind",
                AddStatusEffect = "Blind",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Snowstorm",
                PsxName = "Blizzard",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of snow.",
                Terrain = "Snow, Ice",
                Element = "Ice",
                AddStatusEffect = "Silence",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Wind Blast",
                PsxName = "Gusty Wind",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of wind.",
                Terrain = "Roof, Chimney",
                Element = "Wind",
                AddStatusEffect = "Slow",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Magma Surge",
                PsxName = "Lava Ball",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 2,
                Height = 0,
                Speed = -1,
                JpNeededToLearnPsp = 150,
                Description = "A geomancy skill that inflicts damage with the power of magma.",
                Terrain = "Lava, Machinery",
                Element = "Fire",
                AddStatusEffect = "KO",
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Nature's Wrath",
                PsxName = "Counter Flood",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 300,
                Description = "Counterattack with a geomancy skill.",
                Trigger = "Physical Attack, Geomancy"
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Attack Boost",
                PsxName = "Attack UP",
                PhysicalAttackModifier = true,
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                Description = "Inflict greater damage with physical attacks."
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Ignore Terrain",
                PsxName = "Any Ground",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 220,
                Description = "Move unimpeded through watery terrain."
            },
            new Ability
            {
                JobID = (int)Jobs.Geomancer,
                PspName = "Lava Walking",
                PsxName = "Move on Lava",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 150,
                Description = "Walk across and even stop on the surface of lava."
            });

            #endregion

            #region Dragoon 

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Horizontal Jump 2",
                AbilityType = (int)AbilityType.Command,
                Range = 2,
                Radius = 1,
                Height = 0,
                JpNeededToLearnPsp = 150,
                Description = "Jump 2 tiles horizontally."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Horizontal Jump 3",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 0,
                JpNeededToLearnPsp = 350,
                JpNeededToLearnPsx = 300,
                Description = "Jump 3 tiles horizontally."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Horizontal Jump 4",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 1,
                Height = 0,
                JpNeededToLearnPsp = 550,
                JpNeededToLearnPsx = 450,
                Description = "Jump 4 tiles horizontally."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Horizontal Jump 5",
                AbilityType = (int)AbilityType.Command,
                Range = 5,
                Radius = 1,
                Height = 0,
                JpNeededToLearnPsp = 800,
                JpNeededToLearnPsx = 600,
                Description = "Jump 5 tiles horizontally."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Horizontal Jump 8",
                AbilityType = (int)AbilityType.Command,
                Range = 8,
                Radius = 1,
                Height = 0,
                JpNeededToLearnPsp = 1100,
                JpNeededToLearnPsx = 900,
                Description = "Jump 8 tiles horizontally."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Vertical Jump 2",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Height = 2,
                JpNeededToLearnPsp = 100,
                Description = "Jump 2 tiles vertically."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Vertical Jump 3",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Height = 3,
                JpNeededToLearnPsp = 250,
                JpNeededToLearnPsx = 200,
                Description = "Jump 3 tiles vertically."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Vertical Jump 4",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Height = 4,
                JpNeededToLearnPsp = 400,
                JpNeededToLearnPsx = 300,
                Description = "Jump 4 tiles vertically."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Vertical Jump 5",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Height = 5,
                JpNeededToLearnPsp = 550,
                JpNeededToLearnPsx = 400,
                Description = "Jump 5 tiles vertically."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Vertical Jump 6",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Height = 6,
                JpNeededToLearnPsp = 700,
                JpNeededToLearnPsx = 500,
                Description = "Jump 6 tiles vertically."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Vertical Jump 7",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Height = 7,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 600,
                Description = "Jump 7 tiles vertically."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Vertical Jump 8",
                AbilityType = (int)AbilityType.Command,
                Range = 0,
                Radius = 1,
                Height = 8,
                JpNeededToLearnPsp = 1050,
                JpNeededToLearnPsx = 900,
                Description = "Jump 8 tiles vertically."
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Dragonheart",
                PsxName = "Dragon Spirit",
                AbilityType = (int)AbilityType.Reaction,
                Description = "Recover from KO status.",
                AddStatusEffect = "Reraise",
                Trigger = "Physical Attack",
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 560,
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Equip Polearms",
                PsxName = "Equip Spears",
                AbilityType = (int)AbilityType.Support,
                Description = "Equip polearms, regardless of job.",
                ItemEquipIDs = ItemCategoriesList.Polearm.ToString(),
                JpNeededToLearnPsp = 400
            },
            new Ability
            {
                JobID = (int)Jobs.Dragoon,
                PspName = "Ignore Elevation",
                PsxName = "Ignore Height",
                AbilityType = (int)AbilityType.Movement,
                Description = "Move to tiles of any height, regardless of Jump attribute.",
                JpNeededToLearnPsp = 700
            });

            #endregion

            #region Orator

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Entice",
                PsxName = "Invitation",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "A speechcraft skill that persuades a foe to become an ally.",
                AddStatusEffect = "Traitor",
                SuccessRateEquation = "20 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Stall",
                PsxName = "Persuade",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "A speechcraft skill that persuades a foe to wait before acting. Resets the target's CT count.",
                SuccessRateEquation = "30 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Praise",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                Description = "A speechcraft skill that praises the target's feats and strengths, increasing his or her Bravery.",
                AmountBoost = "+4 Bravery",
                SuccessRateEquation = "50 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Intimidate",
                PsxName = "Threaten",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                Description = "A speechcraft skill that plays upon the doubts and fears of the target, decreasing his or her Bravery.",
                AmountBoost = "-20 Bravery",
                SuccessRateEquation = "90 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Preach",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                Description = "A speechcraft skill that explains the nature of divine miracles, deepening belief and increasing Faith.",
                AmountBoost = "+4 Faith",
                SuccessRateEquation = "50 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Enlighten",
                PsxName = "Solution",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                Description = "A speechcraft skill that decreases Faith by using cold logic and secular doctrine.",
                AmountBoost = "-20 Faith",
                SuccessRateEquation = "90 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Condemn",
                PsxName = "Death Sentence",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 500,
                Description = "A speechcraft skill that convinces the target that his or her demise is soon at hand.",
                AddStatusEffect = "Doom",
                SuccessRateEquation = "30 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Beg",
                PsxName = "Negotiate",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "A speechcraft skill that spins tales in return for gil.",
                AmountBoost = "Level x Speed",
                SuccessRateEquation = "90 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Insult",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                Description = "A speechcraft skill that infuriates with foul invective.",
                AddStatusEffect = "Berserk",
                SuccessRateEquation = "40 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Mimic Darlavon",
                PsxName = "Mimic Daravon",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 2,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                Description = "A speechcraft skill that uses dull tales to induce slumber.",
                AddStatusEffect = "Sleep",
                SuccessRateEquation = "40 + Magic Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Earplug",
                PsxName = "Finger Guard",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 300,
                Description = "Avoid the effects of Speechcraft.",
                Trigger = "Speechcraft"
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Equip Guns",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 800,
                JpNeededToLearnPsx = 750,
                Description = "Equip guns, regardless of job.",
                ItemEquipIDs = ItemCategoriesList.Gun.ToString(),
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Tame",
                PsxName = "Train",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 500,
                JpNeededToLearnPsx = 450,
                Description = "Force a critically wounded enemy monster to become an ally."
            },
            new Ability
            {
                JobID = (int)Jobs.Orator,
                PspName = "Beast Tongue",
                PsxName = "Monster Talk",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 100,
                Description = "Gain the ability to use Speechcraft against monsters, even if not an orator."
            });

            #endregion

            #region Summoner

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Moogle",
                AbilityType = (int)AbilityType.Command,
                MPCost = 8,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 34,
                JpNeededToLearnPsp = 110,
                Description = "An esper that soothes injuries with a purifying breeze, restoring HP.",
                HealingEquation = "(10 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Kupo! Round and round you go! Moogle!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Shiva",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 25,
                JpNeededToLearnPsp = 200,
                Description = "An esper with punishingly frigid breath.",
                Element = "Ice",
                DamageEquation = "(20 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Wind, fade to silence and light, give us power! Shiva!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Ramuh",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 25,
                JpNeededToLearnPsp = 200,
                Description = "An esper that relentlessly rains down lightning.",
                Element = "Lightning",
                DamageEquation = "(20 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Master of creation, impart thy help! Ramuh!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Ifrit",
                AbilityType = (int)AbilityType.Command,
                MPCost = 24,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 25,
                JpNeededToLearnPsp = 200,
                Description = "An esper whose breath of flame scorches the battlefield.",
                Element = "Fire",
                DamageEquation = "(20 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "King of flames, burn into cinders! Ifrit!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Titan",
                AbilityType = (int)AbilityType.Command,
                MPCost = 30,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 20,
                JpNeededToLearnPsp = 220,
                Description = "An esper that levels the earth with a mighty blow.",
                Element = "Earth",
                DamageEquation = "(22 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Bear down with land energy! Titan!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Golem",
                AbilityType = (int)AbilityType.Command,
                MPCost = 40,
                Range = -1,
                Radius = -1,
                Height = -1,
                Speed = 34,
                JpNeededToLearnPsp = 500,
                Description = "An esper that absorbs damage from physical attacks on behalf of allies until its limit is reached.",
                SuccessRateEquation = "(200 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Earth-minded soul, protect us! Golem!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Carbuncle",
                PsxName = "Carbunkle",
                AbilityType = (int)AbilityType.Command,
                MPCost = 30,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 25,
                JpNeededToLearnPsp = 350,
                Description = "An esper whose ruby light reflects magicks cast on allies.",
                AddStatusEffect = "Reflect",
                SuccessRateEquation = "(150 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Impart light to fight our holy war! Carbunkle!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Bahamut",
                AbilityType = (int)AbilityType.Command,
                MPCost = 60,
                Range = 4,
                Radius = 4,
                Height = 3,
                Speed = 10,
                JpNeededToLearnPsp = 1600,
                Description = "An esper that attacks with its fearsome breath.",
                DamageEquation = "(42 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Scorch with dragon flame! Bahamut!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Odin",
                AbilityType = (int)AbilityType.Command,
                MPCost = 50,
                Range = 4,
                Radius = 4,
                Height = 3,
                Speed = 12,
                JpNeededToLearnPsp = 900,
                Description = "An esper that charges through the battlefield astride a fearsome mount, doing great damage.",
                DamageEquation = "(36 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Slash away with the Land's fury! Odin!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Leviathan",
                AbilityType = (int)AbilityType.Command,
                MPCost = 48,
                Range = 4,
                Radius = 4,
                Height = 3,
                Speed = 12,
                JpNeededToLearnPsp = 860,
                JpNeededToLearnPsx = 850,
                Description = "An esper that engulfs the battlefield in a massive tidal wave.",
                Element = "Water",
                DamageEquation = "(34 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Sea fang, attack with water's power! Leviathan!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Salamander",
                AbilityType = (int)AbilityType.Command,
                MPCost = 48,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 12,
                JpNeededToLearnPsp = 860,
                JpNeededToLearnPsx = 820,
                Description = "An esper that scorches the battlefield with its savage flames.",
                Element = "Fire",
                DamageEquation = "(34 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Evil flames, entrust your power to us! Salamander!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Sylph",
                PsxName = "Silf",
                AbilityType = (int)AbilityType.Command,
                MPCost = 26,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 20,
                JpNeededToLearnPsp = 400,
                Description = "An esper that employs the lingering life force of windswept leaves to silence enemies.",
                AddStatusEffect = "Silence",
                SuccessRateEquation = "(150 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Show us to put our lives back on track! Silf!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Faerie",
                PsxName = "Fairy",
                AbilityType = (int)AbilityType.Command,
                MPCost = 26,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 25,
                JpNeededToLearnPsp = 400,
                JpNeededToLearnPsx = 460,
                Description = "An esper that restores HP.",
                HealingEquation = "(20 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Shiny crystal light, energize! Fairy!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Lich",
                PsxName = "Rich",
                AbilityType = (int)AbilityType.Command,
                MPCost = 40,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 12,
                JpNeededToLearnPsp = 600,
                Description = "An esper born in, of, and to darkness. Deals out devastating dark damage.",
                Element = "Dark",
                DamageEquation = "50% of Target's Max HP",
                SuccessRateEquation = "(150 + Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Death song, death door, death river awaiting! Rich!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Cyclops",
                AbilityType = (int)AbilityType.Command,
                MPCost = 62,
                Range = 4,
                Radius = 3,
                Height = 2,
                Speed = 12,
                JpNeededToLearnPsp = 1000,
                Description = "An esper whose forceful blows tear the battlefield asunder.",
                DamageEquation = "(44 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Scatter frozen blades of air! Clops!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Zodiark",
                PsxName = "Zodiac",
                AbilityType = (int)AbilityType.Command,
                MPCost = 99,
                Range = 4,
                Radius = 4,
                Height = 3,
                Speed = 10,
                JpNeededToLearnPsp = -1,
                Description = "An esper that bathes the earth in radiant beams of focused starlight.",
                DamageEquation = "(90 x Magic Attack) x (Faith/100) x (TargetFaith/100)",
                Quote = "Attack by the Master of commandments! Zodiac!"
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Critical: Recover MP",
                PsxName = "MP Restore",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 400,
                Trigger = "Critical",
                Description = "Recover MP when critically wounded.",
            },
            new Ability
            {
                JobID = (int)Jobs.Summoner,
                PspName = "Halve MP",
                PsxName = "Half of MP",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 900,
                Description = "Reduce MP consumption by half when using magicks.",
            });

            #endregion

            #region Samurai

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Ashura",
                PsxName = "Asura Knife",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "A technique that releases the spirit in the user's katana, causing an unseen specter-sword to slash at the target.",
                DamageEquation = "8 x Magic Attack",
                Quote = "Legendary sword that kills freely! Asura!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Kotetsu",
                PsxName = "Koutetsu",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 200,
                JpNeededToLearnPsx = 180,
                Description = "A technique that releases the spirit in the user's katana, loosing a wave of howling dark spirits.",
                DamageEquation = "12 x Magic Attack",
                Quote = "Evil souls of the dark, gather here... Koutetsu!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Osafune",
                PsxName = "Bizen Boat",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                JpNeededToLearnPsx = 260,
                Description = "A technique that releases the spirit in the user's katana, sending the whispering dead to feed on the target's MP.",
                AmountDamage = "4 x Magic Attack",
                Quote = "Nihilistic sky, inhale magic power... Bizen Boat!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Murasame",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 400,
                JpNeededToLearnPsx = 340,
                Description = "A technique that releases the spirit in the user's katana, raining tears of an enlightened soul to restore HP.",
                HealingEquation = "12 x Magic Attack",
                Quote = "No more loss of precious life... Murasame!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Ame-no-Murakumo",
                PsxName = "Heaven's Cloud",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 500,
                JpNeededToLearnPsx = 420,
                Description = "A technique that releases the spirit in the user's katana, releasing a phantom of pure mist to attack the target.",
                AddStatusEffect = "Slow",
                DamageEquation = "14 x Magic Attack",
                Quote = "Yagumo rising, all who know god! Heaven's Cloud!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Kiyomori",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 500,
                Description = "A technique that releases the spirit in the user's katana, bestowing the protection of its effervescent life force.",
                AddStatusEffect = "Protect, Shell",
                Quote = "Innocent sword, slash evils and protect! Kiyomori!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Muramasa",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 700,
                JpNeededToLearnPsx = 580,
                Description = "A technique that releases the spirit in the user's katana. Only a living soul will quell its tumult.",
                AddStatusEffect = "Confuse, Doom",
                DamageEquation = "18 x Magic Attack",
                Quote = "Summon all ghosts of the sword! Attack! Muramasa!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Kiku-ichimonji",
                PsxName = "Kikuichimoji",
                AbilityType = (int)AbilityType.Command,
                Range = 4,
                Radius = 8,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 800,
                JpNeededToLearnPsx = 660,
                Description = "A technique that releases the spirit in the user's katana, wreaking havoc with its all-consuming hatred.",
                DamageEquation = "16 x Magic Attack",
                Quote = "Brave weapon, turn to a deadly blaze! Kikuichimoji!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Masamune",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 900,
                JpNeededToLearnPsx = 740,
                Description = "A technique that releases the spirit in the user's katana, bestowing physical healing and increased speed.",
                AddStatusEffect = "Regen, Haste",
                Quote = "Sword of fury, inject power! Masamune!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Chirijiraden",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 820,
                Description = "A technique that releases the spirit in the user's katana, which pursues the living as a band of blue flame.",
                DamageEquation = "30 x Magic Attack",
                Quote = "Flame-eating sword, swipe away the evils! Chirijiraden!"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Bonecrusher",
                PsxName = "Meatbone Slash",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 200,
                Description = "Deal damage equal to own maximum HP when critically wounded.",
                Trigger = "Critical"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Shirahadori",
                PsxName = "Blade Grasp",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 700,
                Description = "Evade non-ranged physical attacks.",
                Trigger = "Physical Attack"
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Equip Katana",
                PsxName = "Equip Knife",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                Description = "Equip katana, regardless of job.",
                ItemEquipIDs = ItemCategoriesList.Katana.ToString()
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Doublehand",
                PsxName = "Two Hands",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 900,
                Description = "Wield a weapon with both hands, increasing its destructive power."
            },
            new Ability
            {
                JobID = (int)Jobs.Samurai,
                PspName = "Swim",
                PsxName = "Move in Water",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 300,
                Description = "Swim through and even act in deep water."
            });

            #endregion

            #region Ninja

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Shuriken",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 50,
                Description = "Attack by throwing shuriken from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Bomb",
                PsxName = "Ball",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 70,
                Description = "Attack by throwing bombs from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Knife",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing knives from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Sword",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing swords from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Flail",
                PsxName = "Hammer",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing flails from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Katana",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing katana from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Ninja Blade",
                PsxName = "Ninja Sword",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing ninja blades from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Axe",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 120,
                Description = "Attack by throwing axes from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Polearm",
                PsxName = "Spear",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing polearms from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Pole",
                PsxName = "Stick",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing poles from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Knight's Sword",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing knight's swords from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Book",
                PsxName = "Dictionary",
                AbilityType = (int)AbilityType.Command,
                Radius = 1,
                Height = 3,
                Speed = -1,
                JpNeededToLearnPsp = 100,
                Description = "Attack by throwing books from inventory.",
                DamageEquation = "Speed x Weapon Power"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Vanish",
                PsxName = "Sunken State",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 900,
                Trigger = "Physical Attack",
                Description = "Become transparent.",
                AddStatusEffect = "Invisible"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Reflexes",
                PsxName = "Abandon",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 400,
                Trigger = "Always Activated",
                Description = "Block attacks with greater ease.",
                AddStatusEffect = "Doubles physical and magical Evade rates"
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Dual Wield",
                PsxName = "Two Swords",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 1000,
                JpNeededToLearnPsx = 900,
                Description = "Wield a weapon in each hand, attacking twice each turn, even if not a ninja.",
            },
            new Ability
            {
                JobID = (int)Jobs.Ninja,
                PspName = "Waterwalking",
                PsxName = "Walk on Water",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 420,
                Description = "Walk across and even stop on the surface of water.",
            });

            #endregion

            #region Arithmetician

            context.Abilities.AddOrUpdate(m => m.PspName,
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "CT",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 250,
                Description = "Base arithmetick algorithm on the target's CT."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Level",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 350,
                Description = "Base arithmetick algorithm on the target's level."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "EXP",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 200,
                Description = "Base arithmetick algorithm on the target's EXP."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Height",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 250,
                Description = "Base arithmetick algorithm on the height of the target's current tile."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Prime",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 300,
                Description = "An algorithm for targeting units whose specified attribute is a prime number. A prime number is a number only divisible by 1 and itself."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Multiple of 5",
                PsxName = "5",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 200,
                Description = "An algorithm for targeting units whose specified attribute is a multiple of 5."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Multiple of 4",
                PsxName = "4",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 400,
                Description = "An algorithm for targeting units whose specified attribute is a multiple of 4."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Multiple of 3",
                PsxName = "3",
                AbilityType = (int)AbilityType.Command,
                JpNeededToLearnPsp = 600,
                Description = "An algorithm for targeting units whose specified attribute is a multiple of 3."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Cup of Life",
                PsxName = "Distribute",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 200,
                Trigger = "HP Restored",
                Description = "When HP is restored, distribute any excess among one's allies."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Soulbind",
                PsxName = "Damage Split",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 300,
                Trigger = "HP Loss",
                Description = "Split any damage taken with the opponent who inflicted it."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "EXP Boost",
                PsxName = "Gained Exp UP",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 350,
                Description = "Earn more EXP for the same actions."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Accrue EXP",
                PsxName = "Move-Get Exp",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 400,
                Description = "Obtain EXP upon moving."
            },
            new Ability
            {
                JobID = (int)Jobs.Arithmetician,
                PspName = "Accrue JP",
                PsxName = "Move-Get JP",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 400,
                Description = "Obtain JP upon moving."
            });

            #endregion

            #region Dancer 

            context.Abilities.AddOrUpdate(m => new { m.JobID, m.PspName },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Witch Hunt",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 17,
                JpNeededToLearnPsp = 100,
                Description = "A dance whose esoteric moves reduce enemies' MP.",
                AmountDamage = "20 + Physical Attack"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Mincing Minuet",
                PsxName = "Wiznaibu",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 17,
                JpNeededToLearnPsp = 100,
                Description = "A dance whose fervent steps damage enemies' HP.",
                AmountDamage = "10 + Physical Attack"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Slow Dance",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 13,
                JpNeededToLearnPsp = 100,
                Description = "A dance whose sedate pace reduces enemies' Speed.",
                AmountDamage = "-1 Speed",
                SuccessRateEquation = "50% Accuracy Per Target"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Polka",
                PsxName = "Polka Polka",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 13,
                JpNeededToLearnPsp = 100,
                Description = "A quick, vivacious dance that reduces enemies' physical attack power.",
                AmountDamage = "-1 Physical Attack",
                SuccessRateEquation = "50% Accuracy Per Target"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Heathen Frolick",
                PsxName = "Disillusion",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 10,
                JpNeededToLearnPsp = 100,
                Description = "An exotic dance that clouds the mind, reducing enemies' magickal attack power.",
                AmountDamage = "-1 Magic Attack",
                SuccessRateEquation = "50% Accuracy Per Target"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Forbidden Dance",
                PsxName = "Nameless Dance",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 10,
                JpNeededToLearnPsp = 100,
                Description = "A mesmerizing dance that inflicts status effects.",
                AddStatusEffect = "Blind, Confuse, Silence, Toad, Poison, Slow, Stop, Sleep",
                SuccessRateEquation = "50% Accuracy Per Target"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Last Waltz",
                PsxName = "Last Dance",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 5,
                JpNeededToLearnPsp = 100,
                Description = "The ultimate dance. Drops the CT of all enemies to zero.",
                SuccessRateEquation = "50% Accuracy Per Target"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Fury",
                PsxName = "A Save",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 600,
                JpNeededToLearnPsx = 550,
                Description = "Increase physical attack power.",
                Trigger = "HP Loss",
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Bravery Boost",
                PsxName = "Brave UP",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 700,
                JpNeededToLearnPsx = 500,
                Description = "Increase Bravery.",
                Trigger = "Physical Attack",
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Jump +3",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 1000,
                JumpBoost = 3,
                Description = "Increase Jump by 3"
            },
            new Ability
            {
                JobID = (int)Jobs.Dancer,
                PspName = "Fly",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 5000,
                JpNeededToLearnPsx = 1200,
                Description = "Fly over enemies as well as any other obstacles."
            });

            #endregion

            #region Bard

            context.Abilities.AddOrUpdate(m => new { m.JobID, m.PspName },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Seraph Song",
                PsxName = "Angel Song",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 17,
                JpNeededToLearnPsp = 100,
                Description = "A song pleading for angelic protection. Restores MP.",
                AmountDamage = "20 + Magic Attack"
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Life's Anthem",
                PsxName = "Life Song",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 17,
                JpNeededToLearnPsp = 100,
                Description = "A song praising the vibrance of life. Restores HP.",
                AmountDamage = "10 + Magic Attack"
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Rousing Melody",
                PsxName = "Cheer Song",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 13,
                JpNeededToLearnPsp = 100,
                Description = "A song of encouragement and inspiration. Increases Speed.",
                AmountBoost = "+1 Speed",
                SuccessRateEquation = "50% Accuracy Per Target",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Battle Chant",
                PsxName = "Battle Song",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 13,
                JpNeededToLearnPsp = 100,
                Description = "A gallant song of battles fought and won. Increases physical attack power.",
                AmountBoost = "+1 Physical Attack",
                SuccessRateEquation = "50% Accuracy Per Target",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Magickal Refrain",
                PsxName = "Magic Song",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 10,
                JpNeededToLearnPsp = 100,
                Description = "A song of the laws of sorcery and of the source of magick.Increases magickal attack power.",
                AmountBoost = "+1 Magic Attack",
                SuccessRateEquation = "50% Accuracy Per Target",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Nameless Song",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 10,
                JpNeededToLearnPsp = 100,
                Description = "A thoroughly mysterious song passed down through many an age. Bestows various types of protection.",
                AddStatusEffect = "Reraise, Regen, Protect, Shell, Haste",
                SuccessRateEquation = "50% Accuracy Per Target",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Finale",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = -1,
                Speed = 5,
                JpNeededToLearnPsp = 100,
                Description = "The ultimate song. Increases allies' CT to 100.",
                SuccessRateEquation = "50% Accuracy Per Target",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Magick Boost",
                PsxName = "MA Save",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 500,
                JpNeededToLearnPsx = 450,
                Trigger = "HP Loss",
                Description = "Increase magickal attack power.",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Faith Boost",
                PsxName = "Face Up",
                AbilityType = (int)AbilityType.Reaction,
                JpNeededToLearnPsp = 700,
                JpNeededToLearnPsx = 500,
                Trigger = "Magick",
                Description = "Increase Faith.",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Move +3",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 1000,
                MoveBoost = 3,
                Description = "Increase Move by 3.",
            },
            new Ability
            {
                JobID = (int)Jobs.Bard,
                PspName = "Fly",
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 5000,
                JpNeededToLearnPsx = 1200,
                Description = "Fly over enemies as well as any other obstacles.",
            });

            #endregion

            #region Dark Knight

            context.Abilities.AddOrUpdate(m => new { m.JobID, m.PspName },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Sanguine Sword",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 500,
                Description = "Absorb HP from the target.",
                Element = "Dark",
                AmountDamage = "0.8 x Physical Attack x (Weapon Power + Ability Power)"
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Infernal Strike",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 1,
                Speed = -1,
                JpNeededToLearnPsp = 500,
                Description = "Absorb MP from the target.",
                Element = "Dark",
                AmountDamage = "0.8 x Physical Attack x (Weapon Power + Ability Power)"
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Crushing Blow",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 2,
                Speed = -1,
                JpNeededToLearnPsp = 300,
                Description = "Inflict damage with a sinister sword.",
                Element = "Dark",
                AddStatusEffect = "Stop",
                AmountDamage = "Physical Attack x (Weapon Power + Ability Power)"
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Abyssal Blade",
                AbilityType = (int)AbilityType.Command,
                Range = 3,
                Radius = 2,
                Speed = -1,
                JpNeededToLearnPsp = 1000,
                Description = "Sacrifice own HP to deal damage to others, with the nearest units suffering the most damage.",
                Element = "Dark",
                AmountDamage = "(Physical Attack x Magical Attack * Weapon Factor) + (0.33 * Maximum HP)"
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Unholy Sacrifice",
                AbilityType = (int)AbilityType.Command,
                Range = 1,
                Radius = 3,
                Speed = -1,
                JpNeededToLearnPsp = 1200,
                Description = "Sacrifice own HP to deal extensive damage to all units in range.",
                Element = "Dark",
                AddStatusEffect = "Slow",
                AmountDamage = "(Physical Attack x Magical Attack * Weapon Factor) + (0.33 * Maximum HP)"
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "HP Boost",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 2000,
                HpPercentBoost = 20,
                Description = "Increase maximum HP by 20 percent.",
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Vehemence",
                AbilityType = (int)AbilityType.Support,
                JpNeededToLearnPsp = 400,
                Description = "Increase attack power by 50 percent and decrease defensive power by 50 percent.",
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Jump +3",
                IsMaleOnly = true,
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 1000,
                JumpBoost = 3,
                Description = "Increase Jump by 3.",
            },
            new Ability
            {
                JobID = (int)Jobs.DarkKnight,
                PspName = "Move +3",
                IsFemaleOnly = true,
                AbilityType = (int)AbilityType.Movement,
                JpNeededToLearnPsp = 1000,
                MoveBoost = 3,
                Description = "Increase Movement by 3.",
            });

            #endregion

            #endregion

            #region Names

            string homePath = @"C:\Users\Braedon\Desktop\Braedon's Crap\Programming\FinalFantasyTacticsPartyBuilder\FinalFantasyTacticsPartyBuilder\";
            //string workPath = @"C:\Sandbox\FinalFantasyTacticsPartyBuilder\FinalFantasyTacticsPartyBuilder\";

            //foreach (string maleName in File.ReadAllLines(homePath + "FFTMaleNames.txt"))
            //{
            //    context.UnitNames.AddOrUpdate(m => m.Name,
            //    new UnitName
            //    {
            //        Name = maleName,
            //        Gender = (int)Gender.Male
            //    });
            //}

            //foreach (string maleName in File.ReadAllLines(homePath + "FFTFemaleNames.txt"))
            //{
            //    context.UnitNames.AddOrUpdate(m => m.Name,
            //    new UnitName
            //    {
            //        Name = maleName,
            //        Gender = (int)Gender.Female
            //    });
            //}

            //foreach (string maleName in File.ReadAllLines(homePath + "FFTMonsterNames.txt"))
            //{
            //    context.UnitNames.AddOrUpdate(m => m.Name,
            //    new UnitName
            //    {
            //        Name = maleName,
            //        Gender = (int)Gender.Monster
            //    });
            //}

            #endregion

            #region Dismissal Quotes

            #region Male
            context.Quotes.AddOrUpdate(m => m.QuoteID,
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "Then I shall go. I pray you do not come to regret your decision."
            },
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "You no longer need my services? Surely you do not mean that!"
            },
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "Won't you rethink this? We've come this far together."
            },
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "Are you sure? I had hoped I could continue lending my strength to your cause."
            },
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "This is certainly sudden. Do you truly believe you can manage without me?"
            },
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "So, you've no more use for me? You'd leave me behind now that I'm of no worth to you?"
            },
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "Are you certain about this? I'd thought us faster friends."
            },
            new Quote
            {
                Gender = (int)Gender.Male,
                Text = "Would that it came not to this! Are you sure it's for the best?"
            });

            #endregion

            #region Female
            context.Quotes.AddOrUpdate(m => m.QuoteID,
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "I see. Given the choice, I'd prefer to stay, but I understand if that is impossible."
            },
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "Surely you jest! If I leave now, what has all of this been for?"
            },
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "I thought I'd finally found my place. Are you sure you will not have me?"
            },
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "I beg you, do not say such things! I'll prove my worth to you, I swear it!"
            },
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "That...was not a jape? You wish for me to leave in earnest?"
            },
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "If that is your wish, there's naught I can do. Are you sure about this?"
            },
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "Pardon me for saying this, but are you not being a bit selfish? Will you not reconsider?"
            },
            new Quote
            {
                Gender = (int)Gender.Female,
                Text = "I do not wish to say farewell. Can I not remain with you a little longer?"
            });

            #endregion

            #endregion
        }
    }
}
