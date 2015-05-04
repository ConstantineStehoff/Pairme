namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LookingFor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LookingFor", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LookingFor");
        }
    }
}
