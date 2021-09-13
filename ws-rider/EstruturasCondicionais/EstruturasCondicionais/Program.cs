using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeiro exemplo de condição (if-else)
            Console.Write("Entre com um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("O número digitado é par.");
            }
            else {
                Console.WriteLine("O número digitado é impar.");
            }
            
            // Segundo exemplo de condição (if-else-else if)
            Console.Write("Qual a hora atual? ");
            int hour = int.Parse(Console.ReadLine());
            if (hour >= 6 && hour < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hour < 19)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hour < 24)
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
