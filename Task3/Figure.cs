using System;
using System.Linq;

namespace Task3
{
    internal class Figure
    {
        private readonly Point[] pointArr;
        private readonly string _name;

        public Figure(Point p1, Point p2, Point p3) : this(p1, p2, p3, null, null) { }
        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3, p4, null) { }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            // Initialize max array size
            Point[] tempArr = new Point[5];
            tempArr[0] = p1;
            tempArr[1] = p2;
            tempArr[2] = p3;
            if (p4 != null)
                tempArr[3] = p4;
            if (p5 != null)
                tempArr[4] = p5;

            // Get into this.pointArr array only non-null points
            pointArr = tempArr.Where(p => p != null).ToArray();

            // Initialize Figure's name according to the number of Points
            int numOfPoints = pointArr.Length;
            switch (numOfPoints)
            {
                case 3:
                    _name = "triangle";
                    break;
                case 4:
                    _name = "quadrangle";
                    break;
                case 5:
                    _name = "pentagon";
                    break;
            }
        }

        public static double LengthSize(Point A, Point B)
        {
            return Math.Round(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)), 2);
        }

        public void PerimeterCalculator()
        {
            // distance beetween first and last point
            double perimeter = LengthSize(pointArr[0], pointArr[pointArr.Length - 1]); 
            
            for (int i = 0; i < pointArr.Length - 1; i++)
                perimeter += LengthSize(pointArr[i], pointArr[i + 1]);

            Console.WriteLine($"Perimeter = {perimeter}");
        }

        public override string ToString()
        {
            foreach (var point in pointArr)
                Console.WriteLine(point);
            Console.WriteLine($"Figure: {_name}");
            PerimeterCalculator();
            return $"\n";
        }

    }
}
