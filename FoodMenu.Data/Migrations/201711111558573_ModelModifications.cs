namespace FoodMenu.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelModifications : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurants", "RestaurantUser");
            DropColumn("dbo.Restaurants", "RestaurantPassword");
            DropColumn("dbo.Restaurants", "Logo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "Logo", c => c.String());
            AddColumn("dbo.Restaurants", "RestaurantPassword", c => c.String());
            AddColumn("dbo.Restaurants", "RestaurantUser", c => c.String());
        }
    }
}
