using System;

namespace ExProp_21 {
    public class Retangulo {
        public double Largura, Altura, Are, Per, Diag;

        public void Area() {
            Are = (Largura * Altura);
        }

        public void Perimetro() {
            Per = 2 * (Largura + Altura);
        }

        public void Diagonal() {
            Diag = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        
    }
}
