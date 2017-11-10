namespace FoodMenu.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuHeaders",
                c => new
                    {
                        IdMenuHeader = c.Int(nullable: false, identity: true),
                        NamMenuHeader = c.String(maxLength: 60),
                        DesMenuHeader = c.String(maxLength: 255),
                        ValSequence = c.Int(nullable: false),
                        IdMenu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdMenuHeader)
                .ForeignKey("dbo.Menus", t => t.IdMenu, cascadeDelete: true)
                .Index(t => t.IdMenu);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        IdMenu = c.Int(nullable: false, identity: true),
                        NamMenu = c.String(maxLength: 60),
                        DesMenu = c.String(maxLength: 255),
                        IdRestaurant = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdMenu)
                .ForeignKey("dbo.Restaurants", t => t.IdRestaurant, cascadeDelete: true)
                .Index(t => t.IdRestaurant);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        IdRestaurant = c.Int(nullable: false, identity: true),
                        RestaurantUser = c.String(),
                        RestaurantPassword = c.String(),
                        NamRestaurant = c.String(maxLength: 60),
                        CNPJ = c.String(),
                        Address = c.String(),
                        CEP = c.String(),
                        DesRestaurant = c.String(maxLength: 255),
                        AddressComplement = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.IdRestaurant);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        IdMenuItem = c.Int(nullable: false, identity: true),
                        NamMenuItem = c.String(maxLength: 60),
                        NumSequence = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        DesMenuItem = c.String(maxLength: 255),
                        IdMenuHeader = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdMenuItem)
                .ForeignKey("dbo.MenuHeaders", t => t.IdMenuHeader, cascadeDelete: true)
                .Index(t => t.IdMenuHeader);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItems", "IdMenuHeader", "dbo.MenuHeaders");
            DropForeignKey("dbo.MenuHeaders", "IdMenu", "dbo.Menus");
            DropForeignKey("dbo.Menus", "IdRestaurant", "dbo.Restaurants");
            DropIndex("dbo.MenuItems", new[] { "IdMenuHeader" });
            DropIndex("dbo.Menus", new[] { "IdRestaurant" });
            DropIndex("dbo.MenuHeaders", new[] { "IdMenu" });
            DropTable("dbo.MenuItems");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuHeaders");
        }
    }
}
