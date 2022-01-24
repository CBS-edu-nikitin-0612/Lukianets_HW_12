using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side_a, side_b;
            Console.Write("Rectangle calculator: \nEnter side a = ");
            string a = Console.ReadLine();  

            Console.Write("Enter side b = ");
            string b = Console.ReadLine();
            Console.WriteLine();

            if (double.TryParse(a, out side_a) && double.TryParse(b, out side_b))
            {
                Rectangle rectangl1 = new Rectangle(side_a, side_b);
                Console.WriteLine(rectangl1);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
            Console.ReadKey();
        }
    }
}
