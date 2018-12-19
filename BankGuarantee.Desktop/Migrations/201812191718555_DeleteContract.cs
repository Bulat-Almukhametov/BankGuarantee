namespace BankGuarantee.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteContract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guarantees", "IsProtocolPublished", c => c.Boolean(nullable: false));
            AddColumn("dbo.Guarantees", "IsRiskTerritory", c => c.Boolean(nullable: false));
            AddColumn("dbo.Guarantees", "ContractAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Guarantees", "GuaranteeAmountLessThanContract", c => c.Boolean(nullable: false));
            AddColumn("dbo.Guarantees", "Confirmed", c => c.Boolean());
            DropTable("dbo.Contracts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        Ammount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Guarantees", "Confirmed");
            DropColumn("dbo.Guarantees", "GuaranteeAmountLessThanContract");
            DropColumn("dbo.Guarantees", "ContractAmount");
            DropColumn("dbo.Guarantees", "IsRiskTerritory");
            DropColumn("dbo.Guarantees", "IsProtocolPublished");
        }
    }
}
