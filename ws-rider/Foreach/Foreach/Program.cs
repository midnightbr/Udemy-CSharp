using System;
using System.Threading.Channels;

namespace Foreach {
    class Program {
        static void Main(string[] args) {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };
            
            // Método com for para percorrer o vetor
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-------------------");

            // Método com o foreach para percorrer o vetor
            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
            
        }
    }
}
