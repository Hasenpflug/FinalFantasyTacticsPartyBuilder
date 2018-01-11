namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AbilityNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "AbilitySetPsxName", c => c.String());
            AddColumn("dbo.Jobs", "AbilitySetPspName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "AbilitySetPspName");
            DropColumn("dbo.Jobs", "AbilitySetPsxName");
        }
    }
}
