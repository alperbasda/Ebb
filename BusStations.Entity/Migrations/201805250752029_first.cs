namespace BusStations.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusBusStationRelations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusId = c.Int(nullable: false),
                        BusStationId = c.Int(nullable: false),
                        StationIndex = c.Int(nullable: false),
                        IsLastLocateStation = c.Boolean(nullable: false),
                        LocatedTime = c.Time(nullable: false, precision: 7),
                        Count = c.Int(nullable: false),
                        Avarage = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buses", t => t.BusId, cascadeDelete: true)
                .ForeignKey("dbo.BusStations", t => t.BusStationId, cascadeDelete: true)
                .Index(t => t.BusId)
                .Index(t => t.BusStationId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Color = c.String(),
                        LocationX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocationY = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BusStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LocationX = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocationY = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BusBusStationRelations", "BusStationId", "dbo.BusStations");
            DropForeignKey("dbo.BusBusStationRelations", "BusId", "dbo.Buses");
            DropIndex("dbo.BusBusStationRelations", new[] { "BusStationId" });
            DropIndex("dbo.BusBusStationRelations", new[] { "BusId" });
            DropTable("dbo.BusStations");
            DropTable("dbo.Buses");
            DropTable("dbo.BusBusStationRelations");
        }
    }
}
