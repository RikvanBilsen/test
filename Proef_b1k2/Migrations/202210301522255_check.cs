namespace Proef_b1k2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schools", "School_SchoolID", "dbo.Schools");
            DropForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools");
            DropIndex("dbo.Schools", new[] { "School_SchoolID" });
            DropIndex("dbo.Spelers", new[] { "SchoolID" });
            DropColumn("dbo.Schools", "School_SchoolID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schools", "School_SchoolID", c => c.Int());
            CreateIndex("dbo.Spelers", "SchoolID");
            CreateIndex("dbo.Schools", "School_SchoolID");
            AddForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools", "SchoolID", cascadeDelete: true);
            AddForeignKey("dbo.Schools", "School_SchoolID", "dbo.Schools", "SchoolID");
        }
    }
}
