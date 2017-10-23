namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using Models;
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

        protected override void Seed(FFTContext context)
        {
            context.WeaponCategories.AddOrUpdate(m => m.Category,
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Axe, Category = "Axe" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Bag, Category = "Bag" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Book, Category = "Book" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Bow, Category = "Bow" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Cloth, Category = "Cloth" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Crossbow, Category = "Crossbow" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.FellSword, Category = "Fell Sword" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Flail, Category = "Flail" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Gun, Category = "Gun" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Instrument, Category = "Instrument" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Katana, Category = "Katana" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Knife, Category = "Knife" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.KnightSword, Category = "Knight Sword" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade, Category = "Ninja Blade" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Pole, Category = "Pole" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Rod, Category = "Rod" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Polearm, Category = "Polearm" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Staff, Category = "Staff" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Sword, Category = "Sword" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.ThrowingWeapon, Category = "Throwing Weapon" },
                new WeaponCategory { WeaponCategoryID = (int)WeaponCategoriesList.Unarmed, Category = "Unarmed" }
            );

            #region Axes
            context.Weapons.AddOrUpdate(m => m.PspName,
                new Weapon
                {
                    WeaponCategoryID = (int)WeaponCategoriesList.Axe,
                    PspName = "Battle Axe",
                    AttackPower = 9,
                    HitPercentage = 0,
                    AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                    AcquiredViaPoach = "Wisenkin",
                    AcquiredViaTreasureHunt = "Fovoham Windflats",
                    Description = "A battle axe with a long handle. Designed for two-handed use, it can easily chop off an enemy's limbs.",
                    Cost = 1500,
                    IconFileName = "BattleAxe-fft-psx.gif"
                },
                new Weapon
                {
                    WeaponCategoryID = (int)WeaponCategoriesList.Axe,
                    PspName = "Giant Axe",
                    AttackPower = 12,
                    HitPercentage = 0,
                    AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                    AcquiredViaPoach = "Wisenkin",
                    Description = "An axe with a large head. Much bigger than the traditional woodman's axe, hence its name.",
                    Cost = 4000,
                    IconFileName = "Giant'sAxe-fft-psx.gif"
                },
                new Weapon
                {
                    WeaponCategoryID = (int)WeaponCategoriesList.Axe,
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
                new Weapon
                {
                    WeaponCategoryID = (int)WeaponCategoriesList.Axe,
                    PspName = "Francisca",
                    AttackPower = 24,
                    HitPercentage = 0,
                    AcquiredViaMode = "Melee",
                    Description = "This axe's small size belies its incredible destructive power.",
                    Cost = 10,
                    IconFileName = "FFT_Francisca.png"
                },
                new Weapon
                {
                    WeaponCategoryID = (int)WeaponCategoriesList.Axe,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bag,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bag,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bag,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bag,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Book,
                PspName = "Battle Folio",
                PsxName = "Battle Dict",
                AttackPower = 7,
                HitPercentage = 15,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Clockwork City of Goug (rare)",
                Description = "A book made for battle.",
                Cost = 3000,
                IconFileName = "FFT_Battle_Folio.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Book,
                PspName = "Bestiary",
                PsxName = "Monster Dict",
                AttackPower = 8,
                HitPercentage = 15,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Description = "A thick book describing various beasts.",
                Cost = 6000,
                IconFileName = "FFT_Bestiary.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Book,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Book,
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
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Book,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
                PspName = "Longbow",
                AttackPower = 4,
                HitPercentage = 0,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Brigands' Den (rare)",
                Description = "The most common type of bow. It has a long range and is quite durable.",
                Cost = 800,
                IconFileName = "FFT_Longbow.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
                PspName = "Silver Bow",
                AttackPower = 5,
                HitPercentage = 0,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                AcquiredViaTreasureHunt = "Fovoham Windflats (rare)",
                Description = "A bow adorned with silver decorations. Thin metal plates help strengthen its wooden frame.",
                Cost = 1500,
                IconFileName = "FFT_Silver_Bow.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
                PspName = "Mythril Bow",
                AttackPower = 7,
                HitPercentage = 0,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Mining Town of Gollund (rare) and Monastery Vaults Second Level (rare)",
                Description = "A bow strengthened by thin plates of mythril.",
                Cost = 5000,
                IconFileName = "FFT_Mythril_Bow.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
                PspName = "Yoichi Bow",
                AttackPower = 12,
                HitPercentage = 0,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaMode = "Rendezvous",
                Description = "The bow of a legendary archer. Its unusual size gives it incredible power.",
                Cost = 10,
                IconFileName = "FFT_Yoichi_Bow.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
                PspName = "Perseus Bow",
                AttackPower = 16,
                HitPercentage = 0,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaMode = "Rendezvous",
                Description = "The bow of a mythical hero. It is constructed entirely of metal and requires great strength to pull back.",
                Cost = 10,
                IconFileName = "FFT_Perseus_Bow.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Bow,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Cloth,
                PspName = "Damask Cloth",
                PsxName = "Persia",
                AttackPower = 8,
                HitPercentage = 50,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Description = "This cloth is thick and brilliantly colored, making it perfect for use in carpets.",
                Cost = 7000,
                IconFileName = "FFT_Damask_Cloth.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Cloth,
                PspName = "Cashmere",
                AttackPower = 10,
                HitPercentage = 50,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Lake Poescas (rare)",
                Description = "This warm and flexible woolen fabric is exquisitely soft to the touch.",
                Cost = 15000,
                IconFileName = "FFT_Cashmere.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Cloth,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Crossbow,
                PspName = "Bowgun",
                AttackPower = 3,
                HitPercentage = 5,
                AcquiredViaLocation = "Meeting with Dycedarg at Eagrose Castle (Chapter 1)",
                Description = "A crossbow that can be fired with one hand. Uses shorter bolts than a traditional crossbow.",
                Cost = 400,
                IconFileName = "FFT_Bowgun.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Crossbow,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Crossbow,
                PspName = "Crossbow",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Clockwork City of Goug (rare)",
                Cost = 2000,
                Description = "The firing mechanism of this crossbow has been improved upon, increasing its attack power.",
                IconFileName = "FFT_Crossbow.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Crossbow,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Crossbow,
                PspName = "Hunting Bow",
                AttackPower = 6,
                HitPercentage = 5,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                AcquiredViaPoach = "Steelhawk",
                Cost = 8000,
                Description = "A crossbow mainly employed for hunting monsters.",
                IconFileName = "FFT_Hunting_Bow.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Crossbow,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.FellSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.FellSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.FellSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.FellSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.FellSword,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Flail,
                PspName = "Iron Flail",
                PsxName = "Flail",
                AttackPower = 9,
                HitPercentage = 0,
                AcquiredViaLocation = "Balias Swale (Chapter 2)",
                AcquiredViaTreasureHunt = "First battle Mining Town of Gollund (rare)",
                Cost = 1200,
                Description = "A weapon comprised of a large iron head attached to a long wooden handle.",
                IconFileName = "FFT_Iron_Flail.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Flail,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Flail,
                PspName = "Morning Star",
                AttackPower = 16,
                HitPercentage = 0,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Mount Germinas (rare)",
                Cost = 9000,
                Description = "A large spiked metal ball attached by chain to a wooden pole.",
                IconFileName = "FFT_Morning_Star.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Flail,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Flail,
                PspName = "Vesper",
                AttackPower = 36,
                HitPercentage = 0,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Description = "A weapon named after the evenstar.",
                IconFileName = "FFT_Vesper.png"
            });

            #endregion

            #region Guns
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Flail,
                PspName = "Iron Flail",
                PsxName = "Flail",
                AttackPower = 9,
                HitPercentage = 0,
                AcquiredViaLocation = "Balias Swale (Chapter 2)",
                AcquiredViaTreasureHunt = "First battle Mining Town of Gollund (rare)",
                Cost = 1200,
                Description = "A weapon comprised of a large iron head attached to a long wooden handle.",
                IconFileName = "FFT_Iron_Flail.gif"
            });

            #endregion
        }
    }
}
