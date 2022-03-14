string path = @"C:\Users\marco\Documents\CSharp\File.txt";
string path2 = @"C:\Users\marco\Documents\CSharp\File2.txt";
/*
 * Como esses recursos não são CLR e sim uma conversa com o SO (Sistema Operacional),
 * tem que fechar a funcionalidade explícita ou manualmente.
 */
FileStream fs = null; // Instanciando FileStream
StreamReader sr =null; // Instanciando StreamReader
StreamReader sr2 = null;
try {
    // Passando para o FileStream o caminho do arquivo como paramento e a operação que deve executar
    fs = new FileStream(path, FileMode.Open); // Nesse caso, abrir o arquivo. Stream generica, sem tratamento.
    // Passando para o StreamReader o FileStream como parametro
    sr = new StreamReader(fs); // Stream particular para otimizar o que você deseja fazer com o arquivo
    // Aqui a variavel line vai receber a primeira linha do arquivo aberto pelo FileStream e passado para o StreamReader
    string line = sr.ReadLine(); // Aqui o StreamReader pega a linha do aquivo
    Console.WriteLine(line); // Imprimi a linha na tela
    
    /**
     * Forma mais resumida de instanciar o StreamReader
     */
    sr2 = File.OpenText(path2);
    // Essa opção ja instancia e executa as duas funcionalidades utilizada acima.
    line = sr2.ReadLine();
    Console.WriteLine(line);

     // Lendo todas as linhas do arquivo
    while (!sr2.EndOfStream)
    {
        line = sr2.ReadLine();
        Console.WriteLine(line);
    }
    
}
catch (IOException e) {
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}
finally {
    // Expressão lambda
    if (sr != null) sr.Close(); // Fechando StreamReader
    if (sr2 != null) sr2.Close();
    if (fs != null) fs.Close(); // Fechando FileStream
}