namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsStartingitem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "IsStartingItem", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "IsStartingItem");
        }
    }
}
