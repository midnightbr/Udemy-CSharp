using System;
using System.Threading.Channels;

namespace DateTimeKind {
    class Program {
        static void Main(string[] args) {
            // Instanciando como se fosse horario local da maquina
            DateTime dateLocal = new DateTime(2022, 8, 15, 13, 
                5, 58, System.DateTimeKind.Local);
            DateTime dateUtc = new DateTime(2022, 8, 15, 13,
                5, 58, System.DateTimeKind.Utc);
            DateTime dateTime = new DateTime(2022, 8, 15, 13, 5, 58);

            Console.WriteLine("DateLocal: " + dateLocal);
            Console.WriteLine("DateLocal Kind: " + dateLocal.Kind);
            Console.WriteLine("DateLocal to Local: " + dateLocal.ToLocalTime());
            Console.WriteLine("DateLocal to UTC: " + dateLocal.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("DateUTC: " + dateUtc);
            Console.WriteLine("DateUTC Kind: " + dateUtc.Kind);
            Console.WriteLine("DateUTC to Local: " + dateUtc.ToLocalTime());
            Console.WriteLine("DateUTC to UTC: " + dateUtc.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("DateTime: " + dateTime);
            Console.WriteLine("DateTime Kind: " + dateTime.Kind);
            Console.WriteLine("DateTime to Local: " + dateTime.ToLocalTime());
            Console.WriteLine("DateTime to UTC: " + dateTime.ToUniversalTime());
            
            // Padrão ISO 8601
            DateTime dateIso = DateTime.Parse("2022-08-15T13:05:58Z");
            Console.WriteLine();
            Console.WriteLine("DateISO: " + dateIso);
            Console.WriteLine("DateISO Kind: " + dateIso.Kind);
            Console.WriteLine("DateISO to Local: " + dateIso.ToLocalTime());
            Console.WriteLine("DateISO to UTC: " + dateIso.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(dateIso.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Cuidado! Formato mais adequado abaixo
            Console.WriteLine(dateIso.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
