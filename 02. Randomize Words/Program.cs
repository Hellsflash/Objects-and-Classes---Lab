using System;
using System.Linq;

namespace _02.Randomize_Words
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(' ').ToList();

            var randomNumGen = new Random();



            for (int pos1 = 0; pos1 < input.Count; pos1++)
            {
                var currentWord = input[pos1];
                var pos2 = randomNumGen.Next(0, input.Count);

                var temp = input[pos2];
                input[pos1] = temp;
                input[pos2] = currentWord;

            }

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

        }
    }
}
