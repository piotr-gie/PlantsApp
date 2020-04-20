using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantsApp.Models;

namespace PlantsApp.Controllers
{
    public class SeedsController : Controller
    {
        public readonly ApplicationDbContext _db;
        [BindProperty]
        public Seed Seed { get; set; }
        public SeedsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Seed = new Seed();
            if (id == null)
            {
                //create
                return View(Seed);
            }
            //update
            Seed = _db.Seeds.FirstOrDefault(u => u.Id == id);
            if (Seed == null)
            {
                return NotFound();
            }
            return View(Seed);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Seed.Id == 0)
                {
                    //create
                    _db.Seeds.Add(Seed);
                }
                else
                {
                    _db.Seeds.Update(Seed);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Seed);
        }

        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Seeds.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var seedFromDb = await _db.Seeds.FirstOrDefaultAsync(u => u.Id == id);
            if (seedFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Seeds.Remove(seedFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}