string sourcePath = @"C:\Users\marco\Documents\CSharp\FilesTxt\File.txt";
string targetPath = @"C:\Users\marco\Documents\CSharp\FilesTxt\StreamWriter.txt";

try {
    // Lendo todo o contéudo dentro do File
    string[] lines = File.ReadAllLines(sourcePath);
    
    // Declarando StreamWriter para escrever no arquivo targetPath
    using (StreamWriter sw = File.AppendText(targetPath)) {
        foreach (string line in lines) {
            sw.WriteLine(line.ToUpper()); // Passando os dados dentro do sourcePath para maiusculo no targetPath
        }
    }

}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}