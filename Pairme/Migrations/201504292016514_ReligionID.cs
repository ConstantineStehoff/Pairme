namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReligionID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ReligionID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ReligionID");
        }
    }
}
