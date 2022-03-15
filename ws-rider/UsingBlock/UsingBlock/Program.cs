string path = @"C:\Users\marco\Documents\CSharp\File.txt";

try {
    // Após o termino desse bloco, ele finalizara todo recurso que foi iniciado
    // No qual, é possivel cascatear varios using dentro de outro
    using (FileStream fs = new FileStream(path, FileMode.Open)) {
        using (StreamReader sr = new StreamReader(fs)) {
            // Percorrendo todas as linhas do arquivo
            while (!sr.EndOfStream) {
                // Atribuindo a linha do arquivo para a variavel line
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
    // Instanciando de forma resumida. Obs.: executa a mesma função que o método acima.
    using (StreamReader sr = File.OpenText(path)) {
        while (!sr.EndOfStream) {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e) {
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}