using System;

namespace EntradaDeDados_Parte1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string red = Console.ReadLine();
            string green = Console.ReadLine();
            string blue = Console.ReadLine();

            /*
             * string s = Console.ReadLine();
             */
            
            // Separando os itens da frase em vetores.
            //string[] vetor = s.Split(' ');

            // Outro metodo para adicionar valores a uma variavel e separar em um array de forma direta é usando:
            string[] vetor = Console.ReadLine().Split(' ');
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(red);
            Console.WriteLine(green);
            Console.WriteLine(blue);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
