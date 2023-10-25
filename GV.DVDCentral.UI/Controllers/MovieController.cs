using GV.DVDCentral.BL;
using Microsoft.AspNetCore.Mvc;

namespace GV.DVDCentral.UI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View(MovieManager.Load());
        }
    }
}
