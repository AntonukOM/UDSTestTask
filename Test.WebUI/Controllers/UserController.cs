using System.Collections.Generic;
using System.Web.Mvc;
using Test.WebUI.Interfaces;
using Test.WebUI.Models;

namespace Test.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController()
        {
            //ViewBag.UserName = (TempData["Name"] != null) ? TempData["Name"].ToString() : "Unknown hero";
            this._userRepository = new UserModelRepository();
        }
        // GET: User
        [HttpGet]
        public ActionResult All()
        {
            ViewBag.UserName = Session["Name"];
            ViewBag.Users = _userRepository.GetUsers();
            return View();
        }

        [HttpGet]
        public ActionResult Detail(string id)
        {
            ViewBag.UserName = Session["Name"];
            var user = _userRepository.GetUserByGuid(id);
            return View(user);
        }

        [HttpGet]
        public ActionResult FilterByTag(string filter)
        {
            List<UserModel> users = _userRepository.FilterByTag(filter);
            return PartialView("UserListPartial", users);
        }
    }
}