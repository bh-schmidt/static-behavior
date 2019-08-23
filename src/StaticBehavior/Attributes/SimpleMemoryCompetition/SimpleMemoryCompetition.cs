namespace StaticBehavior.Attributes.SimpleMemoryCompetition
{
    public class SimpleMemoryCompetition
    {
        public static void Start()
        {
            System.Console.WriteLine("The 3 objects declared represents 3 different users trying to authenticate.");
            var user1 = new SignInLoginExampleClass();
            var user2 = new SignInLoginExampleClass();
            var user3 = new SignInLoginExampleClass();

            System.Console.WriteLine("The 3 users put their credentials and try to authenticate.");
            user1.Authenticate("user123", "123");
            user2.Authenticate("user456", "456");
            user3.Authenticate("user789", "789");

            System.Console.WriteLine("Now if the system tries to get the username of each user will get the last authenticated.");
            System.Console.WriteLine($"the username of ${nameof(user1)} is ${user1.GetUserName()}");
            System.Console.WriteLine($"the username of ${nameof(user2)} is ${user2.GetUserName()}");
            System.Console.WriteLine($"the username of ${nameof(user3)} is ${user3.GetUserName()}");

            System.Console.WriteLine("It occours because the static property doesn't belongs to the object, but the class.");
        }
    }
}
