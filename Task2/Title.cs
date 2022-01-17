using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Title
    {
        private string _title;

        public string Ttl
        {
            get { return _title; }
            set
            {
                if (value != null)
                    _title = value;
                else
                    _title = "Unknown";
            }
        }

        public Title(string title)
        { 
            this._title = title;
        }

        public Title()
        {
            _title = "Unknown";
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Title: {Ttl}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
