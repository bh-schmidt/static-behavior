using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace StaticBehavior.Attributes.SimpleMemoryCompetition
{
    public class SignInLoginExampleClass
    {
        private static string UserName;

        public string GetUserName() => UserName;

        public void Authenticate(string userName, string password)
        {
            System.Console.WriteLine($"Authenticating the ${userName} and the password ${password}.");

            if (IsCorrectPassword(userName, password))
            {
                System.Console.WriteLine($"The user ${userName} was authenticated successfully and the username is in the static property.");
                UserName = userName;
            }
        }

        private bool IsCorrectPassword(string userName, string password)
        {
            if (userName == "user123" && password == "123")
            {
                return true;
            }

            if (userName == "user456" && password == "456")
            {
                return true;
            }

            return false;
        }
    }
}
