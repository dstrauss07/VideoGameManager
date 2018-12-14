using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StraussDa.VideoGameLibrary;

namespace VideoGameManager.Controllers
{
   public class GameController : Controller
    {
        private static GameRepository _gameRepo = new GameRepository();
        

        // GET: Game
        public IActionResult Index()
        {
      
       
            return View(_gameRepo.ListAll());
        }

        // GET: Game/Details/5
        public IActionResult Details(int id)
        {
            return View(_gameRepo.GetById(id));
        }

        // GET: Game/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Game newGame, IFormCollection collection)
        {
            try
            {
                _gameRepo.Add(newGame);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Edit/5
        public IActionResult Edit(int id)
        {
            return View(_gameRepo.GetById(id));
        }

        // POST: Game/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Game editGame, int id, IFormCollection collection)
        {
            try
            {
                _gameRepo.Edit(editGame);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Delete/5
        public IActionResult Delete(int id)
        {
            return View(_gameRepo.GetById(id));
        }

        // POST: Game/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _gameRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}