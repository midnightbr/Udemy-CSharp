using System;

namespace ExProp_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] - Etanol");
            Console.WriteLine("[2] - Gasolina");
            Console.WriteLine("[3] - Diesel");
            Console.WriteLine("[4] - Encerrar programa");
            Console.Write("Qual combustivel foi abastecido? ");
            posto();
        }

        static void posto()
        {
            int comb = 0;
            int etanol = 0;
            int gasolina = 0;
            int diesel = 0;
            while (comb != 4)
            {
                comb = int.Parse(Console.ReadLine());
                if (comb == 1)
                {
                    etanol += 1;
                }
                else if (comb == 2)
                {
                    gasolina += 1;
                }
                else if (comb == 3)
                {
                    diesel += 1;
                }
                Console.Write("Qual combustivel foi abastecido? ");
            }

            Console.WriteLine();
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Etanol = " + etanol);
            Console.WriteLine("Gasolina = " + gasolina);
            Console.WriteLine("Diesel = " + diesel);
        }
    }
}
