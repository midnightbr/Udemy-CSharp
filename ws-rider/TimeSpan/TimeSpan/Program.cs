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
            
            // Propriedades do TimeSpan
            System.TimeSpan timeMax = System.TimeSpan.MaxValue; // Atribuindo o valor maximo
            System.TimeSpan timeMin = System.TimeSpan.MinValue; // Atribuindo o valor minimo
            System.TimeSpan timeZero = System.TimeSpan.Zero; // Atribuindo o valor zero

            Console.WriteLine(timeMax);
            Console.WriteLine(timeMin);
            Console.WriteLine(timeZero);

            System.TimeSpan timeProp = new System.TimeSpan(5, 3, 5, 7, 11);
            Console.WriteLine(timeProp);
            Console.WriteLine("Days: " + timeProp.Days);
            Console.WriteLine("Hours: " + timeProp.Hours);
            Console.WriteLine("Minutes: " + timeProp.Minutes);
            Console.WriteLine("Seconds: " + timeProp.Seconds);
            Console.WriteLine("Milliseconds: " + timeProp.Milliseconds);
            Console.WriteLine("Ticks: " + timeProp.Ticks);

            Console.WriteLine("Total Days: " + timeProp.TotalDays);
            Console.WriteLine("Total Hours: " + timeProp.TotalHours);
            Console.WriteLine("Total Minutes: " + timeProp.TotalMinutes);
            Console.WriteLine("Total Seconds: " + timeProp.TotalSeconds);
            Console.WriteLine("Total Milliseconds: " + timeProp.TotalMilliseconds);
            
            // Operações com TimeSpan
            System.TimeSpan timeOper1 = new System.TimeSpan(2, 25, 10);
            System.TimeSpan timeOper2 = new System.TimeSpan(0, 35, 25);

            System.TimeSpan sum = timeOper1.Add(timeOper2);
            Console.WriteLine(sum);
            System.TimeSpan dif = timeOper1.Subtract(timeOper2);
            Console.WriteLine(dif);
            System.TimeSpan multi = timeOper2.Multiply(2.0); // Só recebe valores doubles, não recebe objetos TimeSpan
            Console.WriteLine(multi);
            System.TimeSpan div = timeOper1.Divide(2.0); // Mesma regra da operação Multiply
            Console.WriteLine(div);
        }
    }
}
