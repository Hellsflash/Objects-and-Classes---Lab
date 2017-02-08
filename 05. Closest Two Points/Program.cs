using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currPointParts =
                    Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    x = currPointParts[0],
                    y = currPointParts[1]
                });
            }
            var minDistance = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currDistance =
                        Calculate(firstPoint, secondPoint);

                    if (currDistance < minDistance)
                    {
                        minDistance = currDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({firstPointMax.x}, {firstPointMax.y})");
            Console.WriteLine($"({secondPointMax.x}, {secondPointMax.y})");
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
