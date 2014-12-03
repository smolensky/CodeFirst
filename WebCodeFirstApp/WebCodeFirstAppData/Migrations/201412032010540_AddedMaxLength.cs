namespace WebCodeFirstAppData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogEntities", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.PostEntities", "Title", c => c.String(maxLength: 20));
            AlterColumn("dbo.PostEntities", "Content", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostEntities", "Content", c => c.String());
            AlterColumn("dbo.PostEntities", "Title", c => c.String());
            AlterColumn("dbo.BlogEntities", "Name", c => c.String());
        }
    }
}
