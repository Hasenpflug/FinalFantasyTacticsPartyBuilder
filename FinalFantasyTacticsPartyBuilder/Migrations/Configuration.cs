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
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
                PspName = "Romandan Pistol",
                PsxName = "Romanda Gun",
                AttackPower = 6,
                HitPercentage = 5,
                AcquiredViaLocation = "Clockwork City of Goug (Chapter 2)",
                Cost = 5000,
                Description = "A firearm brought to Ivalice from the northern country of Romanda.",
                IconFileName = "FFT_Romandan_Pistol.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
                PspName = "Ras Algethi",
                AttackPower = 12,
                HitPercentage = 5,
                AcquiredViaMode = "Rendezvous",
                AcquiredViaInitialEquip = "Balthier",
                Cost = 28000,
                Description = "A firearm named for Ras Algethi, the star that forms the Kneeler's head.",
                IconFileName = "FFT_Ras_Algethi.png"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
                PspName = "Fomalhaut",
                AttackPower = 18,
                HitPercentage = 5,
                AcquiredViaMode = "Melee/Rendezvous",
                Cost = 10,
                Description = "A firearm named for the brightest star in the Whale's Maw.",
                IconFileName = "FFT_Fomalhaut.png"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Gun,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Instrument,
                PspName = "Lamia's Harp",
                AttackPower = 10,
                HitPercentage = 10,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Clockwork City of Goug (rare)",
                Cost = 5000,
                HitStatusEffect = "Confuse",
                Description = "The strains of this harp can affect one's very soul. Causes confusion in the listener.",
                IconFileName = "FFT_Lamia's_Harp.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Instrument,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Instrument,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
                PspName = "Ashura",
                PsxName = "Asura Knife",
                AttackPower = 7,
                HitPercentage = 15,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                Cost = 1600,
                Description = "A katana with a brilliant white blade.",
                IconFileName = "FFT_Ashura.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
                PspName = "Kotetsu",
                PsxName = "Koutetsu Knife",
                AttackPower = 8,
                HitPercentage = 15,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                Cost = 3000,
                Description = "A katana whose blade is adorned with a breathtaking carving of a tiger.",
                IconFileName = "FFT_Kotesu.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
                PspName = "Murasame",
                AttackPower = 10,
                HitPercentage = 15,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Monastery Vaults Second Level (rare)",
                Cost = 7000,
                Description = "Referred to as a demon sword, this katana's keen blade showers blood upon the battlefield.",
                IconFileName = "FFT_Murasame.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
                PspName = "Kiyomori",
                AttackPower = 12,
                HitPercentage = 15,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                Cost = 10000,
                Description = "This exquisitely crafted katana has a beautifully patterned blade and an incredible cutting edge.",
                IconFileName = "FFT_Kiyomori.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
                PspName = "Muramasa",
                AttackPower = 14,
                HitPercentage = 15,
                AcquiredViaLocation = "The Horror of Riovanes (Chapter 4)",
                AcquiredViaTreasureHunt = "Limberry Castle Keep (rare)",
                Cost = 15000,
                Description = "Referred to as a demon sword, this katana was said to drink the blood of countless enemies.",
                IconFileName = "FFT_Muramasa.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Katana,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
                PspName = "Dagger",
                AttackPower = 3,
                HitPercentage = 5,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 100,
                Description = "Used for self-defense. Although its blade is longer than that of a normal knife, its attack power is rather low.",
                IconFileName = "FFT_Dagger.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
                PspName = "Mythril Knife",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Meeting with Dycedarg at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter and Mining Town of Gollund (rare)",
                Cost = 500,
                Description = "A sturdy, well-balanced knife forged from the featherlight metal known as mythril.",
                IconFileName = "FFT_Mythril_Knife.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
                PspName = "Blind Knife",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                HitStatusEffect = "Blind",
                Cost = 800,
                Description = "A knife quenched in an insidious poison that robs its victim of sight.",
                IconFileName = "FFT_Blind_Knife.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
                PspName = "Platinum Dagger",
                AttackPower = 5,
                HitPercentage = 10,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaPoach = "Floating Eye, Malboro",
                Cost = 1800,
                Description = "A knife with a blade made of a lustrous white alloy of mythril and platinum.",
                IconFileName = "FFT_Platinum_Dagger.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
                PspName = "Assassin's Dagger",
                AttackPower = 7,
                HitPercentage = 5,
                AcquiredViaLocation = "Outfitters: Walled City of Yardrow (Chapter 3)",
                Cost = 5000,
                HitStatusEffect = "Doom",
                Description = "Popular among assassins, this dagger has the power to doom its victims to certain death.",
                IconFileName = "FFT_Assassin's_Dagger.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Knife,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.KnightSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.KnightSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.KnightSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.KnightSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.KnightSword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.KnightSword,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
                PspName = "Ninja Blade",
                PsxName = "Hidden Knife",
                AttackPower = 8,
                HitPercentage = 5,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                Cost = 3000,
                Description = "A sword specially tailored to the needs of ninjas. Its blade is shorter than that of the average sword.",
                IconFileName = "FFT_Ninja_Blade.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
                PspName = "Kodachi",
                PsxName = "Short Edge",
                AttackPower = 10,
                HitPercentage = 5,
                AcquiredViaLocation = "Orbonne Monastery (Chapter 3)",
                Cost = 7000,
                Description = "This sword's short, lightweight blade makes it very easy to carry.",
                IconFileName = "FFT_Kodachi.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
                PspName = "Koga Blade",
                AttackPower = 15,
                HitPercentage = 5,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                AcquiredViaCatch = "Level 96+ Ninja",
                Cost = 10,
                Description = "A powerful ninja sword that was once used by a secret society.",
                IconFileName = "FFT_Koga_Blade.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
                PspName = "Iga Blade",
                AttackPower = 15,
                HitPercentage = 10,
                AcquiredViaTreasureHunt = "Midlight's Deep",
                Cost = 10,
                Description = "An exquisitely crafted ninja sword that was once used by a secret society.",
                IconFileName = "FFT_Iga_Blade.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
                PspName = "Orochi",
                AttackPower = 20,
                HitPercentage = 5,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Note = "Absorbs foe's HP",
                Description = "A katana that strikes like a savage serpent.",
                IconFileName = "FFT_Orochi.png"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.NinjaBlade,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
                PspName = "Cypress Pole",
                AttackPower = 6,
                HitPercentage = 20,
                AcquiredViaLocation = "Zeirchele Falls (Chapter 2)",
                AcquiredViaTreasureHunt = "Castled City of Zaland (rare)",
                Cost = 1000,
                Description = "A pole carved from the wood of a cypress.",
                IconFileName = "FFT_Cypress_Pole.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
                PspName = "Battle Bamboo",
                AttackPower = 7,
                HitPercentage = 20,
                AcquiredViaLocation = "Cardinal Delacroix meeting at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "Balias Swale (rare)",
                Cost = 1400,
                Description = "A thin and supple bamboo pole that bends lithely when swung through the air.",
                IconFileName = "FFT_Battle_Bamboo.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
                PspName = "Musk Pole",
                AttackPower = 8,
                HitPercentage = 20,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                AcquiredViaTreasureHunt = "Monastery Vaults Second Level (rare)",
                Cost = 2400,
                Description = "A pole crafted from wood that emits a musky scent. It is in the shape of a large ladle.",
                IconFileName = "FFT_Musk_Pole.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
                PspName = "Iron Fan",
                AttackPower = 9,
                HitPercentage = 20,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 4000,
                Description = "The ribs of this enormous fan are made of iron. When folded up, it may be employed as a pole in battle.",
                IconFileName = "FFT_Iron_Fan.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
                PspName = "Ivory Pole",
                AttackPower = 11,
                HitPercentage = 20,
                AcquiredViaPoach = "Sekhret",
                AcquiredViaCatch = "Level 95 Ninja",
                Cost = 10000,
                Description = "A pole made from specially treated ivory. It is surprisingly strong, despite its fragile appearance.",
                IconFileName = "FFT_Ivory_Pole.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Pole,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
                PspName = "Rod",
                AttackPower = 3,
                HitPercentage = 20,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 200,
                Description = "A rod fashioned from evergreen wood.",
                IconFileName = "FFT_Rod.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
                PspName = "Dragon Rod",
                AttackPower = 5,
                HitPercentage = 20,
                AcquiredViaPoach = "Blue Dragon",
                AcquiredViaMode = "Rendezvous",
                Cost = 12000,
                Description = "A rod wielded by a dragon master. Its tip is made from carved dragon bone.",
                IconFileName = "FFT_Dragon_Rod.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Rod,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
                PspName = "Javelin",
                AttackPower = 8,
                HitPercentage = 10,
                AcquiredViaLocation = "Second battle Merchant City of Dorter (Chapter 2)",
                AcquiredViaTreasureHunt = "Balias Swale (rare)",
                Cost = 1000,
                Description = "A light and inexpensive spear. Allows the wielder to attack enemies within a range of two tiles.",
                IconFileName = "FFT_Javelin_1.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
                PspName = "Spear",
                AttackPower = 9,
                HitPercentage = 10,
                AcquiredViaLocation = "Meeting with Cardinal Delacroix at Lionel Castle (Chapter 2)",
                AcquiredViaTreasureHunt = "First battle Mining Town of Gollund (rare)",
                Cost = 2000,
                Description = "The most commonly used type of spear. Distinguished by its especially long reach.",
                IconFileName = "FFT_Spear.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
                PspName = "Mythril Spear",
                AttackPower = 10,
                HitPercentage = 10,
                AcquiredViaLocation = "Defeat Cúchulainn at Lionel Castle (Chapter 3)",
                Cost = 4500,
                Description = "The tip of this spear is made from the valuable metal known as mythril.",
                IconFileName = "FFT_Mythril_Spear.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
                PspName = "Holy Lance",
                AttackPower = 14,
                HitPercentage = 10,
                AcquiredViaPoach = "Sekhret",
                AcquiredViaMode = "Rendezvous",
                AcquiredViaCatch = "Level 90-94 Ninja",
                Cost = 18000,
                SpellEffect = "Holy",
                Element = "Holy",
                Description = "This sacred weapon shines a brilliant blue.",
                IconFileName = "FFT_Holy_Lance.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
                PspName = "Gae Bolg",
                AttackPower = 24,
                HitPercentage = 15,
                AcquiredViaMode = "Melee",
                Cost = 10,
                Description = "A spear said to have been wielded by a child of the gods. Merely lifting it requires great strength.",
                IconFileName = "FFT_Gae_Bolg.png"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
                PspName = "Gungnir",
                AttackPower = 29,
                HitPercentage = 15,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Element = "Thunder",
                Description = "A spear with the power to pierce anything.",
                IconFileName = "FFT_Gungnir.png"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Polearm,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
                PspName = "Oak Staff",
                AttackPower = 3,
                HitPercentage = 15,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 120,
                Description = "A staff made from sturdy oak.",
                IconFileName = "FFT_Oak_Staff.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
                PspName = "Dreamwaker",
                AttackPower = 5,
                HitPercentage = 15,
                MagicAttackBoost = 4,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                Description = "A powerful staff said to give life to its owner's dreams.",
                IconFileName = "FFT_Dreamwaker.png"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Staff,
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
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
                PspName = "Broadsword",
                AttackPower = 4,
                HitPercentage = 5,
                AcquiredViaLocation = "Magick City of Gariland (Chapter 1)",
                AcquiredViaTreasureHunt = "Mandalia Plains (rare)",
                Cost = 200,
                Description = "This broad-bladed sword is suited for large slashing strokes. It is inexpensive, but not particularly powerful.",
                IconFileName = "FFT_Broadsword.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
                PspName = "Longsword",
                AttackPower = 5,
                HitPercentage = 10,
                AcquiredViaLocation = "Dycedarg meeting at Eagrose Castle (Chapter 1)",
                AcquiredViaTreasureHunt = "Merchant City of Dorter (rare)",
                Cost = 900,
                Description = "This straight and sharp double-edged blade can be used for either stabbing or slashing.",
                IconFileName = "FFT_Long_Sword.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
                PspName = "Iron Sword",
                AttackPower = 6,
                HitPercentage = 5,
                AcquiredViaLocation = "Zeklaus Desert (Chapter 1)",
                Cost = 900,
                Description = "This sword has a broad and sturdy blade, but its iron construction makes it very heavy.",
                IconFileName = "FFT_Iron_Sword.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
                PspName = "Mythril Sword",
                AttackPower = 7,
                HitPercentage = 8,
                AcquiredViaLocation = "Lenalian Plateau (Chapter 1)",
                AcquiredViaTreasureHunt = "Fovoham Windflats (rare), Mining Town of Gollund (rare)",
                Cost = 1600,
                Description = "A sword forged from the metal known as mythril. Its brilliantly shining blade is incredibly lightweight.",
                IconFileName = "FFT_Mythril_Sword.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
                PspName = "Platinum Sword",
                AttackPower = 12,
                HitPercentage = 10,
                AcquiredViaLocation = "Walled City of Yardrow (Chapter 3)",
                AcquiredViaTreasureHunt = "Mount Germinas (rare)",
                Cost = 11000,
                Description = "A shining sword made of a lustrous white alloy of mythril and platinum. Its broad blade is wickedly sharp.",
                IconFileName = "FFT_Platinum_Sword.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
                PspName = "Moonblade",
                AttackPower = 20,
                HitPercentage = 15,
                AcquiredViaMode = "Rendezvous",
                Cost = 10,
                EquipStatusEffect = "Haste",
                Description = "A sword that glitters cruelly like a crescent moon.",
                IconFileName = "FFT_Moonblade.png"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.Sword,
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

            #region Throwing Weapons
            context.Weapons.AddOrUpdate(m => m.PspName,
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.ThrowingWeapon,
                PspName = "Shuriken",
                AttackPower = 4,
                HitPercentage = 0,
                AcquiredViaLocation = "Second battle Merchant City of Dorter (Chapter 2)",
                Cost = 50,
                Description = "A throwing weapon for ninjas. It spins in the air before hitting its target.",
                IconFileName = "FFT_Shuriken.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.ThrowingWeapon,
                PspName = "Fuma Shuriken",
                PsxName = "Magic Shuriken",
                AttackPower = 7,
                HitPercentage = 0,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 300,
                Description = "A pinwheel-shaped throwing star that flies at very high speeds.",
                IconFileName = "FFT_Fuma_Shuriken.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.ThrowingWeapon,
                PspName = "Yagyu Darkrood",
                PsxName = "Yagyu Darkness",
                AttackPower = 10,
                HitPercentage = 0,
                AcquiredViaLocation = "Royal City of Lesalia (Chapter 3)",
                Cost = 1000,
                Description = "A cross-shaped throwing star used by a famous ninja school. Its blades are serrated for maximum damage.",
                IconFileName = "FFT_Yagyu_Darkrood.gif"
            },
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.ThrowingWeapon,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.ThrowingWeapon,
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
            new Weapon
            {
                WeaponCategoryID = (int)WeaponCategoriesList.ThrowingWeapon,
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
        }
    }
}
