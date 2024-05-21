using Microsoft.AspNetCore.Mvc;

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult ListRaces()
        {
            return View();
        }
    }
}
