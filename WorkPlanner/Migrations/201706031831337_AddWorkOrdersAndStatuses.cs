namespace WorkPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkOrdersAndStatuses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        WorkDescription = c.String(),
                        Start = c.String(),
                        DateOfInvoice = c.DateTime(nullable: false),
                        Comments = c.String(),
                        StatusesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Status", t => t.StatusesId, cascadeDelete: true)
                .Index(t => t.StatusesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkOrders", "StatusesId", "dbo.Status");
            DropIndex("dbo.WorkOrders", new[] { "StatusesId" });
            DropTable("dbo.WorkOrders");
            DropTable("dbo.Status");
        }
    }
}
