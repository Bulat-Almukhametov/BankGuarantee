namespace BankGuarantee.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guarantees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Days = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Ogrn = c.String(),
                        Inn = c.String(),
                        ChiefExecutiveId = c.Int(nullable: false),
                        FounderId = c.Int(nullable: false),
                        Address = c.String(),
                        FoundedYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.ChiefExecutiveId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.FounderId)
                .Index(t => t.ChiefExecutiveId)
                .Index(t => t.FounderId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Middlename = c.String(),
                        Surname = c.String(),
                        Appointment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guarantees", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Organizations", "FounderId", "dbo.People");
            DropForeignKey("dbo.Organizations", "ChiefExecutiveId", "dbo.People");
            DropIndex("dbo.Organizations", new[] { "FounderId" });
            DropIndex("dbo.Organizations", new[] { "ChiefExecutiveId" });
            DropIndex("dbo.Guarantees", new[] { "OrganizationId" });
            DropTable("dbo.People");
            DropTable("dbo.Organizations");
            DropTable("dbo.Guarantees");
        }
    }
}
