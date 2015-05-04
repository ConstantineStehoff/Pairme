namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DrinksID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrinksID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DrinksID");
        }
    }
}
