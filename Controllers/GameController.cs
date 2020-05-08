using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantsApp.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;

namespace PlantsApp.Controllers
{
    public class GameController : Controller
    {
        public readonly ApplicationDbContext2 _db;
        public Field Field { get; set; }
        public GameController(ApplicationDbContext2 db)
        {
            _db = db;
        }
        public IActionResult Index(int id)
        {
            var plants = _db.Plant.ToList();
            var fields = _db.Field.ToList();

            ViewData["Plants"] = plants;
            ViewData["Fields"] = fields;
            return View();
        }

        public IActionResult SowField(int id)
        {
            _db.Plant.AddRange(new Plant { Colour = "008000" });
            int currentPlantId = _db.Plant.ToList().Last().Id;

            // Field field = _db.Field.Where(x => x.Id == id).FirstOrDefault();
            //int fieldIndex = _db.Field.ToList().IndexOf(field);

            // find field of chosen index and assign plant to it 
            _db.Field.ToList()[_db.Field.ToList().FindIndex(x => x.Id == id)].PlantId = currentPlantId;
            
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}