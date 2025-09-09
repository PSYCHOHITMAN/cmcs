using Microsoft.AspNetCore.Mvc;

namespace cmcs.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
