namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfessionID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ProfessionID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ProfessionID");
        }
    }
}
