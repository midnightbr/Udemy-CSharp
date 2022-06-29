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

            // Obs.: para que o programa não quebre com um erro, comente o filter6 no qual foi utilizado
            // apenas para meios demonstrativos do erro ocorrendo.

            // Filtrando a lista, no qual queremos apenas um objeto que tenha o Id = 3,
            // no qual ele funciona apenas quando o resultado é apenas um objeto, caso haja mais de
            // um, ocorrera um erro na execução
            var filter8 = products.Where(x => x.Id == 3).SingleOrDefault();
            // Note que por utilizar o SingleOrDefault o objeto não é to IEnumerable.
            Console.WriteLine("Single or default: " + filter8);
            Console.WriteLine();

            /*
             * OPERAÇÕES DE AGREGAÇÃO
             */

            // Suponto que queremos descobrir qual o maior valor dentro dos objetos
            // no entanto não sabendo qual é esse valor, basta utilizar a expressão .Max(), no qual
            // usaremos a expressão Lambda para poder informar qual campo será utilizado para
            // o comparativo. Caso não seja especificado qual sera o dado para comparação, ele espera que o objeto
            // tenha implementado um criterio de comparação. Caso não haja, ele ira retorna um erro na aplicação.
            var filter9 = products.Max(x => x.Price);
            Console.WriteLine($"Max price: ${filter9}");
            // Da mesma forma que temos o .Max() para selecionar o maior valor, temos também o .Min() para
            // selecionar o menor valor dentro da lista.
            var filter10 = products.Min(x => x.Price);
            Console.WriteLine($"Min price: ${filter10}");

            // Podemos também filtrar a lista para obter os objetos que queremos e somar os valores deles.
            // No exemplo abaixo, filtramos para produtos que tenham um Category Id = 1 para depois especificar
            // que queremos o total da soma de todos os objetos no campo price.
            var filter11 = products.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            Console.WriteLine($"Category 1 sum prices: ${filter11}");
            // Além de pegar a soma total dos valores, podemos também obter o valor da média entre todos os objetos
            // como monstra o exemplo abaixo:
            var filter12 = products.Where(x => x.Category.Id == 1).Average(x => x.Price);
            Console.WriteLine($"Category 1 average price: ${filter12}");
            // No entanto, se o resultado do objeto for nulo, acabara quebrando o código na sua execução.
            // Para evitar tal problema, podemos usar um macete muito simples que está no código abaixo.
            // Primeiro, usaremos o select para poder selecionar o objeto.
            // Depois do objeto selecionado, usaremos o método .DefaultIfEmpty(com o valor default aqui dentro),
            // assim, mesmo que o valor seja nulo, ele retornara uma valor padrão, evitando a quebra da execução.
            // Como já selecionamos o price no select, não é necessario seleciona-lo no average.
            var filter13 = products.Where(x => x.Category.Id == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Category 5 average price: ${filter13}");

            /*
             * CRIANDO UM MÉTODO PERSONALIZADO
             */
            // Para criar o método personalizado, primeiro temos que selecionar o campo que iremos trabalhar,
            // nesse caso o campo price.
            // Após o campo selecionado, utilizamos o .Aggregate que recebe uma expressão Lambda do que
            // deve ser feito.
            // No exemplo abaixo, criamos uma função no qual ela somara todos os prices dos objetos que tenham o Category com
            // o Id = 1, para efeito de comparativo com uma função que ja temos para essa mesma utilidade.
            var filter14 = products.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate((x, y) => x + y);
            Console.WriteLine($"Category 1 aggregate sum: ${filter14}");
            // Mais e se caso o objeto for nulo? Para evitar esse tipo de problema, podemos informar
            // um valor inicial. Segue o exemplo abaixo:
            var filter15 = products.Where(x => x.Category.Id == 5).Select(x => x.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine($"Category 5 aggregate sum: ${filter15}");

            // Separando os objetos
            Console.WriteLine();

            // Podemos também agrupar os objetos de acordo com o campo que desejarmos.
            // No qual ele retorna um objeto do tipo IEnumerable<IGrouping>, onde é um par
            // que contem uma chave e uma coleção de objeto, nesse caso uma coleção de Product.
            var filter16 = products.GroupBy(x => x.Category);
            // Percorrendo o objeto recebido no filter16
            foreach (IGrouping<Category, Product> group in filter16)
            {
                // No exemplo abaixo, para imprimir o nome da categoria, usamos .Key, porque
                // a chave do IGrouping é a Category. Então Key = Category, no qual possui todos os atributos
                // de Category.
                Console.WriteLine($"Category {group.Key.Name}:");
                // Agora, faremos outro foreach para podemos percorrer a coleção de objetos
                foreach (Product product in group)
                {
                    // Imprimindo o objeto na tela
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }

            // Separando as listas
            Console.WriteLine("==================================================================");

            Console.WriteLine("Linq with SQL semantics:");
            Console.WriteLine();

            // Utilizando o Linq com a semantica semelhante ao SQL
            // result 1 = filter1 ->  ambos tem o mesmo resultado
            var result1 = from p in products where p.Category.Tier == 1 && p.Price < 900 select p;
            Print(message: "TIER 1 and Price < 900:", result1);

            // result2 = filter2
            var result2 = from p in products where p.Category.Name == "Tools" select p.Name;
            Print(message: "Names of products from tools:", result2);

            // result3 = filter3
            var result3 = from p in products
                          where p.Name[0] == 'C'
                          select new
                          {
                              p.Name,
                              p.Price,
                              CategoryName = p.Category.Name
                          };
            Print(message: "Names started width 'C' and anonymous object:", result3);

            // result4 = filter4
            // Nesse caso, para organizar pelo preço e usar o nome como criterio de desempate, primeiro
            // coloque o campo que sera usado para desempate, no caso o nome, e depois o item que sera usado para
            // poder ser usado para ordenar a lista como primario
            var result4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
            Print(message: "Tier 1 order by price then by name:", result4);

            // result5 = filter5
            // No caso abaixo, utilizamos a semantica parecida com SQL apenas para selecionar os objetos
            var result5 = (from p in products select p).Skip(2).Take(4);
            Print(message: "Tier 1 order by price then by name, skip 2 take 4:", result5);

            // result6 = filter6
            // Utiliza-se do mesmo exemplo acima citado
            var result6 = (from p in products where p.Price > 3000.00 select p).FirstOrDefault();
            Console.WriteLine("First or default: " + result6);
            Console.WriteLine(); // Saltando uma linha

            /**
             * Os exemplos sitados a partir do filter5 até filter15 funcionam desta mesma forma,
             * no qual utilizasse a semantica parecida com o SQL para selecionar o objeto, no qual o mesmo
             * deve estar entre parenteses (), depois o método que sera aplicado naquele objeto.
             */

            // result7 = filter16
            // Agrupando os objetos por categoria
            var result7 = from p in products group p by p.Category;
            foreach (IGrouping<Category, Product> group in result7)
            {
                Console.WriteLine($"Category {group.Key.Name}:");
                foreach (Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }

            // Separando as listas
            Console.WriteLine("=========================================================");

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
