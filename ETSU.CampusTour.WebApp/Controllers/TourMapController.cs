using Microsoft.AspNetCore.Mvc;

namespace ETSUGuidedTourApp.Web.Controllers
{
    public class TourMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
