string path = @"C:\Users\marco\Documents\CSharp\FilesTxt";

try {
    // Listando todas as pastas, partindo de FilesTxt
    /**
     * Explicando os itens da sobrecarga utilizado.
     * 1º - Diretorio da pasta
     * 2º - Quais parametros para busca. Nesse caso utilizamos o "*.*", que significa qualquer
     * arquivo e qualquer extensão. O parametro tem que ser passado como string.
     * 3º - Opção de busca. No qual foi escolhido o tipo enumerado SearchOption.AllDirectories, no qual
     * vai buscar em todos os diretorios.
     */
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS:");
    foreach (string folder in folders) {
        Console.WriteLine(folder);
    }

    Console.WriteLine();
    
    // Listando todos os arquivos dentro do diretorio princpal e subpastas
    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    // OBS.: Pode ser declarado a variavel do tipo var, e o C# fica encarregado de tipar a variavel
    Console.WriteLine("FILES:");
    foreach (string file in files) {
        Console.WriteLine(file);
    }
    
    // Criando uma pasta dentro do diretorio
    Directory.CreateDirectory(path + @"\logs");

}
catch (IOException e) {
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}
