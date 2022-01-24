using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("C# 5.0");
            book1.Author = "Bart De Smet";
            book1.Content = "\t1. Introduction the .NET Platform \n\t2. Introduction the C#\n\t3. ... ";
            book1.Show();

            Console.ReadLine();

        }
    }
}
