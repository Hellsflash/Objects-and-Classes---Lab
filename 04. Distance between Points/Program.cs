using System;
using System.Linq;

namespace _04.Distance_between_Points
{

    public class Program
    {
        public class Point
        {
            public double x { get; set; }
            public double y { get; set; }
        }



        public static void Main(string[] args)
        {
            var firstPointParts =
                Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var first = new Point
            {
                x = firstPointParts[0],
                y = firstPointParts[1]
            };
            var secondPoinParts =
                Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var second = new Point
            {
                x = secondPoinParts[0],
                y = secondPoinParts[1]
            };
            var result = Calculate(first, second);

            Console.WriteLine($"{result:F3}");
        }

        public static double Calculate(Point firstPoin, Point secondPoint)
        {
            var diffX = firstPoin.x - secondPoint.x;
            var diffY = firstPoin.y - secondPoint.y;

            var PowX = Math.Pow(diffX, 2);
            var PowY = Math.Pow(diffY, 2);

            return Math.Sqrt(PowX + PowY);
        }
    }
}
