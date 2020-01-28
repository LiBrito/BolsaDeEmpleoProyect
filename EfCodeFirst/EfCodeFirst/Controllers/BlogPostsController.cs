using EfCodeFirst.Models;
using EfCodeFirst.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfCodeFirst.Controllers
{
    public class BlogPostsController : Controller
    {
        private BlogPostsRepository _repo;

        public BlogPostsController()
        {
            _repo = new BlogPostsRepository();
        }

        // GET: BlogPosts
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
           // var comentario = model[0].Comentarios[0];
            return View(model);
        }

        // GET: BlogPosts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPosts/Create
        [HttpPost]
        public ActionResult Create(BlogPost model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.crear(model);
                    return RedirectToAction("Index");

                }

            }
            catch(Exception fuego)
            {
               // Log fuego
            }

            return View(model);
        }

        // GET: BlogPosts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPosts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPosts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPosts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
