using System.Web.Mvc;
using Test.WebUI.Helpers.Managers;
using Test.WebUI.Models;

namespace Test.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISecurityManager _loginManager;
        public LoginController()
        {
            this._loginManager = new FormsSecurityManager();          
        }
        // GET: Login
        [HttpGet]
        public ActionResult SingIn()
        {
            if(_loginManager.IsAuthentificated())
            {
                return RedirectToAction("All", "User");
            }
            return View();
        }

        [HttpPost]
        public ActionResult SingIn(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {                
                if (_loginManager.Login(loginModel.Login, loginModel.Password, loginModel.Name))
                {
                    Session["Name"] = loginModel.Name;
                    return RedirectToAction("All", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Credentials are not correct!");
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult LogOut()
        {
            _loginManager.Logout();
            return RedirectToAction("SingIn");
        }
    }
}