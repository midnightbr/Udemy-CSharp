using GetHashCode_and_Equals.Entities;

Client a = new Client() { Name = "Maria", Email = "marial@gmail.com" };
Client b = new Client() { Name = "Alex", Email = "alex@gmail.com" };

Console.WriteLine("Equals? " + a.Equals(b)); // Comparação de conteudo
Console.WriteLine(a == b); // Compara a referencia do ponteiro de memoria
Console.WriteLine("GetHashCode A = " + a.GetHashCode());
Console.WriteLine("GetHashCode B = " + b.GetHashCode());