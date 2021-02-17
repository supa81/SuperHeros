using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Data;
using SuperHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Controllers
{
    public class SuperHeroController : Controller
    {
        private ApplicationDbContext _context;
        public SuperHeroController(ApplicationDbContext context)
        {
            _context = context; 

        }

        // GET: SuperHeroController
        public ActionResult Index()
        {
            var AllSuperHeros = _context.Superhero;

            return View(AllSuperHeros);
        }

        // GET: SuperHeroController/Details/5
        public ActionResult Details()
        {
            var SuperheroDetails = _context.Superhero;

            return View(SuperheroDetails);
        }

        // GET: SuperHeroController/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: SuperHeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero hero)
        {
            try
            {
                _context.Superhero.Add(hero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
