using Course.Services;
using System;

namespace Delegate
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
