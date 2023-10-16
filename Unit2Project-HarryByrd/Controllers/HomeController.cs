using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using Unit2Project_HarryByrd.Models;

namespace GameList.Controllers
{
    public class HomeController : Controller
    {
        private GameContext context { get; set; }

        public HomeController(GameContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var games = context.Games.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(games);
        }
    }
}