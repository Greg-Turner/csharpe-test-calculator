using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(54, 29));
            Console.WriteLine(calculator.Subtract(54, 29));
            Console.WriteLine(calculator.Multiply(2, 1.5));
            Console.WriteLine(calculator.Divide(3, 1.5));
        }
    }
}
