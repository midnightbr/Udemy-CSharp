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
            
            // Escolhendo qual propriedade sera mostrado na tela
            System.DateTime dt = new System.DateTime(2020, 12, 15, 08, 05, 30, 400);
            Console.WriteLine(dt);
            Console.WriteLine("01 - Date: " + dt.Date);
            Console.WriteLine("02 - Day: " + dt.Day);
            Console.WriteLine("03 - DayOfWeek: " + dt.DayOfWeek);
            Console.WriteLine("04 - DayOfYear: " + dt.DayOfYear);
            Console.WriteLine("05 - Hour: " + dt.Hour);
            Console.WriteLine("06 - Kind: " + dt.Kind);
            Console.WriteLine("07 - Millisecond: " + dt.Millisecond);
            Console.WriteLine("08 - Minute: " + dt.Minute);
            Console.WriteLine("09 - Month: " + dt.Month);
            Console.WriteLine("10 - Second: " + dt.Second);
            Console.WriteLine("11 - Ticks: " + dt.Ticks);
            Console.WriteLine("12 - TimeOfDay: " + dt.TimeOfDay);
            Console.WriteLine("13 - Year: " + dt.Year);
            
            // Convertendo data do tipo date para tipo string
            //Convertendo para o formato padrão do date
            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss")); // Declarando formato a ser mostrado
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss.fff")); // Monstrando variavel com o milisegundos
            // Convertendo a data (dd/mm/yyyy))
            Console.WriteLine(dt.ToLongDateString()); // Com o dia da semana e o nome do mês
            Console.WriteLine(dt.ToShortDateString()); // Apenas numeral
            // Convertendo a hora
            Console.WriteLine(dt.ToLongTimeString()); // Conversão com hora, minuto e segundo
            Console.WriteLine(dt.ToShortTimeString()); // Conversão somente com hora e minuto
            
            // Operações DateTime
            System.DateTime dtHours = dt.AddHours(2); // Recebendo a variavel dt com acrescimo de 2 horas
            Console.WriteLine(dtHours);
            System.DateTime dtMinutes = dt.AddMinutes(25); // Recebendo a variavel dt com acrescimo de 25 minutos
            Console.WriteLine(dtMinutes);
            // Exemplo de utilização do Add para criar um boleto e seu vencimento
            System.DateTime boleto = System.DateTime.Now;
            System.DateTime vencimento = boleto.AddDays(7); // Vencimento do boleto para daqui 7 dias
            Console.WriteLine("Data da emição do boleto: " + boleto);
            Console.WriteLine("Vencimento do boleto: " + vencimento);
            
            // Diferença entre duas datas
            TimeSpan ts = date1.Subtract(dt);
            Console.WriteLine(ts);
            Console.WriteLine("Days: " + ts.Days);
        }
    }
}
