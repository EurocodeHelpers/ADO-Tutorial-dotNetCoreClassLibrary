using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = CalculatorLibrary.CalculatorLibrary.AddTwoNumbers(3, 5);
            System.Console.WriteLine(x);
        }



    }
}
