using System;
using System.Globalization;

namespace Vetores {
    public class Exemplo01 {
        public void MediaAltura() {
            // Exemplo 01
            Console.Write("Digite a quantidade desejada: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite a altura {0}: ", (i+1));
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = {0}", avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
