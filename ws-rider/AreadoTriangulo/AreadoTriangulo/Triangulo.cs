using System;

namespace AreadoTriangulo {
    public class Triangulo {
        // Nome de atributo começa com a letra Maiuscula
        public double A;
        public double B;
        public double C;
        
        // Criando o metodo de calculo da aréa
        public double Area() {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
