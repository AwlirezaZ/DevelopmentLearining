using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    class Program
    {
        static void Main(string[] args)
        {
            //access modifiers => done
            //OOP => DONE
            //Class => shift + ctrl + a
            //object => done
            //field => done
            //ctor (constructor) => done
            //method => done
            //static 

            Student student1 = new Student("Atefeh");
            Student student2 = new Student("Parisa");

            student1.PrintAllInfo();
            student2.PrintAllInfo();

            Math math = new Math();
            var resultWithMathClass = math.CalculatePower(3, 2);

            var resultWithStaticClass = MathHelper.CalculatePower(3, 3);

            Console.WriteLine(resultWithMathClass);
            Console.WriteLine(resultWithStaticClass);
            Console.WriteLine();
            Console.ReadKey();

        }
        
    }
}
