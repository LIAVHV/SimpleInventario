using System.Data.Entity;

namespace SimpleInventario.Models
{
    public class ApplicationDbContext : DbContext
    {
        // ESPECIFICAR EL NOMBRE DE LA db :base("DBSimpleInventario")
        //ESPECIFICAR EL NOMBRE DE LA db desde la cadena de conexion base("name=ConnectionString")
        public ApplicationDbContext() : base("name=ConnectionString")
        {
            //Al ejecutar la aplicacion se ejecuta lo siguiente Crear

            //Opcion por default, no es necesario aplicarla
            //Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());

            // eliminará, volverá a crear y, opcionalmente, volverá a inicializar la base de datos solo si el modelo ha cambiado desde que se creó la base de datos
            //Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());

            //siempre volverá a crear y, opcionalmente, volverá a inicializar la base de datos la primera vez que se usa un contexto en el dominio de la aplicación
            //Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseAlways<ApplicationDbContext>());

            //Sembrar datos iniciales para la base de datos, solo si CreateDatabaseIfNotExists
            //Database.SetInitializer<ApplicationDbContext>(new SeedData());


        }
        public virtual DbSet<Unidades> Unidades { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Entradas> Entradas { get; set; }
        public virtual DbSet<Salidas> Salidas { get; set; }
    }
}

