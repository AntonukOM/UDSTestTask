using System.Web;
using System.Web.Security;
using Test.WebUI.Models;

namespace Test.WebUI.Helpers.Managers
{
    public class FormsSecurityManager : ISecurityManager
    {
        public readonly LoginModelRepository _repository = new LoginModelRepository();
        public bool Login(string login, string password, string name)
        {
            if(_repository.Login(login, password, name))
            {
                FormsAuthentication.SetAuthCookie(login, false);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAuthentificated()
        {
            var user = HttpContext.Current.User;
            return (user != null) && (user.Identity != null) && (user.Identity.IsAuthenticated == true);
        }

        public void Logout()
        {
            FormsAuthentication.SignOut();
        }
    }
}