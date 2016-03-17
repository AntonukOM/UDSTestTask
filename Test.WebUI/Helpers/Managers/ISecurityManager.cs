namespace Test.WebUI.Helpers.Managers
{
    public interface ISecurityManager
    {
        bool Login(string login, string password, string name);
        void Logout();
        bool IsAuthentificated();
    }
}