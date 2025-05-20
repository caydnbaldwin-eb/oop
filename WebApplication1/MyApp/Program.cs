using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var menu = new Menu();
                Console.WriteLine(menu);
                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    menu.Select(userInput);
                }
            }
        }
    }
}