using System;

namespace MyApp
{
    public class End : Item
    {
        public End() : base("[2] End Program") { }
        public override void Execute()
        {
            Console.WriteLine("\nEnding Program...");
            Environment.Exit(0);
        }
    }
}