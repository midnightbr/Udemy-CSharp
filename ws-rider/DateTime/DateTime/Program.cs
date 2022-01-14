using System;
using System.Globalization;

namespace DateTime {
    class Program {
        static void Main(string[] args) {
            // DateTime.Now funciona para pegar a data e a hora atual do computador
            System.DateTime date1 = System.DateTime.Now;
            // DateTime.Today funciona para pegar a data atual mais com o horario de 00:00 hrs
            System.DateTime date3 = System.DateTime.Today;
            // DateTime.UtcNow funcionar para pegar a hora e a hora atual do computador, só que no UTC 0
            System.DateTime date4 = System.DateTime.UtcNow;
            
            // Passando string para o DateTime
            // Formato internacional
            System.DateTime date5 = System.DateTime.Parse("1996-09-22");
            System.DateTime date6 = System.DateTime.Parse("2022-01-13 14:34:20"); // Passando a data com as horas inclusas
            // Formato Brasileiro
            System.DateTime dateBr = System.DateTime.Parse("06/01/2022");
            
            // Constructor para datetime
            System.DateTime date2 = new System.DateTime(2022, 06, 10, 10, 45, 00);

            // Criando sua propria formatação de data e hora
            System.DateTime date7 = System.DateTime.ParseExact("1996-09-22", "yyyy-MM-dd", 
                CultureInfo.InvariantCulture);
            System.DateTime date8 = System.DateTime.ParseExact("15/08/2015 13:05:32", "dd/MM/yyyy HH:mm:ss", 
                CultureInfo.InvariantCulture);
            
            Console.WriteLine(date1);
            Console.WriteLine(date1.Ticks);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);
            Console.WriteLine(date5);
            Console.WriteLine(date6);
            Console.WriteLine(dateBr);
            Console.WriteLine(date7);
            Console.WriteLine(date8);
            
        }
    }
}
