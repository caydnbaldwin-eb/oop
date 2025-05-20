using System;

namespace MyApp
{
    public abstract class Item
    {
        public string Description { get; }

        protected Item(string description)
        {
            Description = description;
        }

        public string GetCredential(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public abstract void Execute();
    }
}