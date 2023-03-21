namespace _2FreeHunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrolls", "VoterId", c => c.Int(nullable: false));
            AddColumn("dbo.Enrolls", "DOB", c => c.DateTime(nullable: false));
            AddColumn("dbo.Restaurants", "TotalDonation", c => c.Int(nullable: false));
            AddColumn("dbo.FoodCollectors", "Destination", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.FoodCollectors", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Enrolls", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Enrolls", "Location", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Restaurants", "Location", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.FoodCollectors", "Location", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.FoodCollectors", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodCollectors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.FoodCollectors", "Location", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Restaurants", "Location", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Enrolls", "Location", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Enrolls", "Name", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.FoodCollectors", "Quantity");
            DropColumn("dbo.FoodCollectors", "Destination");
            DropColumn("dbo.Restaurants", "TotalDonation");
            DropColumn("dbo.Enrolls", "DOB");
            DropColumn("dbo.Enrolls", "VoterId");
        }
    }
}
