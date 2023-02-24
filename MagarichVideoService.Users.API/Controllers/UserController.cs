using Microsoft.AspNetCore.Mvc;

namespace MagarichVideoService.Users.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return Content("Микросервис MagarichVideoService.Users");
        }
    }
}
