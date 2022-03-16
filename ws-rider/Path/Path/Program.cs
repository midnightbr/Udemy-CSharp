using System.Threading.Channels;

string path = @"C:\Users\marco\Documents\CSharp\FilesTxt\File.txt";

// Pegando o diretorio do arquivo
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
// Separador de diretorio
Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
// Separador de Paths diferentes
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
// Pegando o nome do arquivo
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
// Pegando o nome do arquivo, sem a extensão
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
// Pegando somente a extensão do arquivo
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
// Pegando todo o caminho do arquivo
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
// Qual pasta temporaria posso usar para manipular arquivos temporarios de aplicações
Console.WriteLine("GetTempPath: " + Path.GetTempPath());