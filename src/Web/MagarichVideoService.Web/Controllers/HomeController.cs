using Microsoft.AspNetCore.Mvc;

namespace MagarichVideoService.Web.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
