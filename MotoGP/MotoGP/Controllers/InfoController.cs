using Microsoft.AspNetCore.Mvc;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult ListRaces()
        {
            ViewData["Title"] = "Races";
            return View();
        }
        public IActionResult ListTeams() {
            ViewData["BannerNr"] = 2;
            return View();
        }
        public IActionResult ListRiders() {
            ViewData["BannerNr"] = 1;
            return View();
        }
    }
}
