using System;
using System.Globalization;
using System.Linq;

namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            var listOfDate = input.Split('-').Select(int.Parse).ToList();


            var dayOfWeed = new DateTime(listOfDate[2], listOfDate[1], listOfDate[0]);

            Console.WriteLine(dayOfWeed.DayOfWeek);
        }
    }
}