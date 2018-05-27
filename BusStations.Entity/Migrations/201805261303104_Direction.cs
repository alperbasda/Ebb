namespace BusStations.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Direction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buses", "Direction", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buses", "Direction");
        }
    }
}
