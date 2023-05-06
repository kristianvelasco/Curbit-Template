using Microsoft.AspNetCore.Mvc;

namespace AuthorizationAPI.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
