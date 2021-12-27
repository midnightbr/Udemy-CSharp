using System;
using System.Globalization;

namespace MembroEstatico {
    class Program {
        // Criando funções auxiliares dentro do programa principal
        // static double Pi = 3.14;
        
        static void Main(string[] args) {

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            /**
             * Devido ao fato de que as funções dentro da classe estarem com
             * public, para poder acessar pelo programa principal e
             * static, pois como são funções matématicas e continuam as mesmas,
             * fazendo assim com que não seja necessario estanciar a classe Calculadora para
             * utilizar as funções. Basta utilizar conforme o exemplo abaixo.
             */
            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferência: {0}", circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: {0}", volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: {0}", Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        /**
            static double Circuferencia(double raio) {
                return 2.0 * Pi * raio;
            }

            static double Volume(double raio) {
                return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
            }
         */
        
    }
}
