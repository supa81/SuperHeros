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
        public ActionResult Details(int id)
        {
            var SuperheroDetails = _context.Superhero.Where(s => s.Id==id).Single();

            return View(SuperheroDetails);
        }

        // GET: SuperHeroController/Create
        public ActionResult Create()
        {
            var createsuperhero = _context.Superhero;
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

            var EditSuperhero = _context.Superhero.Where(e => e.Id == id).Single();
           
            return View(EditSuperhero);
        }

        // POST: SuperHeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Superhero edithero)
        {
            try
            {
                _context.Superhero.Update(edithero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Edit));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteSuperhero = _context.Superhero.Where(d => d.Id == id).Single();
            
            return View(deleteSuperhero);
        }

        // POST: SuperHeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Superhero deletehero)
        {
            try
            {
                _context.Superhero.Remove(deletehero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
