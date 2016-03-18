namespace Test.WebUI.Interfaces
{
    public interface ILoginRepository
    {
        bool Login(string login, string password, string name);
    }
}