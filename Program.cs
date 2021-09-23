using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            int number = Convert.ToInt32(Console.ReadLine());

            long fact = GetFactorial(number);

            Console.WriteLine("The factorial of {0} is {1}", number, fact);

            Console.ReadKey();

        }



        private static long GetFactorial(int number)
        {

            if (number == 0)
            {

                return 1;

            }

            return number * GetFactorial(number - 1);

        }

            
    }
}
