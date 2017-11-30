namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TheGreatSeeding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        AbilityID = c.Int(nullable: false, identity: true),
                        JobID = c.Int(nullable: false),
                        AbilityType = c.Int(nullable: false),
                        PspName = c.String(),
                        PsxName = c.String(),
                        MPCost = c.Int(),
                        Range = c.Int(),
                        Radius = c.Int(),
                        Height = c.Int(),
                        Speed = c.Int(),
                        ItemEquipIDs = c.String(),
                        Element = c.String(),
                        MoveBoost = c.Int(),
                        JumpBoost = c.Int(),
                        MagicAttackModifier = c.Boolean(nullable: false),
                        PhysicalDefenceModifier = c.Boolean(nullable: false),
                        AmountBoost = c.String(),
                        AmountDamage = c.String(),
                        JpNeededToLearnPsp = c.Int(nullable: false),
                        JpNeededToLearnPsx = c.Int(),
                        CanBeReflected = c.Boolean(nullable: false),
                        UsedWithArithmetics = c.Boolean(nullable: false),
                        DamageEquation = c.String(),
                        HealingEquation = c.String(),
                        EnergizeEquation = c.String(),
                        SuccessRateEquation = c.String(),
                        AddStatusEffect = c.String(),
                        RemoveStatusEffect = c.String(),
                        HPRestored = c.Int(),
                        HealthDrainedEquation = c.String(),
                        MpDrainedEquation = c.String(),
                        MPRestored = c.Int(),
                        Trigger = c.String(),
                        Description = c.String(),
                        Quote = c.String(),
                    })
                .PrimaryKey(t => t.AbilityID)
                .ForeignKey("dbo.Jobs", t => t.JobID, cascadeDelete: true)
                .Index(t => t.JobID);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobID = c.Int(nullable: false, identity: true),
                        PspName = c.String(),
                        PsxName = c.String(),
                        IsMaleOnly = c.Boolean(nullable: false),
                        IsFemaleOnly = c.Boolean(nullable: false),
                        HPMultiplier = c.Int(nullable: false),
                        HPGrowthConstant = c.Int(nullable: false),
                        MPMultiplier = c.Int(nullable: false),
                        MPGrowthConstant = c.Int(nullable: false),
                        SpeedMulitplier = c.Int(nullable: false),
                        SpeedGrowthConstant = c.Int(nullable: false),
                        PhysicalAttackMultiplier = c.Int(nullable: false),
                        PhysicalAttackGrowthConstant = c.Int(nullable: false),
                        MagicalAttackMultiplier = c.Int(nullable: false),
                        MagicalAttackGrowthConstant = c.Int(nullable: false),
                        BaseMoveLength = c.Int(nullable: false),
                        BaseJumpHeight = c.Int(nullable: false),
                        BaseCombatEvasion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobID);
            
            CreateTable(
                "dbo.JobItems",
                c => new
                    {
                        JobItemCategoryID = c.Int(nullable: false, identity: true),
                        JobID = c.Int(nullable: false),
                        ItemCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobItemCategoryID)
                .ForeignKey("dbo.ItemCategories", t => t.ItemCategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Jobs", t => t.JobID, cascadeDelete: true)
                .Index(t => t.JobID)
                .Index(t => t.ItemCategoryID);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        ItemCategoryID = c.Int(nullable: false, identity: true),
                        EquipmentCategoryID = c.Int(nullable: false),
                        ItemCategoryName = c.String(),
                        EquipmentCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ItemCategoryID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        ItemCategoryID = c.Int(nullable: false),
                        PsxName = c.String(),
                        PspName = c.String(),
                        AttackPower = c.Int(),
                        HPBonus = c.Int(),
                        MPBonus = c.Int(),
                        HitPercentage = c.Int(),
                        PhysicalEvade = c.Int(),
                        MagicalEvade = c.Int(),
                        Description = c.String(),
                        SpellEffect = c.String(),
                        HitStatusEffect = c.String(),
                        RemoveStatusEffect = c.String(),
                        ImmuneStatusEffect = c.String(),
                        EquipStatusEffect = c.String(),
                        PhysicalAttackBoost = c.Int(),
                        MagicAttackBoost = c.Int(),
                        SpeedBoost = c.Int(),
                        MoveBoost = c.Int(),
                        JumpBoost = c.Int(),
                        Element = c.String(),
                        ElementAbsorbed = c.String(),
                        ElementBoosted = c.String(),
                        ElementHalved = c.String(),
                        ElementNegated = c.String(),
                        ElementWeakness = c.String(),
                        AcquiredViaMode = c.String(),
                        AcquiredViaLocation = c.String(),
                        AcquiredViaPoach = c.String(),
                        AcquiredViaSteal = c.String(),
                        AcquiredViaTreasureHunt = c.String(),
                        AcquiredViaCatch = c.String(),
                        AcquiredViaInitialEquip = c.String(),
                        IconFileName = c.String(),
                        Cost = c.Int(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.ItemCategories", t => t.ItemCategoryID, cascadeDelete: true)
                .Index(t => t.ItemCategoryID);
            
            CreateTable(
                "dbo.JobPrerequisites",
                c => new
                    {
                        JobPrerequisitesID = c.Int(nullable: false, identity: true),
                        JobID = c.Int(nullable: false),
                        JobRequiredID = c.Int(nullable: false),
                        JobLevelRequiredPsp = c.Int(nullable: false),
                        JobLevelRequiredPsx = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobPrerequisitesID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Items", "ItemCategoryID", "dbo.ItemCategories");
            DropForeignKey("dbo.JobItems", "JobID", "dbo.Jobs");
            DropForeignKey("dbo.JobItems", "ItemCategoryID", "dbo.ItemCategories");
            DropForeignKey("dbo.Abilities", "JobID", "dbo.Jobs");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Items", new[] { "ItemCategoryID" });
            DropIndex("dbo.JobItems", new[] { "ItemCategoryID" });
            DropIndex("dbo.JobItems", new[] { "JobID" });
            DropIndex("dbo.Abilities", new[] { "JobID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.JobPrerequisites");
            DropTable("dbo.Items");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.JobItems");
            DropTable("dbo.Jobs");
            DropTable("dbo.Abilities");
        }
    }
}
