namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Summary : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Summary", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Summary");
        }
    }
}
