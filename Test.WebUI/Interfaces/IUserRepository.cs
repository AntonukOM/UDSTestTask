namespace Test.WebUI.Interfaces
{
    public interface IUserRepository
    {
        bool Login(string login, string password, string name);
    }
}