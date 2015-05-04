namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationshipStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RelationshipStatus", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RelationshipStatus");
        }
    }
}
