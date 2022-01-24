using System;

namespace Task1
{
    internal class Rectangle
    {
        private double side1, side2;

        public double Side1
        { 
            get
            {
                return side1;
            }
            set
            {
                if (value > 0)
                    side1 = value;
                if (value < 0)
                    Console.WriteLine("Wrong value!");
            }
        }
        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                if (value > 0)
                    side2 = value;
                if (value < 0)
                    Console.WriteLine("Wrong value!");
            }

        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2); 
        }

        public override string ToString()
        {
            return $"Rectangle: a = {Side1}, b = {Side2}\n" +
                $"Area = {Area}; Perimeter = {Perimeter}.\n";
        }
    }
}
