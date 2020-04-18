using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantsApp.Models;

namespace PlantsApp.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            string Url = "https://api.openweathermap.org/data/2.5/weather?q=Wroclaw&appid=e0bcdb0c6cc0932e2b2d1ae7b8015683";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(Url);
                var currentWeather =new  Weather(json);
                return View(currentWeather);
            }
            
        }
    }
}