using System;

namespace ExProp_26 {
    class Program {
        static void Main(string[] args) {
            
            Rent[] vector = new Rent[10];
            
            Console.Write("How many rooms will be rented? ");
            int rent = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < rent; i++) {
                Console.WriteLine("Rent #{0}", (i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vector[room] = new Rent { Name = name, Email = email, Room = room };
                
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++) {
                if (vector[i] != null) {
                    Console.WriteLine(vector[i].Room + ": " 
                                                     + vector[i].Name + ", " 
                                                     + vector[i].Email);
                }
            }
        }
    }
}
