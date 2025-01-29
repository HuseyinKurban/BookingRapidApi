using Microsoft.AspNetCore.Mvc;

namespace BookingRapidApi.ViewComponents
{
    public class _BookingTestimonialComponentPartial:ViewComponent
    {
     public   IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
