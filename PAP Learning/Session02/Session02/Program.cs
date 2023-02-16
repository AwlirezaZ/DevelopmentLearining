using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session02
{
    static class Program
    {
        static void Main(string[] args)
        {


            //Convert DataTypes : 1.Implicit 2.Explicit

            #region Implicit

            int a = 10;
            long b = 10;

            #endregion

            #region Explicit
            long num1 = 20; //20000000000000
            int num2 = 30;  //10000000000000
            int result;
            result = (int)num1; // (DestinationSource)Variable
            Console.WriteLine(result);


            byte destinationVar;
            short sourceVar = 260;
            destinationVar = checked((byte)sourceVar); // checked((DestinationSource)Variable)
            Console.WriteLine($"sourceVar val: {sourceVar}");
            Console.WriteLine($"destinationVar val: {destinationVar}");
            Console.ReadKey();


            #endregion

            #region Arrays
            int[] myArray = new[] { 12, 13 };
            var x = myArray[1];
            int[,] my2Dimension = { { 12, 14 }, { 15, 14 } };
            #endregion

            PrintNumber(12);
            WhatIfOurVoidMethodHasReturn("a");
            DateTime date = DateTime.Now;
            //MethodWithDefaultParameters("alireza",date);
            int number = 12;
           
            MethodWithDefaultParameters("alireza",date,22);
            Console.ReadKey();

        }

      
        public static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }

        public static bool IsNumbersEqual(int num1,int num2)
        {
            return (num1 == num2);
        }

        public static int AddOneNumber(int number)
        {
            //return (number - 1);
            int result = number - 1;
            return result;
        }

        public static void WhatIfOurVoidMethodHasReturn(string text)
        {
            if (text == "a")
            {
                return;
            }
            text = "a";
        }

        public static void MethodWithDefaultParameters(string name, DateTime birth,int age =50)
        {
            //age parameter is optional
            Console.WriteLine($"Name: {name} , Age: {age} , Birth: {birth} ");
        }

        public static int GetSquareOfANumber(this int x)
        {
            return x * x;
        }

        public static void MethodWithDefaultParameters(string name, int age)
        {
            Console.WriteLine($"Name: {name} , Age: {age}");
        }

    }
}
