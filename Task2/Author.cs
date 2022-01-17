using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Author
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null)
                    _name = value;
                else
                    _name = "Unknown";
            }
        }

        public Author (string name)
        {
            Name = name;
        }

        public Author()
        {
            _name = "Unknown";
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Author: {Name}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
