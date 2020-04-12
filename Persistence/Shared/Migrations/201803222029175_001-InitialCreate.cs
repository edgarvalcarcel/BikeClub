namespace BikeClub.Persistence.Shared.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GovermentBusinessId = c.String(),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(),
                        Country = c.String(),
                        PBX = c.String(),
                        MobilePhoneMain = c.String(),
                        MobilePhoneAlt = c.String(),
                        Website = c.String(),
                        Email = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Riders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        GovermentId = c.String(),
                        Address = c.String(),
                        Country = c.String(),
                        PBX = c.String(),
                        MobilePhoneMain = c.String(),
                        MobilePhoneAlt = c.String(),
                        JerseyNumber = c.String(),
                        BlogWeb = c.String(),
                        Photo = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RiderByClubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClubId = c.Int(nullable: false),
                        RiderId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        QRCode = c.String(),
                        JerseyNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .ForeignKey("dbo.Riders", t => t.RiderId, cascadeDelete: true)
                .Index(t => t.ClubId)
                .Index(t => t.RiderId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RiderByClubs", "RiderId", "dbo.Riders");
            DropForeignKey("dbo.RiderByClubs", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.RiderByClubs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.RiderByClubs", new[] { "CategoryId" });
            DropIndex("dbo.RiderByClubs", new[] { "RiderId" });
            DropIndex("dbo.RiderByClubs", new[] { "ClubId" });
            DropTable("dbo.Categories");
            DropTable("dbo.RiderByClubs");
            DropTable("dbo.Riders");
            DropTable("dbo.Clubs");
        }
    }
}
