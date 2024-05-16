namespace SimpleInventario.Migrations
{
    using SimpleInventario.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            //Al ejecutar la aplicacion se ejecuta
            AutomaticMigrationsEnabled = false;

            //Evita perdida de datos existentes en la base de datos usa la configuracion CreateDatabaseIfNotExists implementada en SeedData
            //AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // al insertar datos en este apartado y aplicar la migracion o update-database se insertaran los datos
        }
    }
}
