using System;

namespace TimeSpan {
    class Program {
        static void Main(string[] args) {
            System.TimeSpan time1 = new System.TimeSpan(3, 1, 30);
            Console.WriteLine(time1);
            
            // Construtores do TimeSpan
            System.TimeSpan time2 = new System.TimeSpan();
            Console.WriteLine(time2);
            // Construindo TimeSpan com ticks
            System.TimeSpan time3 = new System.TimeSpan(900000000L);
            Console.WriteLine(time3);
            // Criando um TimeSpan com Dias
            System.TimeSpan time4 = new System.TimeSpan(1, 2, 11, 50);
            Console.WriteLine(time4);
            // Criando um TimeSpan com os milesegundos inclusos
            System.TimeSpan time5 = new System.TimeSpan(2, 10, 5, 35, 320);
            Console.WriteLine(time5);

            // Criando um TimeSpan com métodos prontos
            System.TimeSpan timeDay = System.TimeSpan.FromDays(1.5);
            Console.WriteLine(timeDay);
            System.TimeSpan timeHours = System.TimeSpan.FromHours(2.7);
            Console.WriteLine(timeHours);
            System.TimeSpan timeMinutes = System.TimeSpan.FromMinutes(1.8);
            Console.WriteLine(timeMinutes);
            System.TimeSpan timeSeconds = System.TimeSpan.FromSeconds(2.7);
            Console.WriteLine(timeSeconds);
            System.TimeSpan timeMiliseconds = System.TimeSpan.FromMilliseconds(1);
            Console.WriteLine(timeMiliseconds);
            System.TimeSpan timeTicks = System.TimeSpan.FromTicks(1250900000L); // Não aceita valores quebrados
            Console.WriteLine(timeTicks);
        }
    }
}
