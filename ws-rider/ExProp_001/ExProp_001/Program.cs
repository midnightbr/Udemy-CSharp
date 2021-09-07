using System;

namespace ExProp_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int number01;
            int number02;
            int result;

            Console.WriteLine("Digite apenas números inteiros!");
            Console.Write("Primeiro número: ");
            number01 = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            number02 = int.Parse(Console.ReadLine());

            result = number01 + number02;

            Console.WriteLine("Resultado da soma: " + result);
        }
    }
}
