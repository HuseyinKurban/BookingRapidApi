using Microsoft.AspNetCore.Mvc;

namespace BookingRapidApi.ViewComponents
{
    public class _BookingAboutComponentPartial:ViewComponent
    {
      public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
