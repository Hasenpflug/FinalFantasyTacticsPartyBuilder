namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FemalesOnly : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemCategories", "IsFemaleOnly", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemCategories", "IsFemaleOnly");
        }
    }
}
