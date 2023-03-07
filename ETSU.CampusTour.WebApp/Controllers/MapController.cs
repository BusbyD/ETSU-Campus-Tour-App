using Microsoft.AspNetCore.Mvc;

namespace ETSUGuidedTourApp.Web.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
