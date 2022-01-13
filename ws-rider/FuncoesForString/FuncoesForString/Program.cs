using System;

namespace FuncoesForString {
    class Program {
        static void Main(string[] args) {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string maiuscula = original.ToUpper();
            string minuscula = original.ToLower();
            // Apaga os espaços em branco no final e no começo do string
            string espaco = original.Trim();
            
            // Procura um objeto qualquer dentro da string.
            int search = original.IndexOf("bc");
            // Procura a ultima ocorrencia
            int search2 = original.LastIndexOf("bc");
            
            // Cortando uma string  
            string corte = original.Substring(3, 7);
            string corte2 = original.Substring(3);
            
            // Substituir qualquer objeto dentro da string por outro
            string subs = original.Replace("a", "x");
            string subs2 = original.Replace("abc", "midnight ");

            // Testando se a string é nula ou vazia
            bool teste = string.IsNullOrEmpty(original);
            // Testando se a string é nula ou somente espaços
            bool teste2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + maiuscula + "-");
            Console.WriteLine("ToLower: -" + minuscula + "-");
            Console.WriteLine("TRIM: -" + espaco + "-");
            Console.WriteLine("IndexOf ('bc'): " + search);
            Console.WriteLine("LastIndexOf ('bc'): " + search2);
            Console.WriteLine("Substring (3, 7): " + corte);
            Console.WriteLine("Substring (3): " + corte2);
            Console.WriteLine("Replace ('a', 'x'): " + subs);
            Console.WriteLine("Replace ('abc', 'midnight '): " + subs2);
            Console.WriteLine("IsNullOrEmpty: " + teste);
            Console.WriteLine("IsNullOrWhiteSpace: " + teste2);
        }
    }
}
