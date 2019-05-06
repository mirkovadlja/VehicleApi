namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relatisnshipadded : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.VehicleModels", "VehicleMakeId");
            AddForeignKey("dbo.VehicleModels", "VehicleMakeId", "dbo.VehicleMakes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleModels", "VehicleMakeId", "dbo.VehicleMakes");
            DropIndex("dbo.VehicleModels", new[] { "VehicleMakeId" });
        }
    }
}
