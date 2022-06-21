using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        // Função criada para reutilização
        // Sempre que precisar imprimir uma coleção de objetos, utilizar essa função
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            // Imprimindo a mensagem no console
            Console.WriteLine(message);
            // Imprimindo os objetos no console
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            // Separando as listar imprimidas com uma linha
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Demo Linq
            // Cadastrando novas categorias
            Category category1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
            Category category2 = new Category() { Id = 2, Name = "Computers", Tier = 1};
            Category category3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            // Criando uma lista de produtos
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.00, Category = category2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = category1},
                new Product() { Id = 3, Name = "TV", Price = 1700.00, Category = category3},
                new Product() { Id = 4, Name = "Notebook", Price = 1300.00, Category = category2},
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = category1},
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = category2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = category3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = category3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = category2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = category3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = category1 }
            };

            // Criando Linq para filtar um tipo de produto, no qual vai listar
            // os produtos que tiverem tier = 1 e price < 900
            var filter1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);
            // Utilizando a função print para imprimir o objetos do filter1 na tela
            Print(message: "TIER 1 And Price < 900:", collection: filter1);

            // Filtrando os que tenha o category 'tools', depois criando uma lista somente com os nomes
            // dos objetos que tenham essa category
            var filter2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Print(message: "Names of products from tools:", filter2);

            // Filtrando a lista de produtos no qual quero somente os produtos com a letra 'C'
            // Ainda, vai mostrar apenas o nome do produto, preço e o nome da categoria. Para fazer isso
            // usaremos uma função anonima (o qual não existe no projeto)
            var filter3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            // Obs.: Para evitar o erro de ter duas variaveis com o mesmo nome (name), é necessario
            // criar um apelido para a variavel(uma nova variavel), no qual recebera o valor. No exemplo acima,
            // foi necessario fazer isso com o Category.
            Print(message: "Names started width 'C' and anonymous object:", filter3);

            // Filtrando a lista de produtos por produtos que tenha o Tier igual a 1
            // Além disso, noo método abaixo, demonstra como ordenar os objetos por preço e após a ordenancia
            // por preço, ordenar por nome
            var filter4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            Print(message: "Tier 1 order by price then by name:", filter4);
            // Resultado, quando dois objetos tem o mesmo valor, o programa ira utilizar o nome para definir
            // a ordem, como no exemplo acima.

            // Selecionando alguns objetos da lista, no caso, o método abaixo vai primeiramente
            // pular os 2 primeiros objetos da lista. Após isso ele ira selecionar os
            // proximos 4 objetos e adicionalos em uma nova lista. Nesse caso, vamos utilizar a lista do filter4
            // Skip -> Pular
            // Take -> Pegar
            var filter5 = filter4.Skip(2).Take(4);
            Print(message: "Tier 1 order by price then by name, skip 2 take 4:", filter5);

            // Caso queiramos pegar o primeiro objeto da lista basta adicionar o método .First(),
            // no entanto podemos ter uma lista vazia caso não tenha nenhum objeto dentro dos parametros
            // do filtro que adicionamos. Para isso temos o .FirstOrDefault(), no qual retorna nulo caso
            // não tenha nenhum objeto, invés de retorna vazio.
            /*
            var filter6 = products.Where(x => x.Price > 3000.00).First();
            Console.WriteLine("First test: " + filter6);
            */
            // No exemplo acima vai retorna uma lista vazia, devido ao fato de não termos nenhum objeto com um valor
            // acima de 3000.00, isso é proposital para demonstrar o erro ocorrendo.
            var filter7 = products.Where(x => x.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("Filter or default test: " + filter7);
            Console.WriteLine();
            // Aqui está a solução do problema com o filter6.

            // Filtrando a lista, no qual queremos apenas um objeto que tenha o Id = 3,
            // no qual ele funciona apenas quando o resultado é apenas um objeto, caso haja mais de
            // um, ocorrera um erro na execução
            var filter8 = products.Where(x => x.Id == 3).SingleOrDefault();
            // Note que por utilizar o SingleOrDefault o objeto não é to IEnumerable.
            Console.WriteLine("Single or default: " + filter8);
            Console.WriteLine();

            // Obs.: para que o programa não quebre com um erro, comente o filter6 no qual foi utilizado
            // apenas para meios demonstrativos do erro ocorrendo.

            // Separando as listas
            Console.WriteLine("===============================");

            // Criando uma lista de dados para demonstrar a utilização de Linq
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Definindo expressão query (Linq)
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            // No caso acima, utilizamos a função 'where' do linq, no qual
            // ele vai testar se o numero é par ou impar.
            // Após esse teste, ele seleciona o objeto com a função 'select'
            // no qual aplica uma alteração no objeto, multiplicando ele por 10

            // Executando a query
            // Imprimindo a lista modificado somente com valores pares
            // multiplicados por 10
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
            
            // Separando as listas
            Console.WriteLine("=============");
            
            // Imprimindo a lista original
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
        }
    }
}
