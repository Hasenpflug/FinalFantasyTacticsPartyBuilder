namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CanWield : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemCategories", "CanDualWield", c => c.Boolean(nullable: false));
            AddColumn("dbo.ItemCategories", "CanDoubleHand", c => c.Boolean(nullable: false));
            AddColumn("dbo.ItemCategories", "IsTwoHandOnly", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemCategories", "IsTwoHandOnly");
            DropColumn("dbo.ItemCategories", "CanDoubleHand");
            DropColumn("dbo.ItemCategories", "CanDualWield");
        }
    }
}
