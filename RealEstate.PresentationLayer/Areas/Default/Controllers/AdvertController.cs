using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.PresentationLayer.Areas.Default.Controllers
{
    [Area("Default")]
    [AllowAnonymous]
    public class AdvertController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
