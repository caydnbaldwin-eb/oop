using System;

namespace MyApp
{
    public class Menu()
    {
        private readonly List<Item> _items = new List<Item>
        {
            new SignUp(),
            new Login(),
            new End()
        };

        public override string ToString()
        {
            var text = "Main Menu:";
            foreach (var item in _items)
            {
                text += "\n" + item.Description;
            }
            return text;
        }

        public void Select(int input)
        {
            if (input < 0 || input >= _items.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }
            _items[input].Execute();
        }
    }
}