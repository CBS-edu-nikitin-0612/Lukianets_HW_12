using System;

namespace Task2
{
    internal class Content
    {
        private string _content;

        public string Cntt 
        { 
            get { return _content; } 
            set
            {
                if (value != null)
                    _content = value;
                else 
                    _content = "To be continued...";
            }
        }

        public Content()
        {
            _content = null;
        }

        public Content(string content)
        {
            Cntt = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Cntt);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
