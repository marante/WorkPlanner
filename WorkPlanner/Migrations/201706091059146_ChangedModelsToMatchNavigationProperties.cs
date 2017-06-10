namespace WorkPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModelsToMatchNavigationProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "StatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.Status", "Name", c => c.String(nullable: true, maxLength: 255));
            AlterColumn("dbo.WorkOrders", "Address", c => c.String(nullable: true, maxLength: 255));
            AlterColumn("dbo.WorkOrders", "WorkDescription", c => c.String(nullable: true, maxLength: 255));
            CreateIndex("dbo.WorkOrders", "StatusId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkOrders", "StatusId", "dbo.Status");
            DropIndex("dbo.WorkOrders", new[] { "StatusId" });
            AlterColumn("dbo.WorkOrders", "WorkDescription", c => c.String());
            AlterColumn("dbo.WorkOrders", "Address", c => c.String());
            AlterColumn("dbo.Status", "Name", c => c.String());
            DropColumn("dbo.WorkOrders", "StatusId");
        }
    }
}
