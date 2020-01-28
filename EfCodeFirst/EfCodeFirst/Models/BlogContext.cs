using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    public class BlogContext: DbContext
    {
        public BlogContext():base ("DefaultConnection")
        {


        }


        public DbSet<BlogPost>BlogPost { get; set; }
        public DbSet<Comentarios>Comentarios { get; set; }

    }
}