namespace Ef.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recipe0301_Asynchronously : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Chapter03.AssociateSalary",
                c => new
                    {
                        SalaryId = c.Int(nullable: false, identity: true),
                        AssociateId = c.Int(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalaryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalaryId)
                .ForeignKey("Chapter03.Associate", t => t.AssociateId, cascadeDelete: true)
                .Index(t => t.AssociateId);
            
            CreateTable(
                "Chapter03.Associate",
                c => new
                    {
                        AssociateId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.AssociateId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Chapter03.AssociateSalary", "AssociateId", "Chapter03.Associate");
            DropIndex("Chapter03.AssociateSalary", new[] { "AssociateId" });
            DropTable("Chapter03.Associate");
            DropTable("Chapter03.AssociateSalary");
        }
    }
}
