namespace WorkPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSomeDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkOrders", "Start", c => c.String(nullable: true, maxLength: 255));
            AlterColumn("dbo.WorkOrders", "Comments", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkOrders", "Comments", c => c.String());
            AlterColumn("dbo.WorkOrders", "Start", c => c.String());
        }
    }
}
