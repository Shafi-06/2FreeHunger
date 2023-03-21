namespace _2FreeHunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatTablesUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrolls", "ResId", c => c.Int(nullable: false));
            AddColumn("dbo.FoodCollectors", "ResId", c => c.Int(nullable: false));
            AlterColumn("dbo.Enrolls", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Enrolls", "Location", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.FoodCollectors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.FoodCollectors", "Location", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Restaurants", "Location", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Enrolls", "ResId");
            CreateIndex("dbo.FoodCollectors", "ResId");
            AddForeignKey("dbo.FoodCollectors", "ResId", "dbo.Restaurants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Enrolls", "ResId", "dbo.Restaurants", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrolls", "ResId", "dbo.Restaurants");
            DropForeignKey("dbo.FoodCollectors", "ResId", "dbo.Restaurants");
            DropIndex("dbo.FoodCollectors", new[] { "ResId" });
            DropIndex("dbo.Enrolls", new[] { "ResId" });
            AlterColumn("dbo.Restaurants", "Location", c => c.String());
            AlterColumn("dbo.Restaurants", "Name", c => c.String());
            AlterColumn("dbo.FoodCollectors", "Location", c => c.String());
            AlterColumn("dbo.FoodCollectors", "Name", c => c.String());
            AlterColumn("dbo.Enrolls", "Location", c => c.String());
            AlterColumn("dbo.Enrolls", "Name", c => c.String());
            DropColumn("dbo.FoodCollectors", "ResId");
            DropColumn("dbo.Enrolls", "ResId");
        }
    }
}
