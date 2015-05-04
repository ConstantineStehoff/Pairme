namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Height : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Height", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Height");
        }
    }
}
