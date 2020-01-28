using System;
using EfCodeFirst.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EfCodeFirst.Services
{
    public class BlogPostsRepository
    {


        public List<BlogPost> ObtenerTodos()
        {
            using (var db = new BlogContext())
            {
                return db.BlogPost.ToList();
            }
        }

        internal void crear(BlogPost model)
        {
           using (var db = new BlogContext())
            {
                db.BlogPost.Add(model);
                db.SaveChanges();
            }
        }
    }
}