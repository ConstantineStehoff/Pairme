namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EthnicityID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EthnicityID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EthnicityID");
        }
    }
}
