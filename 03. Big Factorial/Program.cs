using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            BigInteger facturial = 1;

            for (int i = 1; i <= number; i++)
            {
                facturial *= i;

            }
            Console.WriteLine(facturial);
        }
    }
}
