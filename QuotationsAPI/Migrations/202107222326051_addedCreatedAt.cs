namespace QuotationsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCreatedAt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Quotes", "CreatedAt");
        }
    }
}
