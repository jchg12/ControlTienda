namespace ControlTienda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cashes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CashFlows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        MoneyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MoneyOutflow = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cash_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cashes", t => t.Cash_Id)
                .Index(t => t.Cash_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetailPurchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Product_Id = c.Int(),
                        Purchase_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BarCode = c.String(maxLength: 25),
                        Name = c.String(maxLength: 150),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Double(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remark = c.String(maxLength: 250),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        CashFlow_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CashFlows", t => t.CashFlow_Id)
                .Index(t => t.CashFlow_Id);
            
            CreateTable(
                "dbo.DetailSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Product_Id = c.Int(),
                        Sale_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Sales", t => t.Sale_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Sale_Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        Quantity = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CashFlow_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CashFlows", t => t.CashFlow_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.CashFlow_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 25),
                        Nickname = c.String(maxLength: 8),
                        Password = c.String(maxLength: 15),
                        Rol_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rols", t => t.Rol_Id)
                .Index(t => t.Rol_Id);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 25),
                        Details = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Loggs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DteLogin = c.DateTime(),
                        DateLogout = c.DateTime(),
                        Remark = c.String(maxLength: 250),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Refunds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remark = c.String(),
                        DetailSale_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DetailSales", t => t.DetailSale_Id)
                .Index(t => t.DetailSale_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Refunds", "DetailSale_Id", "dbo.DetailSales");
            DropForeignKey("dbo.Loggs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.DetailSales", "Sale_Id", "dbo.Sales");
            DropForeignKey("dbo.Sales", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Rol_Id", "dbo.Rols");
            DropForeignKey("dbo.Sales", "CashFlow_Id", "dbo.CashFlows");
            DropForeignKey("dbo.DetailSales", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.DetailPurchases", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "CashFlow_Id", "dbo.CashFlows");
            DropForeignKey("dbo.DetailPurchases", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.CashFlows", "Cash_Id", "dbo.Cashes");
            DropIndex("dbo.Refunds", new[] { "DetailSale_Id" });
            DropIndex("dbo.Loggs", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "Rol_Id" });
            DropIndex("dbo.Sales", new[] { "User_Id" });
            DropIndex("dbo.Sales", new[] { "CashFlow_Id" });
            DropIndex("dbo.DetailSales", new[] { "Sale_Id" });
            DropIndex("dbo.DetailSales", new[] { "Product_Id" });
            DropIndex("dbo.Purchases", new[] { "CashFlow_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.DetailPurchases", new[] { "Purchase_Id" });
            DropIndex("dbo.DetailPurchases", new[] { "Product_Id" });
            DropIndex("dbo.CashFlows", new[] { "Cash_Id" });
            DropTable("dbo.Refunds");
            DropTable("dbo.Loggs");
            DropTable("dbo.Rols");
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.DetailSales");
            DropTable("dbo.Purchases");
            DropTable("dbo.Products");
            DropTable("dbo.DetailPurchases");
            DropTable("dbo.Categories");
            DropTable("dbo.CashFlows");
            DropTable("dbo.Cashes");
        }
    }
}
