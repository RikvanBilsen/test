namespace Proef_b1k2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uniDBschema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aanmeldings",
                c => new
                    {
                        AanmeldingID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AanmeldingID);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        SchoolID = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                    })
                .PrimaryKey(t => t.SchoolID);
            
            CreateTable(
                "dbo.Spelers",
                c => new
                    {
                        SpelerID = c.Int(nullable: false, identity: true),
                        Roepnaam = c.String(),
                        Tussenvoegsels = c.String(),
                        Achternaam = c.String(),
                        School_SchoolID = c.Int(),
                    })
                .PrimaryKey(t => t.SpelerID)
                .ForeignKey("dbo.Schools", t => t.School_SchoolID)
                .Index(t => t.School_SchoolID);
            
            CreateTable(
                "dbo.Toernoois",
                c => new
                    {
                        ToernooiID = c.Int(nullable: false, identity: true),
                        Omschrijving = c.String(),
                        Datum = c.String(),
                    })
                .PrimaryKey(t => t.ToernooiID);
            
            CreateTable(
                "dbo.Wedstrijds",
                c => new
                    {
                        WedstrijdID = c.Int(nullable: false, identity: true),
                        Ronde = c.Int(nullable: false),
                        Speler1ID = c.Int(nullable: false),
                        Speler2ID = c.Int(nullable: false),
                        Score1 = c.Int(nullable: false),
                        Score2 = c.Int(nullable: false),
                        WinnaarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WedstrijdID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Spelers", "School_SchoolID", "dbo.Schools");
            DropIndex("dbo.Spelers", new[] { "School_SchoolID" });
            DropTable("dbo.Wedstrijds");
            DropTable("dbo.Toernoois");
            DropTable("dbo.Spelers");
            DropTable("dbo.Schools");
            DropTable("dbo.Aanmeldings");
        }
    }
}
