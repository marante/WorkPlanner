namespace WorkPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateOfVoiceMadeNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkOrders", "DateOfInvoice", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkOrders", "DateOfInvoice", c => c.DateTime(nullable: false));
        }
    }
}
