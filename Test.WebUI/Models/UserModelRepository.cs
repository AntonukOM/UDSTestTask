using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Test.WebUI.Interfaces;

namespace Test.WebUI.Models
{
    public class UserModelRepository : IUserRepository
    {
        public List<UserModel> GetUsers()
        {
            using (StreamReader streamReader =
                new StreamReader(HttpContext.Current.Server.MapPath("~/App_Data/data.json")))
            {
                List<UserModel> users = JsonConvert
                    .DeserializeObject<List<UserModel>>(streamReader.ReadToEnd());
                return users;                    
            }
        }

        public UserModel GetUserByGuid(string guid)
        {
            var user = GetUsers().Where(u => u.Guid == guid).FirstOrDefault();
            return user;
        }

        public List<UserModel> FilterByTag(string tag)
        {
            List<UserModel> filteredUsers = new List<UserModel>();
            var result = from u in GetUsers()
                         from t in u.Tags
                         where t == tag
                         select u;
            foreach (var user in result)
            {
                filteredUsers.Add(user);
            }
            return filteredUsers;
        }
    }
}