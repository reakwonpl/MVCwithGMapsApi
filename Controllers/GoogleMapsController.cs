using Microsoft.AspNetCore.Mvc;

namespace GoogleMapsMVC.Controllers
{
    public class GoogleMapsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}