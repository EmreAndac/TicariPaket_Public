using Microsoft.AspNetCore.Mvc;
using Ticari.BL.Managers.Abstract;
using Ticari.BL.Managers.Concrete;
using Ticari.Entities.Entities.Concrete;
using Ticari.TestConsole;

namespace Ticari.WebMVC.Controllers
{
    public class AccountController(IManager<Role> roleManager,IManager<MyUser> userManager) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Users()
        {
            var users = userManager.GetAllInclude(null, p => p.Roller).ToList();
            return View(users);
        }
    }
}
