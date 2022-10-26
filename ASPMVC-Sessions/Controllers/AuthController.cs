using ASPMVC_Sessions.Context;
using ASPMVC_Sessions.Models;
using ASPMVC_Sessions.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC_Sessions.Controllers
{
    public class AuthController : Controller
    {
        private readonly SessionManager _sessionManager;

        public AuthController(SessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            User? user = FakeDB.Users.FirstOrDefault(u => u.Email.ToUpper() == loginViewModel.Email.ToUpper(), null);

            if (user == null)
            {
                return View();
            }

            if (user.Password == loginViewModel.Password)
            {
                _sessionManager.Email = user.Email;
                _sessionManager.UserName = user.UserName;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult Disconnect()
        {
            _sessionManager.Clear();
            return RedirectToAction("Index", "Home");
        }

        
    }
}
