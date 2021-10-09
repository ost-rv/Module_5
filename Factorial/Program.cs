using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factorial = " + Factorial(number));


            Console.WriteLine("Enter pow");
            byte pow = byte.Parse(Console.ReadLine());

            Console.WriteLine($"{number} pow {pow} = " + PowerUp(number, pow));
            
            Console.ReadKey();
        }

        static decimal Factorial(decimal x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private static int PowerUp(int N, byte pow)
        {
            int result = 0;

            if (pow == 0)
            {
                result = 1;
            }
            else  if (pow == 1)
            {
                result = N;
            }
            else
            { 
                result = N * PowerUp(N, (byte)(pow - 1)); 
            }

            return result;
        }
    }
}
