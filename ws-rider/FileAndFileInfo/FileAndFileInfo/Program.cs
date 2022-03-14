// Caminho do arquivo de origem
string sourcePath = @"C:\Users\marco\Downloads\Rufus\rufus.log"; 
// Caminho para o arquivo de destino
string targetPath = @"C:\Users\marco\Documents\CSharp\File.txt";

try {
    // Instanciando FileInfo
    FileInfo fileInfo = new FileInfo(sourcePath);
    // Copiando o arquivo sourcePath para o arquivo targetPath
    fileInfo.CopyTo(targetPath);
    // Mostrando as informações do arquivo por linhas
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines) {
        Console.WriteLine(line);
    }
}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}


// // See https://aka.ms/new-console-template for more information
//
// Console.WriteLine("Hello, World!");
