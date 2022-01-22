using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address home = new Address(45002, "Spain", "Barcelona", "Gaudi", "70A", 22);
            Console.WriteLine(home);
            Console.ReadLine();
        }
    }
}
