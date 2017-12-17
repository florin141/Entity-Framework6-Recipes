namespace Ef.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recipe0201_SimpleModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Chapter02.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 64),
                        MiddleName = c.String(maxLength: 64),
                        LastName = c.String(maxLength: 64),
                        PhoneNumber = c.String(maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Chapter02.Person");
        }
    }
}
