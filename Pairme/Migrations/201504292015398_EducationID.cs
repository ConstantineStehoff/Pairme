namespace Pairme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EducationID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EducationID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EducationID");
        }
    }
}
