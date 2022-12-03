using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            FilmManager filmManager = new FilmManager();
            FilmModel film = new FilmModel()
            {
                ID = 1,
                Title = "Rambo",
                Year = 1980
            };
            filmManager.AddFilm(film);
            
            return View();
        }
        [HttpPost]
        public IActionResult Add(FilmModel filmModel)
        {
            FilmManager filmManager = new FilmManager();
            filmManager.AddFilm(filmModel);
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
