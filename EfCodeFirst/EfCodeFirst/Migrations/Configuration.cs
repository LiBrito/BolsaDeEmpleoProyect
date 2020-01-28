namespace EfCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EfCodeFirst.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EfCodeFirst.Models.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Comentarios.AddOrUpdate(x => x.Id, new Models.Comentarios()
            {

                Id = 1,
                Autor = "Kelvin B.",
                BlogPostId = 1,
                Contenido = "Hoy se amanece"

            });
        }
    }
}
