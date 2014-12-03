namespace WebCodeFirstAppData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrandom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogEntities",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BlogId);
            
            CreateTable(
                "dbo.PostEntities",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.BlogEntities", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.RandomEntities",
                c => new
                    {
                        RandomId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.RandomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostEntities", "BlogId", "dbo.BlogEntities");
            DropIndex("dbo.PostEntities", new[] { "BlogId" });
            DropTable("dbo.RandomEntities");
            DropTable("dbo.PostEntities");
            DropTable("dbo.BlogEntities");
        }
    }
}
