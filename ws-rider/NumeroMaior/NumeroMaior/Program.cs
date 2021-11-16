using System;

namespace NumeroMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine()); 

            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("O maior número digitado foi: " + resultado);
            // F8 debugger passo a passo
            // F7 entrada dentro da função no debugger
        }

        static int Maior(int a, int b, int c)
        {
            int maior;
            if(a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}
