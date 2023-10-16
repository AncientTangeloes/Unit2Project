using Microsoft.AspNetCore.Mvc;
using GameList.Models;

namespace Unit2Project_HarryByrd.Controllers
{
    public class GameController : Controller
    {
        private GameContext context { get; set; }

        public GameController(GameContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            return View("Edit", new Game());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            var movie = context.Gams.Find(id);
            return View("Edit", game);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                if (game.MovieId == 0)
                {
                    context.Movies.Add(game);
                }
                else
                {
                    context.Movies.Update(game);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (game.GameId == 0) ? "Add" : "Edit";
                ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
                return View(game);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Games.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
