namespace PracticaExamen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Precio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Zona = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Producto_Id = c.Int(),
                        Vendedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Producto", t => t.Producto_Id)
                .ForeignKey("dbo.Vendedor", t => t.Vendedor_Id)
                .Index(t => t.Producto_Id)
                .Index(t => t.Vendedor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venta", "Vendedor_Id", "dbo.Vendedor");
            DropForeignKey("dbo.Venta", "Producto_Id", "dbo.Producto");
            DropIndex("dbo.Venta", new[] { "Vendedor_Id" });
            DropIndex("dbo.Venta", new[] { "Producto_Id" });
            DropTable("dbo.Venta");
            DropTable("dbo.Vendedor");
            DropTable("dbo.Producto");
        }
    }
}
