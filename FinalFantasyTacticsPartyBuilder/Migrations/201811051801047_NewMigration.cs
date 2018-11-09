namespace FinalFantasyTacticsPartyBuilder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.JobPrerequisites", "JobID");
            AddForeignKey("dbo.JobPrerequisites", "JobID", "dbo.Jobs", "JobID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobPrerequisites", "JobID", "dbo.Jobs");
            DropIndex("dbo.JobPrerequisites", new[] { "JobID" });
        }
    }
}
