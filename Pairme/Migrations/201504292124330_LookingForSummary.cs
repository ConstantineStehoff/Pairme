namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LookingForSummary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LookingForSummary", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LookingForSummary");
        }
    }
}
