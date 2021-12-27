using System;
using System.Globalization;

namespace ExProp_23 {
    public class Aluno {
        public string nome;
        public double nota1, nota2, nota3, media;

        public double Nota(double nota1, double nota2, double nota3) {
            media = nota1 + nota2 + nota3;
            return media;
        }

        public void Final() {
            Nota(nota1, nota2, nota3);
            
            if (media >= 60) {
                Console.WriteLine("NOTA FINAL = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else {
                double faltando = 60 - media;

                Console.WriteLine("NOTA FINAL = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} pontos.", faltando.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
