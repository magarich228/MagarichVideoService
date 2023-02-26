using MagarichVideoService.Users.DAL;
using Microsoft.AspNetCore.Mvc;

namespace MagarichVideoService.Users.API.Controllers
{
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly UsersContext _db;

        public UserController(UsersContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Content($"Микросервис MagarichVideoService.Users. {_db.Users.Count()}");
        }
    }
}
