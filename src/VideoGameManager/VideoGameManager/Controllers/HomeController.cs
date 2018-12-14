using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameManager.Models;
using StraussDa.VideoGameLibrary;

namespace VideoGameManager.Controllers
{
    public class HomeController : Controller
    {
        private static GameRepository _gameRepo = new GameRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            
        var game1 = new Game
            {
                Year = 2012,
                Title = "Mount and Blade",
                Platform = "PC",
                Genre = "Strategy"
            };

            _gameRepo.Add(game1);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
