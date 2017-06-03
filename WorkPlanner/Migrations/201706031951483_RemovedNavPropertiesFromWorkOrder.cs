namespace WorkPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedNavPropertiesFromWorkOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WorkOrders", "StatusesId", "dbo.Status");
            DropIndex("dbo.WorkOrders", new[] { "StatusesId" });
            DropColumn("dbo.WorkOrders", "StatusesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "StatusesId", c => c.Int(nullable: false));
            CreateIndex("dbo.WorkOrders", "StatusesId");
            AddForeignKey("dbo.WorkOrders", "StatusesId", "dbo.Status", "Id", cascadeDelete: true);
        }
    }
}
