using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCFestival.DAL.Data;
using System.Linq;
using MVCFestival.DAL.Models;

namespace MVCFestival.Controllers
{
    public class InfoController : Controller
    {
        private readonly FestivalDbContext _context;

        public InfoController(FestivalDbContext context)
        {
            _context = context;
        }

        public IActionResult ListFestivals()
        {
       //     // Fetch festivals with stages, but only select relevant fields
       //     var festivals = _context.Festivals
       //.Select(festival => new Festival
       //{
       //    Name = festival.Name,
       //    Date = festival.Date,
       //    Location = festival.Location,
       //    Price = festival.Price,
       //    Stages = festival.Stages.Select(stage => new FestivalStage
       //    {
       //        Name = stage.Name,
       //        Capacity = stage.Capacity,
       //        Performances = stage.Performances.Select(performance => new FestivalPerformance
       //        {
       //            Performer = performance.Performer,
       //            StartTime = performance.StartTime,
       //            EndTime = performance.EndTime,
                   
       //        })
       //    })
       //})
       //.ToList();

            return View();
        }
    }
}
