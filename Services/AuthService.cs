using PIS_20_01.Controllers;

namespace PIS_20_01.Services
{
    internal class AuthService
    {
        static readonly DBController dbController;
        static AuthService()
        {
            dbController = new DBController();
        }

        internal static bool TryAuth(string username, string password)
        {
            return dbController.AuthUser(username, password);
        }
    }
}
