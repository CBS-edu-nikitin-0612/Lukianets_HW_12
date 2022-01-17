using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(2, 2, "A");
            Point b = new Point(2, 4, "B");
            Point c = new Point(4, 6, "C");
            Point d = new Point(6, 4, "D");
            Point e = new Point(6, 2, "E");

            Figure pentagon1 = new Figure(a, b, c, d, e);

            //Console.WriteLine($"Size = {Figure.LengthSize(a, b)}");
            //Console.WriteLine($"Size = {Figure.LengthSize(b, c)}");
            //Console.WriteLine($"Size = {Figure.LengthSize(c, d)}");
            //Console.WriteLine($"Size = {Figure.LengthSize(d, e)}");
            //Console.WriteLine($"Size = {Figure.LengthSize(a, e)}");

            Figure triangle1 = new Figure(a, b, c);
            //Console.WriteLine($"Size = {Figure.LengthSize(a, b)}");
            //Console.WriteLine($"Size = {Figure.LengthSize(b, c)}");
            //Console.WriteLine($"Size = {Figure.LengthSize(c, a)}");

            Figure rectangle1 = new Figure(a, b, d, e); 
            //pentagon1.PerimeterCalculator();
            Console.WriteLine(pentagon1);
            Console.WriteLine(triangle1);
            Console.WriteLine(rectangle1);

        }
    }
}
