using Microsoft.AspNetCore.Mvc;

namespace ETSUGuidedTourApp.Web.Controllers
{
    public class TourListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
