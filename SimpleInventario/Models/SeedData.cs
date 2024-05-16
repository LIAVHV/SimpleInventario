using System.Collections.Generic;
using System.Data.Entity;

namespace SimpleInventario.Models
{
    public class SeedData: CreateDatabaseIfNotExists<ApplicationDbContext>

    {
        // Al ejecutar la aplicacion se aplican las instrucciones, 
        // Se invoca desde ApplicationDbContext --> Database.SetInitializer<ApplicationDbContext>(new SeedData())
        protected override void Seed(ApplicationDbContext context)
        {
            //IList<Unidades> unidades = new List<Unidades>() {
            //new Unidades {Unidad="PIEZA"},
            //new Unidades {Unidad="SERVICIO"},
            //};
            //context.Unidades.AddRange(unidades);
            //base.Seed(context);
        }
    }
}
