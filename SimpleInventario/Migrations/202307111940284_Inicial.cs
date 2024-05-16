namespace SimpleInventario.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entradas",
                c => new
                    {
                        EntradasId = c.Int(nullable: false, identity: true),
                        FKProductosId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha = c.DateTime(nullable: false),
                        TotalImporte = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EntradasId)
                .ForeignKey("dbo.Productos", t => t.FKProductosId, cascadeDelete: false)
                .Index(t => t.FKProductosId);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ProductosId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 300),
                        FkUnidadesId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Existencia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductosId)
                .ForeignKey("dbo.Unidades", t => t.FkUnidadesId, cascadeDelete: false)
                .Index(t => t.Nombre, unique: true)
                .Index(t => t.FkUnidadesId);
            
            CreateTable(
                "dbo.Unidades",
                c => new
                    {
                        UnidadesId = c.Int(nullable: false, identity: true),
                        Unidad = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.UnidadesId)
                .Index(t => t.Unidad, unique: true);
            
            CreateTable(
                "dbo.Salidas",
                c => new
                    {
                        SalidasId = c.Int(nullable: false, identity: true),
                        FKProductosId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Fecha = c.DateTime(nullable: false),
                        TotalImporte = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SalidasId)
                .ForeignKey("dbo.Productos", t => t.FKProductosId, cascadeDelete: false)
                .Index(t => t.FKProductosId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salidas", "FKProductosId", "dbo.Productos");
            DropForeignKey("dbo.Entradas", "FKProductosId", "dbo.Productos");
            DropForeignKey("dbo.Productos", "FkUnidadesId", "dbo.Unidades");
            DropIndex("dbo.Salidas", new[] { "FKProductosId" });
            DropIndex("dbo.Unidades", new[] { "Unidad" });
            DropIndex("dbo.Productos", new[] { "FkUnidadesId" });
            DropIndex("dbo.Productos", new[] { "Nombre" });
            DropIndex("dbo.Entradas", new[] { "FKProductosId" });
            DropTable("dbo.Salidas");
            DropTable("dbo.Unidades");
            DropTable("dbo.Productos");
            DropTable("dbo.Entradas");
        }
    }
}
