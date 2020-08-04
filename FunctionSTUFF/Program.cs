using System;

namespace FunctionSTUFF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calculator = new Calculator();
            double d = calculator.CalculateFunction(13, "+ 1 / 2");
            Console.WriteLine(calculator.CalculateFunction(d, calculator.GetInverseFunction("+ 1 / 2")));
        }
    }
}
