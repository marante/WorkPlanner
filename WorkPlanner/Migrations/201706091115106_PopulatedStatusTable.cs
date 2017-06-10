namespace WorkPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatedStatusTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) VALUES ('Ej Bokat')");
            Sql("INSERT INTO Status (Name) VALUES ('Ej Klart')");
            Sql("INSERT INTO Status (Name) VALUES ('Startad')");
            Sql("INSERT INTO Status (Name) VALUES ('Pågående')");
            Sql("INSERT INTO Status (Name) VALUES ('Klart')");
        }
        
        public override void Down()
        {
        }
    }
}
