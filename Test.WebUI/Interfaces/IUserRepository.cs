using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.WebUI.Models;

namespace Test.WebUI.Interfaces
{
    public interface IUserRepository
    {
        List<UserModel> GetUsers();
        UserModel GetUserByGuid(string guid);
        List<UserModel> FilterByTag(string tag);
    }
}
