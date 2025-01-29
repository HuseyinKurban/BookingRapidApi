using Microsoft.AspNetCore.Mvc;

namespace BookingRapidApi.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
