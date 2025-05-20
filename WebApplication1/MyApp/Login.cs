using System;

namespace MyApp
{
    public class Login : Item
    {
        public Login() : base("[1] Login") { }
        public override void Execute()
        {
            Console.WriteLine("\nLogging in the user...");
            var username = GetCredential("Enter username: ");
            var password = GetCredential("Enter password: ");
            if (Storage.Validate(username, password))
            {
                Console.WriteLine($"Welcome `{username}`...");
                Console.WriteLine("Signing out...\n");
                return;
            }
            Console.WriteLine("Incorrect credentials.\n");
        }
    }
}