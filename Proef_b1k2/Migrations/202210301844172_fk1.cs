namespace Proef_b1k2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fk1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Spelers", "SchoolID");
            AddForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools", "SchoolID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools");
            DropIndex("dbo.Spelers", new[] { "SchoolID" });
        }
    }
}
