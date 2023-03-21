namespace _2FreeHunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Enrolls", "VoterId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrolls", "VoterId", c => c.Int(nullable: false));
        }
    }
}
