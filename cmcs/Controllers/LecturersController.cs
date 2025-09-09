using Microsoft.AspNetCore.Mvc;

namespace cmcs.Controllers
{
    public class LecturersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
