namespace AspAngularCP1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigrations : DbMigration
    {
        public override void Up()
        {
            
            DropIndex("dbo.Customers", new[] { "Survey_ID" });
            DropIndex("dbo.Customers", new[] { "Survey_ID1" });
            AddColumn("dbo.AspNetUsers", "Survey_ID", c => c.Int());
            AddColumn("dbo.AspNetUsers", "Survey_ID1", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Survey_ID");
            CreateIndex("dbo.AspNetUsers", "Survey_ID1");
            CreateIndex("dbo.Question", "Survey_ID");
            CreateIndex()
        }
        
        public override void Down()
        {

            DropIndex("dbo.AspNetUsers", new[] { "Survey_ID1" });
            DropIndex("dbo.AspNetUsers", new[] { "Survey_ID" });
            DropColumn("dbo.AspNetUsers", "Survey_ID1");
            DropColumn("dbo.AspNetUsers", "Survey_ID");
            CreateIndex("dbo.Customers", "Survey_ID1");
            CreateIndex("dbo.Customers", "Survey_ID");
        }
    }
}
