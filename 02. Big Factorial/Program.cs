using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger resul = 1;

            for (int i = 1; i <= input; i++)
            {
                resul *= i;
            }
            Console.WriteLine(resul);
        }
    }
}
