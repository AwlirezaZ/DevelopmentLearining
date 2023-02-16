using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            bool condition = false;
            bool x = true;

            Console.WriteLine(num++); //First Print Num Then Add 1
            Console.WriteLine(++num); //First Add 1 Then Print Num
            Console.WriteLine(num);
            Console.WriteLine(condition);
            Console.ReadKey();
        }
    }
}
