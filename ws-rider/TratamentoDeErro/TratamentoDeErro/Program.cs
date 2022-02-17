using System;
using System.IO;

namespace TratamentoDeErro {
    class Program {
        static void Main(string[] args) {
            FileStream fs = null;
            try {
                fs = new FileStream(@"/home/midnight/Documentos/teste.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            // Tratamento de erro caso o arquivo não existir
            catch (FileNotFoundException e) {
                Console.WriteLine(e.Message);
            }
            /*
             * Independente da execução do código ou tratamento do erro, o finally é
             * para encerrar processos que continuam em aberto, nesse caso o processo FileStream
             * no qual precisa ser encerrado manualmente.
             */
            finally {
                if (fs != null) {
                    fs.Close();
                }
            }
        }
    }
}