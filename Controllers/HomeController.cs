using Microsoft.AspNetCore.Mvc;

namespace Railway_Reservation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
