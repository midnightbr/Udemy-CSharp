using System;

namespace ExProp_19 {
    class Program {
        static void Main(string[] args) {
            Pessoas one = new Pessoas();
            Pessoas two = new Pessoas();
            
            // Recebendo dados do usuário sobre a primeira pessoa
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            one.nome = Console.ReadLine();
            Console.Write("Idade: ");
            one.idade = int.Parse(Console.ReadLine());
            
            // Recebendo dados do usuário sobre a segunda pessoa
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            two.nome = Console.ReadLine();
            Console.Write("Idade: ");
            two.idade = int.Parse(Console.ReadLine());

            if (one.idade > two.idade) {
                Console.WriteLine("Pessoa mais velha: {0}", one.nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: {0}", two.nome);
            }

        }
    }
}
