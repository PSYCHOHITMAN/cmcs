using Microsoft.AspNetCore.Mvc;

namespace cmcs.Controllers
{
    public class ApprovalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
