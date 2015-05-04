namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChildrenID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ChildrenID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ChildrenID");
        }
    }
}
