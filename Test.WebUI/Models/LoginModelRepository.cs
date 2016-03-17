using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web;
using Test.WebUI.Interfaces;
using System.Linq;

namespace Test.WebUI.Models
{
    public class LoginModelRepository : IUserRepository
    {
        private readonly List<LoginModel> _logins;
        public LoginModelRepository()
        {
            this._logins = GetAll();
        }
        private List<LoginModel> GetAll()
        {
            using (StreamReader streamReader = 
                new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/accounts.json")))
            {
                List<LoginModel> logins = JsonConvert
                    .DeserializeObject<List<LoginModel>>(streamReader.ReadToEnd());
                return logins;
            }     
        }

        public bool Login(string login, string password, string name)
        {
            var user = _logins.Where(x => x.Login == login && x.Name == name).FirstOrDefault();
            return (user != null && (user.Login == login && user.Name == name && user.Password == password))
                ? true : false;
        }
    }
}