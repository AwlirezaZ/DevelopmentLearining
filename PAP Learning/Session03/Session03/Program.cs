using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP , Access Modifier , Class , Field , Object, Constructor

            //syntax error => int number = "alireza";
            //runtime error => zero division , null reference
            //logical error => DoDivision(int a,int b) return a * b;

            Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int num2 = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"result is {DoDivision(num1, num2)}");
            Console.ReadKey();

            int DoDivision(int a, int b)
            {
                try
                {
                    return a / b;
                }
                catch (PAPLearningExeption e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
                
            }
        }
        
    }
}
