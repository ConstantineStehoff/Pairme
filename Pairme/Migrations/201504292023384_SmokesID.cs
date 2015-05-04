namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmokesID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SmokesID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SmokesID");
        }
    }
}
