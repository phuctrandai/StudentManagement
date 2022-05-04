using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
