namespace Proef_b1k2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools");
            DropIndex("dbo.Spelers", new[] { "SchoolID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Spelers", "SchoolID");
            AddForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools", "SchoolID", cascadeDelete: true);
        }
    }
}
