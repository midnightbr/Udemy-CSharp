using System;

namespace ExProp_007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("O número digitado não é NEGATIVO.");
            }
            else
            {
                Console.WriteLine("O número digitado é NEGATIVO.");
            }
        }
    }
}
