namespace BusStations.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReelDirection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buses", "ReelDirection", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buses", "ReelDirection");
        }
    }
}
