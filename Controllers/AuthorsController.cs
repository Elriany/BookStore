using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStores.Models;
using BookStores.Models.Repositories;
namespace BookStores.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IRepository<Author> AuthorRepository;
        public AuthorsController(IRepository<Author> AuthorRepos)
        {
            AuthorRepository = AuthorRepos;
        }
        // GET: Authors
        public ActionResult Index()
        {
            var Authors = AuthorRepository.List();
            return View(Authors);
        }

        // GET: Authors/Details/5
        public ActionResult Details(int id)
        {
            var author = AuthorRepository.Find(id);
            return View(author);
        }

        // GET: Authors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Authors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author author)
        {
            try
            {
                // TODO: Add insert logic here
                AuthorRepository.Add(author);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Authors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Authors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Authors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authors/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}