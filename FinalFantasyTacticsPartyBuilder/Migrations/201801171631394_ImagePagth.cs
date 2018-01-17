namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagePagth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemCategories", "StartingItemImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemCategories", "StartingItemImagePath");
        }
    }
}
