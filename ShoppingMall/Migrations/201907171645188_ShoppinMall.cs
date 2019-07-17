namespace ShoppingMall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShoppinMall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Photo", c => c.String());
            CreateIndex("dbo.Products", "LabelId");
            AddForeignKey("dbo.Products", "LabelId", "dbo.Labels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "LabelId", "dbo.Labels");
            DropIndex("dbo.Products", new[] { "LabelId" });
            DropColumn("dbo.Products", "Photo");
            DropTable("dbo.Labels");
        }
    }
}
