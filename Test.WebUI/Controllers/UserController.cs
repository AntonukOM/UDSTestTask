using System.Web.Mvc;

namespace Test.WebUI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult All()
        {
            return View();
        }
    }
}