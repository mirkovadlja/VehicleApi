namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VehicleModels", "VehicleMakeId", "dbo.VehicleMakes");
            DropIndex("dbo.VehicleModels", new[] { "VehicleMakeId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.VehicleModels", "VehicleMakeId");
            AddForeignKey("dbo.VehicleModels", "VehicleMakeId", "dbo.VehicleMakes", "Id", cascadeDelete: true);
        }
    }
}
