using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            if (IsPrimeNumber(number)) Console.WriteLine($"{number} is prime number");
            else Console.WriteLine($"{number} is not prime number");
            Console.ReadKey();
           
            bool IsPrimeNumber(int num)
            {
                for (int counter = 2 ; counter < num; counter++)
                {
                    if (num % counter == 0) return false;
                }
                return true;
            }
        }

    }
}
