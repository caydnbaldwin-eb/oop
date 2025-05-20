using System;

namespace MyApp
{
    public class SignUp : Item
    {
        public SignUp() : base("[0] Sign Up") { }

        // This Execute method runs like a programatic script. How could I implement polymorphism and SOLID principles here?
        // Single-responsibility > Open-closed > Liskoc substitution > Interface segregation > Dependency inversion
        public override void Execute()
        {
            Console.WriteLine("\nCreating a new user...");
            var username = GetCredential("Enter username: ");
            var password = GetCredential("Enter password: ");
            var user = new User(username, password);
            Storage.Add(user);
            Console.WriteLine($"User `{username}` created successfully...\n");
        }
    }
}