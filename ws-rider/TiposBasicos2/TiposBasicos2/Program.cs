using System;
using System.Globalization;

namespace TiposBasicos2 {
    class Program {
        static void Main(string[] args) {
            // Guarda valores verdadeiro ou falso
            bool completo = false;
            
            // Usado para guarda um caractere unicode
            char genero = 'M';
            // Usado o char com o código unicode
            char letra = '\u0041'; // Código da letra A
            
            // Para declarar uma variavel do tipo float, precisa-se adicionar o f no final dos números
            float n1 = 4.5f;

            // Para declarar uma variavel double, não necessita adicionar o f no final.
            double n2 = 4.5;
            
            // Declaração para uma variavel com um texto precisa-se adicionar aspas duplas (") no qual ela é imutavel
            string nome = "Marcos Henrique";
            
            // Object é uma variavel universal
            object obj1 = "Goiânia-GO";
            object obj2 = 7.58f;
            object obj3 = 5;
            
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);

            // Min e Max valores que podem ser recebidos
            int min = int.MinValue;
            int max = int.MaxValue;
            sbyte n3 = SByte.MinValue;
            decimal n4 = Decimal.MaxValue;


            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            
            /*
             * Suponhamos que queiramos imprimir um valor do tipo double,
             * mais com apenas as duas primeiras classes decimais, como fazer?
             * Segue o exemplo a abaixo de como fazer esse procedimento.
             */
            double saldo = 105.56982;
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F3")); // "F" delimita a quantidade de casas decimais que queremos
            
            // Para poder trocar a "," no separador de decimais pelo "." basta seguir o exemplo abaixo.
            // Primeiro necessita-se do using System.Globalization no começo do programa.
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
