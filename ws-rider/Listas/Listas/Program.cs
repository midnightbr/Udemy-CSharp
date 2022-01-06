using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Listas {
    class Program {
        static void Main(string[] args) {
            
            // Lembrando que os itens começa com index 0
            List<string> list = new List<string>();
            
            // A opção Add por padrão adiciona o elemento ao final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Duquesa");
            list.Add("Duck");

            // Já a opção Insert adiciona o elemento na posição que você desejar
            list.Insert(2, "Marco");
            list.Insert(3, "Fabiana");
            list.Insert(5, "Marcos");
            
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            // Contar quantos itens tem na lista
            Console.WriteLine("List count: " + list.Count);

            Console.WriteLine();
            
            /**
             * A função Find recebe como argumento, uma função que faz um teste.
             */
            // Encontar o primeiro nome que começa com 'A'
            string s1 = list.Find(x => x[0] == 'A'); // Usando expressão lambda
            // string s1 = list.Find(Test); // Também aceita com funções 
            
            // Encontrar o index do primeiro nome que começa com 'A'
            int pos1 = list.FindIndex(x => x[0] == 'A');

            Console.WriteLine("First 'A': " + s1);
            Console.WriteLine("First position 'A': " + pos1);

            Console.WriteLine();
            
            // Encontrar o ultimo nome que começa com 'A'
            string s2 = list.FindLast(x => x[0] == 'A'); // Usando expressão lambda
            
            // Encontrar o index do ultimo nome que comeca com 'A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            
            Console.WriteLine("Last 'A': " + s2);
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("-------------------------");
            
            /**
             * Criar um filtro no qual cria uma nova lista com base na anterior, no qual so tera elementos que
             * satisfaça o filtro estabelecido
             */
            List<string> result = list.FindAll(x => x.Length == 5);
            foreach (string obj in result) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------");
            
            // Remover um elemento da lista
            list.Remove("Alex");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------");
            
            // Remover com um parametro de filtro
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------");
            
            // Remover um elemento pela posição dele
            list.RemoveAt(1);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------");
            
            // Remover elementos em uma faixa
            list.RemoveRange(2, 2); // A partir da posição dois, remova dois elementos
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            
        }
        
        // static bool Test(string s) {
        //     return s[0] == 'A';
        // }
    }
}
