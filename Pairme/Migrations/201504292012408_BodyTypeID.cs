namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BodyTypeID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BodyTypeID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BodyTypeID");
        }
    }
}
