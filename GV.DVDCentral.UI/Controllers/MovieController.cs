using GV.DVDCentral.BL;
using Microsoft.AspNetCore.Mvc;

namespace GV.DVDCentral.UI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "List of All Movies";
            return View(MovieManager.Load());
        }




        public IActionResult Browse(int id)
        {
            return View(nameof(Index), MovieManager.Load(id));
        }
    }


}
