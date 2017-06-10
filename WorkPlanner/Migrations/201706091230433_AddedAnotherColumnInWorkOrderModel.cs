namespace WorkPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnotherColumnInWorkOrderModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "ObjectNumber", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkOrders", "ObjectNumber");
        }
    }
}
