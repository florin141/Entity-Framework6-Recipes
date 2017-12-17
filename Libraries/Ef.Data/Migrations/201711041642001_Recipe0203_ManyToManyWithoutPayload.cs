namespace Ef.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recipe0203_ManyToManyWithoutPayload : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Chapter02.Artist",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 64),
                        MiddleName = c.String(maxLength: 64),
                        LastName = c.String(maxLength: 64),
                    })
                .PrimaryKey(t => t.ArtistId);
            
            CreateTable(
                "Chapter02.Album",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AlbumId);
            
            CreateTable(
                "Chapter02.LinkTable",
                c => new
                    {
                        ArtistId = c.Int(nullable: false),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ArtistId, t.AlbumId })
                .ForeignKey("Chapter02.Artist", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("Chapter02.Album", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.ArtistId)
                .Index(t => t.AlbumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Chapter02.LinkTable", "AlbumId", "Chapter02.Album");
            DropForeignKey("Chapter02.LinkTable", "ArtistId", "Chapter02.Artist");
            DropIndex("Chapter02.LinkTable", new[] { "AlbumId" });
            DropIndex("Chapter02.LinkTable", new[] { "ArtistId" });
            DropTable("Chapter02.LinkTable");
            DropTable("Chapter02.Album");
            DropTable("Chapter02.Artist");
        }
    }
}
