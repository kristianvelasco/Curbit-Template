using Microsoft.AspNetCore.Mvc;

namespace AuthorizationAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
