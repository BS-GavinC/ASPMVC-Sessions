using ASPMVC_Sessions.Context;
using ASPMVC_Sessions.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_Sessions.Controllers
{
    
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            FakeDB.Users.Add(new Context.User(
                FakeDB.Users.Last().Id + 1,
                registerViewModel.UserName,
                registerViewModel.Email,
                registerViewModel.Password));
            return RedirectToAction("Index", "Home");
        }
    }
}
