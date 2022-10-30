namespace Proef_b1k2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "School_SchoolID", c => c.Int());
            CreateIndex("dbo.Schools", "School_SchoolID");
            CreateIndex("dbo.Spelers", "SchoolID");
            AddForeignKey("dbo.Schools", "School_SchoolID", "dbo.Schools", "SchoolID");
            AddForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools", "SchoolID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Spelers", "SchoolID", "dbo.Schools");
            DropForeignKey("dbo.Schools", "School_SchoolID", "dbo.Schools");
            DropIndex("dbo.Spelers", new[] { "SchoolID" });
            DropIndex("dbo.Schools", new[] { "School_SchoolID" });
            DropColumn("dbo.Schools", "School_SchoolID");
        }
    }
}
